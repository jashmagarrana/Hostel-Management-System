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
	public partial class Fee : Form
	{
		public Fee()
		{
			InitializeComponent();
		}
		string connectionstring = "Data source = LAPTOP-J4A8AKB6\\JASH; Initial Catalog =Hostel;Integrated Security=SSPI";

		private void LoadGrid()
		{
			

			SqlConnection con = new SqlConnection(connectionstring);
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.Connection = con;
			con.Open();
			cmd.CommandText = "SELECT *FROM Fee where FeeStatus ='Not Paid'";
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			gvFee.DataSource = dt;
		}
		private void clearForm()
		{
			txtStudentId.Text = string.Empty;
			cmbFeeStatus.Text = string.Empty;
			cmbFeeMonth.SelectedIndex = 0;
		}
		private bool FormValidation()
		{

			
			if (txtStudentId.Text == string.Empty)
			{
				MessageBox.Show("StudentId is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtStudentId.Focus();
				return false;
			}

			return true;
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				var confirm = MessageBox.Show("Do you want to Submit?", "confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
				if (confirm.ToString().ToUpper() == "OK")
				{

					using (SqlConnection con = new SqlConnection(connectionstring))
					{
						bool isValidationSucess = FormValidation();
						if (isValidationSucess == true)
						{
							SqlCommand cmd = new SqlCommand();
							cmd.CommandType = CommandType.Text;
							cmd.Connection = con;
							con.Open();
							cmd.CommandText = "INSERT INTO Fee (FeeMonth,FeeStatus,studentId) values(@FeeMonth,@FeeStatus,@studentId)";
							cmd.Parameters.AddWithValue("@FeeMonth", cmbFeeMonth.Text);
							cmd.Parameters.AddWithValue("@FeeStatus", cmbFeeStatus.Text);
							cmd.Parameters.AddWithValue("@studentId", txtStudentId.Text);
							cmd.ExecuteNonQuery();
							MessageBox.Show("Fee record submitted successfully...!!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							clearForm();
							LoadGrid();

						}
					}
				}
						}
			catch (Exception ex)
			{

				MessageBox.Show("Something went wrong..!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Fee_Load(object sender, EventArgs e)
		{
			LoadGrid();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
