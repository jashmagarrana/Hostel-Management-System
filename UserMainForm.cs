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
	public partial class UserMainForm : Form
	{
		public UserMainForm()
		{
			InitializeComponent();
		}

		private void studentFormToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Student st = new Student();
			st.Show();
		}

		private void visitorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Visitor vs = new Visitor();
			vs.Show();

		}

		private void feesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Fee fe = new Fee();
			fe.Show();
		}
	}
}
