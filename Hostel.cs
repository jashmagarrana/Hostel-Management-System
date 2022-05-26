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
	public partial class Hostel : Form
	{
		public Hostel()
		{
			InitializeComponent();
		}

		private void ClearForm()
		{
			txtBuildingNumber.Text = string.Empty;
			txtNoOfRoom.Text = string.Empty;
			txtNoOfStudents.Text = string.Empty;
			txtLocation.Text = string.Empty;
		}

		private bool FormValidation()
		{

			if (txtBuildingNumber.Text == string.Empty)
			{
				MessageBox.Show("BuildingNumber is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtBuildingNumber.Focus();
				return false;
			}

			if (txtNoOfRoom.Text == string.Empty)
			{
				MessageBox.Show("NoOfRoom is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtNoOfRoom.Focus();
				return false;
			}

			if (txtNoOfStudents.Text == string.Empty)
			{
				MessageBox.Show("NoOfStudents is Required...!!!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtNoOfStudents.Focus();
				return false;
			}

			return true;
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				var confirmation = MessageBox.Show("Do yo want to submit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (confirmation == DialogResult.Yes)
				{
					bool isValidationSuccess = FormValidation();
					if (isValidationSuccess == true)
					{

						//step-1 prepare ConnectionString
						//string connection=System.Configuration.ConfigurationManager.ConnectionString["con"].ConnectionString.ToString();
						string connection = "Data source = LAPTOP-J4A8AKB6\\JASH; Initial Catalog =Hostel;Integrated Security=SSPI";

						//step-2 prepare for sql connection
						SqlConnection con = new SqlConnection(connection);

						//step-3 prepare for sql command
						SqlCommand cmd = new SqlCommand();
						cmd.CommandType = CommandType.Text;
						cmd.Connection = con;
						con.Open();
						cmd.CommandText = "INSERT INTO Hostel(HostelId,NoOfRoom,NoOfStudents,Location) VALUES(@HostelId,@NoOfRoom,@NoOfStudents,@Location)";
						cmd.Parameters.AddWithValue("@HostelId", txtBuildingNumber.Text);

						cmd.Parameters.AddWithValue("@NoOfRoom", txtNoOfRoom.Text);
						cmd.Parameters.AddWithValue("@NoOfStudents", txtNoOfStudents.Text);
						cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
						cmd.ExecuteNonQuery();
						MessageBox.Show("Data Successfully Submitted", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
						txtNoOfRoom.Text = string.Empty;
						txtNoOfStudents.Text = string.Empty;
						txtNoOfRoom.Text = string.Empty;
					}
				}
			}
			catch (Exception)
			{
					MessageBox.Show("Something went wrong..!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
	}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
