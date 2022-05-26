using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm.cs
{
	public partial class Student : Form
	{
		public Student()
		{
			InitializeComponent();
		}
		private void ClearForm()
		{
			txtName.Text = string.Empty;
			txtFatherName.Text = string.Empty;
			txtDepartment.Text = string.Empty;
			txtContact.Text = string.Empty;
			cmbRoomNumber.SelectedIndex = 0;
			txtAge.Text = string.Empty;

		}

		private bool FormValidation()
		{

			if (txtName.Text == string.Empty)
			{
				MessageBox.Show(" Name is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtName.Focus();
				return false;
			}

			if (txtFatherName.Text == string.Empty)
			{
				MessageBox.Show("FatherName  is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtFatherName.Focus();
				return false;
			}

			if (txtDepartment.Text == string.Empty)
			{
				MessageBox.Show("Department is Required...!!!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtDepartment.Focus();
				return false;
			}

			if (txtContact.Text == string.Empty)
			{
				MessageBox.Show("Contact is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtContact.Focus();
				return false;
			}

			return true;
		}
		string Gender;	
		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				var confirmation = MessageBox.Show("Do yo want to Submit", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (confirmation == DialogResult.Yes)
				{
					bool isValidationSuccess = FormValidation();
					if (isValidationSuccess == true)
					{
						{
							if (RadiobtnMale.Checked == true)
							{
								Gender = "Male";
							}
							else if (RadiobtnFemale.Checked == true)
							{
								Gender = "FeMale";
							}
							else if (RadiobtnOther.Checked)
							{

								Gender = "Others";
							}
							string connection = "Data source = LAPTOP-J4A8AKB6\\JASH; Initial Catalog =Hostel;Integrated Security=SSPI";

							SqlConnection con = new SqlConnection(connection);
							SqlCommand cmd = new SqlCommand();
							cmd.CommandType = CommandType.Text;
							cmd.Connection = con;
							con.Open();
							cmd.CommandText = @"INSERT INTO Students(StudentName,FathersName,Contact,Department,RoomId,Age,Gender)" +
								             " VALUES(@StudentName,@FathersName,@Contact,@Department,@RoomId,@Age,@Gender)";
							cmd.Parameters.AddWithValue("@StudentName", txtName.Text);
							cmd.Parameters.AddWithValue("@FathersName", txtFatherName.Text);
							cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
							cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);
							cmd.Parameters.AddWithValue("@RoomId", cmbRoomNumber.Text);
							cmd.Parameters.AddWithValue("@Age", txtAge.Text);
							cmd.Parameters.AddWithValue("@Gender", Gender);


							cmd.ExecuteNonQuery();
							MessageBox.Show("Data Successfully Submitted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							ClearForm();
						}
					}

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to save", "Error--!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
