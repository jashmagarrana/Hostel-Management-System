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
	public partial class Room : Form
	{
		public Room()
		{
			InitializeComponent();
		}
		private void ClearForm()
		{
			cmbRoomNumber.SelectedIndex = 0;
			txtCapacity.Text = string.Empty;
			ckbFurniture.Text = string.Empty;
			txtBuldNo.Text = string.Empty;

		}
		private bool FormValidation()
		{
			
			if (ckbFurniture.Text == string.Empty)
			{
				MessageBox.Show("Furniture is Required...!!!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				ckbFurniture.Focus();
				return false;
			}
			if (txtBuldNo.Text == string.Empty)
			{
				MessageBox.Show("Building No is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtBuldNo.Focus();
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
						cmd.CommandText = "INSERT INTO Room(RoomId,Capacity,Furniture,BoysHostBuldNo) VALUES(@RoomId,@Capacity,@Furniture,@BoysHostBuldNo)";
						cmd.Parameters.AddWithValue("@RoomId", cmbRoomNumber.Text);
						cmd.Parameters.AddWithValue("@Capacity", txtCapacity.Text);
						cmd.Parameters.AddWithValue("@Furniture", ckbFurniture.Text);

						cmd.Parameters.AddWithValue("@BoysHostBuldNo", txtBuldNo.Text);
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

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
