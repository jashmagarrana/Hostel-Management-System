using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm.cs
{
	public partial class AdminMainForm : Form
	{
		public AdminMainForm()
		{
			InitializeComponent();
		}

		private void hostelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Hostel ho = new Hostel();
			ho.Show();
		}
		private void feeToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Fee fe = new Fee();
			fe.Show();
		}

		private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Student st = new Student();
			st.Show();
		}

		private void messEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessEmployee me = new MessEmployee();
			me.Show();
		}

		private void roomToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Room ro = new Room();
			ro.Show();
		}

		private void visitorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Visitor vs = new Visitor();
			vs.Show();
		}

		private void employeeReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			EmployeeReport er = new EmployeeReport();
			er.Show();
		}

		
		private void visitorReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			VisitorReport vr = new VisitorReport();
			vr.Show();
		}

		private void registerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Register r = new Register();
			r.Show();
		}
	}
}
