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
	public partial class EmployeeReport : Form
	{
		public EmployeeReport()
		{
			InitializeComponent();
		}
		string connectionstring = "Data source = LAPTOP-J4A8AKB6\\JASH; Initial Catalog =Hostel;Integrated Security=SSPI";

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				{
					SqlConnection con = new SqlConnection(connectionstring);
					SqlCommand cmd = new SqlCommand();
					cmd.CommandType = CommandType.Text;
					cmd.Connection = con;
					con.Open();
					cmd.CommandText = @"SELECT HostelIncharge,EmpName,Address,EmpSalary,Contact,HostBuldNo FROM MessEmployee
                                     where HostelIncharge Like @Search OR EmpName Like @Search OR Address Like @Search OR EmpSalary Like @Search OR Contact Like @Search OR HostBuldNo Like @Search ";
					cmd.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
					SqlDataAdapter da = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					da.Fill(dt);
					gvEmployeeReport.DataSource = dt;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Something went wrong", "Error-!", MessageBoxButtons.OK, MessageBoxIcon.Error);


			}

		}
	}
}
