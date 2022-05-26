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
	public partial class LoginForm : System.Windows.Forms.Form
	{

		public LoginForm()
		{
			InitializeComponent();
		}
		Code cd = new Code();
		string connectionstring = ("Data source = LAPTOP-J4A8AKB6\\JASH; Initial Catalog =Hostel;Integrated Security=SSPI");
		private void btnLogin_Click(object sender, EventArgs e)
		{
			try
			{

				SqlConnection con = new SqlConnection(connectionstring);
				SqlCommand cmd = new SqlCommand("Select * from Register where UserName ='" + txtUserName.Text + "' AND Password='" + cd.PassED(txtPassword.Text) + "'", con);
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				string cmbItemValue = cmbRole.SelectedItem.ToString();
				if (dt.Rows.Count > 0)
				{
					for (int i = 0; i < dt.Rows.Count; i++)
					{
						if (dt.Rows[i]["Role"].ToString() == cmbItemValue)
						{
							MessageBox.Show("You are LogIn as " + dt.Rows[i][5]);
							if (cmbRole.SelectedIndex == 0)
							{
								this.Hide();
								AdminMainForm mf = new AdminMainForm();
								mf.Show();
							}
							
							else if (cmbRole.SelectedIndex == 1)
							{
								this.Hide();
								UserMainForm mfu = new UserMainForm();
								mfu.Show();
							}
							else if (cmbRole.SelectedIndex == 2)
							{
								this.Hide();
								SupervisorMainForm mfu = new SupervisorMainForm();
								mfu.Show();
							}
						}
					}
				}
				else
				{
					MessageBox.Show("Please check your Username and Password...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}		
			}
			catch (Exception ex)
			{
				MessageBox.Show("Something went wrong...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}


