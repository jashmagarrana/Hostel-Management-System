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
	public partial class Visitor : Form
	{
		public Visitor()
		{
			InitializeComponent();
		}
		string connectionstring = "Data source = LAPTOP-J4A8AKB6\\JASH; Initial Catalog =Hostel;Integrated Security=SSPI";
		private void LoadStudent()
		{
			try
			{
			
				SqlConnection con = new SqlConnection(connectionstring);
				SqlCommand cmd = new SqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.Connection = con;
				con.Open();
				cmd.CommandText = cmd.CommandText = "Select StudentId,StudentsName, FathersName, Contact, Department, RoomId, Age, Gender from Students";

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);


				cmbStudentId.DisplayMember = "StudentId";
				cmbStudentId.ValueMember = "StudentId";
				cmbStudentId.DataSource = dt;
			}
			catch (Exception ex)
			{

				MessageBox.Show("Something went wrong;", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void LoadGrid()
		{
			txtVisitorId.Visible = false;
			SqlConnection con = new SqlConnection(connectionstring);
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.Connection = con;
			con.Open();
			cmd.CommandText = "SELECT * FROM Visitor"; 
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			gvVisitor.DataSource = dt;
		}
		private void Visitor_Load(object sender, EventArgs e)
		{

			LoadStudent();	
		}
		private void ClearForm()
		{
			
			txtVisitorName.Text = string.Empty;
			txtTimeIn.Text = string.Empty;
			txtTimeOut.Text = string.Empty;
			txtDate.Text = string.Empty;
			cmbStudentId.Text = string.Empty;

		}
		private bool FormValidation()
		{

			if (txtVisitorName.Text == string.Empty)
			{
				MessageBox.Show("VisitorName  is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtVisitorName.Focus();
				return false;
			}
			//if (txtTimeIn.Text == string.Empty)
			//{
				//MessageBox.Show("TimeIn is Required...!!!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				//txtTimeIn.Focus();
				//return false;
			//}
			if (txtDate.Text == string.Empty)
			{
				MessageBox.Show("Date is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtDate.Focus();
				return false;
			}
			if (cmbStudentId.Text == string.Empty)
			{
				MessageBox.Show("StudentId is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmbStudentId.Focus();
				return false;
			}
			return true;
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			 
				try
			{
				var confirmation = MessageBox.Show("Do yo wish to Submit", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (confirmation == DialogResult.Yes)
				{
					bool isValidationSuccess = FormValidation();
					if (isValidationSuccess == true)
					{
						string connection = "Data source = LAPTOP-J4A8AKB6\\JASH; Initial Catalog =Hostel;Integrated Security=SSPI";
						SqlConnection con = new SqlConnection(connection);
						SqlCommand cmd = new SqlCommand();
						cmd.CommandType = CommandType.Text;
						cmd.Connection = con;
						con.Open();
						cmd.CommandText = "INSERT INTO Visitor(VisitorName,TimeIn,TimeOut,Date,StudentId) VALUES(@VisitorName,@TimeIn,@TimeOut,@Date,@StudentId)";
						cmd.Parameters.AddWithValue("@VisitorName", txtVisitorName.Text);
						cmd.Parameters.AddWithValue("@TimeIn", txtTimeIn.Text);
						cmd.Parameters.AddWithValue("@TimeOut", txtTimeOut.Text);
						cmd.Parameters.AddWithValue("@Date", txtDate.Text);
						cmd.Parameters.AddWithValue("@StudentId", cmbStudentId.Text);
						cmd.ExecuteNonQuery();
						MessageBox.Show("Data Submitted Successfully ", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
						ClearForm();
						LoadGrid();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Something went wrong..!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
}
		private void gvVisitor_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			txtVisitorId.Text = (gvVisitor.Rows[e.RowIndex].Cells[0].Value.ToString());
			txtVisitorName.Text = (gvVisitor.Rows[e.RowIndex].Cells[1].Value.ToString());
			txtTimeIn.Text = (gvVisitor.Rows[e.RowIndex].Cells[2].Value.ToString());
			txtTimeOut.Text = (gvVisitor.Rows[e.RowIndex].Cells[3].Value.ToString());
			txtDate.Text = (gvVisitor.Rows[e.RowIndex].Cells[4].Value.ToString());
			cmbStudentId.Text = (gvVisitor.Rows[e.RowIndex].Cells[5].Value.ToString());

		}
		private void gvVisitor_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
		{
			
		}

		
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				var confrimation = MessageBox.Show("Do you want to Update?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (confrimation == DialogResult.Yes)
				{
					string strTimeIn = txtTimeIn.Text;
		
					if (strTimeIn == string.Empty)
					{
						MessageBox.Show("VisitorNumber is required", "Warning--!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
					string StrTimeOut = txtTimeOut.Text;

					if (StrTimeOut == string.Empty)
					{
						MessageBox.Show("TimeOut is required", "Warning--!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
					string connection = "Data source = LAPTOP-J4A8AKB6\\JASH; Initial Catalog =Hostel;Integrated Security=SSPI";
					SqlConnection con = new SqlConnection(connection);
					SqlCommand cmd = new SqlCommand();
					cmd.CommandType = CommandType.Text;
					cmd.Connection = con;
					con.Open();
					cmd.CommandText = "Update Visitor set VisitorName=@VisitorName,TimeIn=@TimeIn,TimeOut=@TimeOut,Date=@Date,StudentId=@StudentId where VisitorId = @VisitorId";
					cmd.Parameters.AddWithValue("@VisitorName", txtVisitorName.Text);
					cmd.Parameters.AddWithValue("@TimeIn", txtTimeIn.Text);
					cmd.Parameters.AddWithValue("@TimeOut", txtTimeOut.Text );
					cmd.Parameters.AddWithValue("@Date", txtDate.Text = DateTime.Now.ToString());
					cmd.Parameters.AddWithValue("@StudentId", cmbStudentId.Text);
					cmd.Parameters.AddWithValue("@VisitorId", txtVisitorId.Text);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Visitor updated succesfully", "Success-!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadGrid();
					ClearForm();
				}
				else
				{
					MessageBox.Show("You dont have permission to update");
				}
			}
			catch (Exception ex)
			{
					MessageBox.Show("Something went wrong", "Error-!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
				 }
			}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtStudentId_TextChanged(object sender, EventArgs e)
		{

		}

		private void gvVisitor_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
