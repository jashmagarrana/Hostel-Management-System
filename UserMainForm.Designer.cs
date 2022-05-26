namespace LoginForm.cs
{
	partial class UserMainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.studentFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.visitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.feesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.employeeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.visitorReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Red;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentFormToolStripMenuItem,
            this.visitorToolStripMenuItem,
            this.feesToolStripMenuItem,
            this.employeeReportToolStripMenuItem,
            this.visitorReportToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(406, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// studentFormToolStripMenuItem
			// 
			this.studentFormToolStripMenuItem.Name = "studentFormToolStripMenuItem";
			this.studentFormToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.studentFormToolStripMenuItem.Text = "Students";
			this.studentFormToolStripMenuItem.Click += new System.EventHandler(this.studentFormToolStripMenuItem_Click);
			// 
			// visitorToolStripMenuItem
			// 
			this.visitorToolStripMenuItem.Name = "visitorToolStripMenuItem";
			this.visitorToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.visitorToolStripMenuItem.Text = "Visitor";
			this.visitorToolStripMenuItem.Click += new System.EventHandler(this.visitorToolStripMenuItem_Click);
			// 
			// feesToolStripMenuItem
			// 
			this.feesToolStripMenuItem.Name = "feesToolStripMenuItem";
			this.feesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
			this.feesToolStripMenuItem.Text = "Fees";
			this.feesToolStripMenuItem.Click += new System.EventHandler(this.feesToolStripMenuItem_Click);
			// 
			// employeeReportToolStripMenuItem
			// 
			this.employeeReportToolStripMenuItem.Name = "employeeReportToolStripMenuItem";
			this.employeeReportToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
			this.employeeReportToolStripMenuItem.Text = "Employee Report";
			// 
			// visitorReportToolStripMenuItem
			// 
			this.visitorReportToolStripMenuItem.Name = "visitorReportToolStripMenuItem";
			this.visitorReportToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
			this.visitorReportToolStripMenuItem.Text = "Visitor Report";
			// 
			// UserMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SeaGreen;
			this.ClientSize = new System.Drawing.Size(406, 251);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "UserMainForm";
			this.Text = "UserMainForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem studentFormToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem visitorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem feesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem employeeReportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem visitorReportToolStripMenuItem;
	}
}