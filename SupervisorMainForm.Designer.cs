namespace LoginForm.cs
{
	partial class SupervisorMainForm
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
			this.hostelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.messEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.feeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.visitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.employeeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.visitorReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hostelToolStripMenuItem,
            this.roomToolStripMenuItem,
            this.messEmployeeToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.feeToolStripMenuItem1,
            this.visitorToolStripMenuItem,
            this.employeeReportToolStripMenuItem,
            this.visitorReportToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(569, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// hostelToolStripMenuItem
			// 
			this.hostelToolStripMenuItem.Name = "hostelToolStripMenuItem";
			this.hostelToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.hostelToolStripMenuItem.Text = "Hostel";
			this.hostelToolStripMenuItem.Click += new System.EventHandler(this.hostelToolStripMenuItem_Click_1);
			// 
			// roomToolStripMenuItem
			// 
			this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
			this.roomToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.roomToolStripMenuItem.Text = "Room";
			// 
			// messEmployeeToolStripMenuItem
			// 
			this.messEmployeeToolStripMenuItem.Name = "messEmployeeToolStripMenuItem";
			this.messEmployeeToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
			this.messEmployeeToolStripMenuItem.Text = "Mess Employee";
			// 
			// studentsToolStripMenuItem
			// 
			this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
			this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.studentsToolStripMenuItem.Text = "Students";
			// 
			// feeToolStripMenuItem1
			// 
			this.feeToolStripMenuItem1.Name = "feeToolStripMenuItem1";
			this.feeToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
			this.feeToolStripMenuItem1.Text = "Fee";
			// 
			// visitorToolStripMenuItem
			// 
			this.visitorToolStripMenuItem.Name = "visitorToolStripMenuItem";
			this.visitorToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.visitorToolStripMenuItem.Text = "Visitor";
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
			// SupervisorMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(569, 288);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "SupervisorMainForm";
			this.Text = "Supervisior";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem hostelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem messEmployeeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem feeToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem visitorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem employeeReportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem visitorReportToolStripMenuItem;
	}
}