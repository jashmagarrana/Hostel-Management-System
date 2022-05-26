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
	public partial class SupervisorMainForm : Form
	{
		public SupervisorMainForm()
		{
			InitializeComponent();
		}

		private void hostelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Hostel h = new Hostel();
			h.Show();
		}

		private void messToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void messEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessEmployee ms = new MessEmployee();
			ms.Show();
		}

		private void roomToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Room r = new Room();
			r.Show();
		}

		private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Student s = new Student();
			s.Show();
		}

		private void visitorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Visitor v = new Visitor();
			v.Show();
		}

		private void feeToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Fee f = new Fee();
			f.Show();
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

		private void hostelToolStripMenuItem_Click_1(object sender, EventArgs e)
		{

		}
	}
}
