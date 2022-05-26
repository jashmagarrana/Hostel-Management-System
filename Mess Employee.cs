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
	public partial class MessEmployee : Form
	{
		public MessEmployee()
		{
			InitializeComponent();
		}
		

		private void ClearForm()
		{
			txtEmployeeId.Visible = false;
			txtHostelIncharge.Text = string.Empty;
			txtEmpName.Text = string.Empty;
			txtAddress.Text = string.Empty;
			txtEmpSalary.Text = string.Empty;
			txtContactNo.Text = string.Empty;
			txtHostelBuildNo.Text = string.Empty;
		}

		private bool FormValidation()
		{

			if (txtHostelIncharge.Text == string.Empty)
			{
				MessageBox.Show("Hostel Incharge is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtHostelIncharge.Focus();
				return false;
			}

			if (txtEmpName.Text == string.Empty)
			{
				MessageBox.Show("EmpName is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtEmpName.Focus();
				return false;
			}
			if (txtAddress.Text == string.Empty)
			{
				MessageBox.Show("Address is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtAddress.Focus();
				return false;
			}
			if (txtEmpSalary.Text == string.Empty)
			{
				MessageBox.Show("EmpSalary is Required ...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtEmpSalary.Focus();
				return false;
			}

			if (txtContactNo.Text == string.Empty)
			{
				MessageBox.Show("ContactNo is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtContactNo.Focus();
				return false;
			}
			if (txtHostelBuildNo.Text == string.Empty)
			{
				MessageBox.Show("HostelBuildNo Number is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtHostelBuildNo.Focus();
				return false;
			}

			return true;
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				var confirmation = MessageBox.Show("Do yo want to Submit", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (confirmation == DialogResult.Yes)
				{
					bool isValidationSucess = FormValidation();
					if (isValidationSucess == true)

					{
						string connection = "Data source = LAPTOP-J4A8AKB6\\JASH; Initial Catalog =Hostel;Integrated Security=SSPI";
						SqlConnection con = new SqlConnection(connection);
						SqlCommand cmd = new SqlCommand();
						cmd.CommandType = CommandType.Text;
						cmd.Connection = con;
						con.Open();
						cmd.CommandText = @"INSERT INTO MessEmployee(HostelIncharge,EmpName,Address,EmpSalary,Contact,HostBuldNo) 
                                             VALUES(@HostelIncharge,@EmpName,@Address,@EmpSalary,@Contact,@HostBuldNo)";
						cmd.Parameters.AddWithValue("@HostelIncharge", txtHostelIncharge.Text);
						cmd.Parameters.AddWithValue("@EmpName", txtEmpName.Text);
						cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
						cmd.Parameters.AddWithValue("@EmpSalary", txtEmpSalary.Text);
						cmd.Parameters.AddWithValue("@Contact", txtContactNo.Text);
						cmd.Parameters.AddWithValue("@HostBuldNo", txtHostelBuildNo.Text);
						cmd.ExecuteNonQuery();
						MessageBox.Show("Data Successfully Submitted", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
						ClearForm();
					}
				}
			}
			catch (Exception ex)

			{

				MessageBox.Show("Something went wrong..!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			}

		private void btnReset_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
