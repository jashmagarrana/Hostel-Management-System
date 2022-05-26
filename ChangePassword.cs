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
	public partial class ChangePassword : Form
	{
		public ChangePassword()
		{
			InitializeComponent();
		}
		string connectionstring = "Data source = LAPTOP-J4A8AKB6\\JASH; Initial Catalog =Hostel;Integrated Security=SSPI";
		private void btnChangePassword_Click(object sender, EventArgs e)
		{
			try
			{
				var confirm = MessageBox.Show("Do you want to Register?", "confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
				if (confirm.ToString().ToUpper() == "OK")
				{
					SqlConnection con = new SqlConnection(connectionstring);
					SqlDataAdapter da = new SqlDataAdapter("Select count(*) from Register where UserName ='" + txtUserName.Text + "' and Password='" + txtOldPassword.Text + "'", con);
					DataTable dt = new DataTable();
					da.Fill(dt);
					if (dt.Rows[0][0].ToString() == "1")
					{
						if (txtNewPassword.Text == txtConfirmPassword.Text)
						{
							SqlDataAdapter dc = new SqlDataAdapter("Update Register set Password='" + txtNewPassword.Text + "' Where UserName ='" + txtUserName.Text + "' and Password='" + txtOldPassword.Text + "' ", con);
							DataTable df = new DataTable();
							dc.Fill(df);
							MessageBox.Show("Password Changed Successfully...!!!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show(" Password donot match...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						MessageBox.Show("Please check your Username and Password...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					txtUserName.Text = string.Empty;
					txtOldPassword.Text = string.Empty;
					txtNewPassword.Text = string.Empty;
					txtConfirmPassword.Text = string.Empty;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Something went wrong...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ChangePassword_Load(object sender, EventArgs e)
		{

		}
	}
}
