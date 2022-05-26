namespace LoginForm.cs
{
	partial class Visitor
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
			this.txtVisitorName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTimeOut = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtDate = new System.Windows.Forms.DateTimePicker();
			this.gvVisitor = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTimeIn = new System.Windows.Forms.TextBox();
			this.txtVisitorId = new System.Windows.Forms.TextBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.cmbStudentId = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gvVisitor)).BeginInit();
			this.SuspendLayout();
			// 
			// txtVisitorName
			// 
			this.txtVisitorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtVisitorName.Location = new System.Drawing.Point(132, 106);
			this.txtVisitorName.Name = "txtVisitorName";
			this.txtVisitorName.Size = new System.Drawing.Size(100, 23);
			this.txtVisitorName.TabIndex = 35;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(5, 154);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 17);
			this.label1.TabIndex = 32;
			this.label1.Text = "Time In";
			// 
			// txtTimeOut
			// 
			this.txtTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTimeOut.Location = new System.Drawing.Point(132, 207);
			this.txtTimeOut.Name = "txtTimeOut";
			this.txtTimeOut.Size = new System.Drawing.Size(100, 23);
			this.txtTimeOut.TabIndex = 31;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(5, 207);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 17);
			this.label5.TabIndex = 30;
			this.label5.Text = "Time Out";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(5, 256);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 17);
			this.label4.TabIndex = 41;
			this.label4.Text = "Date";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(5, 302);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 17);
			this.label6.TabIndex = 39;
			this.label6.Text = "Student Id";
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.Black;
			this.btnSave.Location = new System.Drawing.Point(8, 340);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 36);
			this.btnSave.TabIndex = 38;
			this.btnSave.Text = "Submit";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtDate
			// 
			this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.txtDate.Location = new System.Drawing.Point(132, 252);
			this.txtDate.Name = "txtDate";
			this.txtDate.Size = new System.Drawing.Size(120, 20);
			this.txtDate.TabIndex = 43;
			// 
			// gvVisitor
			// 
			this.gvVisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvVisitor.GridColor = System.Drawing.SystemColors.ControlDarkDark;
			this.gvVisitor.Location = new System.Drawing.Point(326, 76);
			this.gvVisitor.Name = "gvVisitor";
			this.gvVisitor.Size = new System.Drawing.Size(400, 307);
			this.gvVisitor.TabIndex = 44;
			this.gvVisitor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvVisitor_CellContentClick);
			this.gvVisitor.RowDividerDoubleClick += new System.Windows.Forms.DataGridViewRowDividerDoubleClickEventHandler(this.gvVisitor_RowDividerDoubleClick);
			this.gvVisitor.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvVisitor_RowHeaderMouseDoubleClick);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(104, 340);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 36);
			this.button1.TabIndex = 45;
			this.button1.Text = "Update";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(5, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 17);
			this.label2.TabIndex = 34;
			this.label2.Text = "Visitor Name";
			// 
			// txtTimeIn
			// 
			this.txtTimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTimeIn.Location = new System.Drawing.Point(132, 154);
			this.txtTimeIn.Name = "txtTimeIn";
			this.txtTimeIn.Size = new System.Drawing.Size(100, 23);
			this.txtTimeIn.TabIndex = 46;
			// 
			// txtVisitorId
			// 
			this.txtVisitorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtVisitorId.Location = new System.Drawing.Point(275, 76);
			this.txtVisitorId.Name = "txtVisitorId";
			this.txtVisitorId.Size = new System.Drawing.Size(14, 23);
			this.txtVisitorId.TabIndex = 37;
			this.txtVisitorId.Visible = false;
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.Color.Black;
			this.btnExit.Location = new System.Drawing.Point(204, 340);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(85, 36);
			this.btnExit.TabIndex = 47;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// cmbStudentId
			// 
			this.cmbStudentId.FormattingEnabled = true;
			this.cmbStudentId.Location = new System.Drawing.Point(132, 302);
			this.cmbStudentId.Name = "cmbStudentId";
			this.cmbStudentId.Size = new System.Drawing.Size(121, 21);
			this.cmbStudentId.TabIndex = 48;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Black;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(191, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(198, 33);
			this.label3.TabIndex = 49;
			this.label3.Text = "Visitor Details";
			// 
			// Visitor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(736, 383);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbStudentId);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.txtTimeIn);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.gvVisitor);
			this.Controls.Add(this.txtDate);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtVisitorId);
			this.Controls.Add(this.txtVisitorName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtTimeOut);
			this.Controls.Add(this.label5);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "Visitor";
			this.Text = "Visitor";
			this.Load += new System.EventHandler(this.Visitor_Load);
			((System.ComponentModel.ISupportInitialize)(this.gvVisitor)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtVisitorName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTimeOut;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.DateTimePicker txtDate;
		private System.Windows.Forms.DataGridView gvVisitor;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTimeIn;
		private System.Windows.Forms.TextBox txtVisitorId;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.ComboBox cmbStudentId;
		private System.Windows.Forms.Label label3;
	}
}