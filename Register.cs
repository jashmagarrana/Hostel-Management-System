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
	
	public partial class Register : Form
	{
		Code cd = new Code();
		public Register()
		{
			InitializeComponent();
		}
		string connectionstring= "Data source = LAPTOP-J4A8AKB6\\JASH; Initial Catalog =Hostel;Integrated Security=SSPI";
		private void LoadMessEmployee()
		{
			try
			{

				SqlConnection con = new SqlConnection(connectionstring);
				SqlCommand cmd = new SqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.Connection = con;
				con.Open();
				cmd.CommandText = cmd.CommandText = "Select * from MessEmployee";

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				cmbEmployeeId.DisplayMember = "EmployeeId";
				cmbEmployeeId.ValueMember = "EmployeeId";
				cmbEmployeeId.DataSource = dt;
			}
			catch (Exception ex)
			{

				MessageBox.Show("Something went wrong;", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void Register_Load(object sender, EventArgs e)
		{
			LoadMessEmployee();
		}
		private void ClearForm()
		{
			cmbRole.SelectedIndex = -1;
			cmbEmployeeId.SelectedIndex = -1;
			txtUserName.Text = string.Empty;
			txtPassword.Text = string.Empty;
			txtConfirmPassword.Text = string.Empty;
			txtEmail.Text = string.Empty;
			txtPhone.Text = string.Empty;
			cmbRole.Text = string.Empty;
		}
		private bool FormValidation()
		{
			if (txtUserName.Text == string.Empty)
			{
				MessageBox.Show("User Name is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtUserName.Focus();
				return false;
			}
			if (txtPassword.Text == string.Empty)
			{
				MessageBox.Show("Password  is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtPassword.Focus();
				return false;
			}
			if (txtPassword.Text != txtConfirmPassword.Text)
			{
				MessageBox.Show("Password donot match...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtConfirmPassword.Focus();
				return false;
			}
			if (txtEmail.Text == string.Empty)
			{
				MessageBox.Show("Email is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtEmail.Focus();
				return false;
			}
			if (txtPhone.Text == string.Empty)
			{
				MessageBox.Show("Phone Number is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtPhone.Focus();
				return false;
			}
			if (cmbRole.Text == string.Empty)
			{
				MessageBox.Show("User Type is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmbRole.Focus();
				return false;
			}
			return true;
		}
		private void btnRegister_Click(object sender, EventArgs e)
		{
			try
			{
				var confirm = MessageBox.Show("Do you want to Register?", "confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
				if (confirm.ToString().ToUpper() == "OK")
				{
					using (SqlConnection con = new SqlConnection(connectionstring))
					{
						bool isValiationSucess = FormValidation();
						if (isValiationSucess == true)
						{

							SqlCommand cmd = new SqlCommand();
							cmd.Connection = con;
							cmd.CommandType = CommandType.Text;
							cmd.CommandText = @"INSERT INTO Register(UserName,Password,Email,Phone,Role,EmployeeId)
                                         values (@UserName,@Password,@Email,@Phone,@Role,@EmployeeId)";
							con.Open();
							cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
							cmd.Parameters.AddWithValue("@Password",cd.PassED( txtPassword.Text));
							cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
							cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
							cmd.Parameters.AddWithValue("@Role", cmbRole.Text);
							cmd.Parameters.AddWithValue("@EmployeeId", cmbEmployeeId.Text);
							cmd.ExecuteNonQuery();
							MessageBox.Show("Registered  sucessfully...!!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							ClearForm();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Something went wrong...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
