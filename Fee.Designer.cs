namespace LoginForm.cs
{
	partial class Fee
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtStudentId = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.gvFee = new System.Windows.Forms.DataGridView();
			this.cmbFeeMonth = new System.Windows.Forms.ComboBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.cmbFeeStatus = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gvFee)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(8, 111);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Fee Month";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(8, 166);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Fee Status";
			// 
			// txtStudentId
			// 
			this.txtStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStudentId.Location = new System.Drawing.Point(110, 211);
			this.txtStudentId.Name = "txtStudentId";
			this.txtStudentId.Size = new System.Drawing.Size(100, 23);
			this.txtStudentId.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(8, 211);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Student Id";
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(11, 254);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 36);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Submit";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// gvFee
			// 
			this.gvFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvFee.Location = new System.Drawing.Point(237, 107);
			this.gvFee.Name = "gvFee";
			this.gvFee.Size = new System.Drawing.Size(317, 183);
			this.gvFee.TabIndex = 8;
			// 
			// cmbFeeMonth
			// 
			this.cmbFeeMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbFeeMonth.FormattingEnabled = true;
			this.cmbFeeMonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
			this.cmbFeeMonth.Location = new System.Drawing.Point(110, 107);
			this.cmbFeeMonth.Name = "cmbFeeMonth";
			this.cmbFeeMonth.Size = new System.Drawing.Size(121, 21);
			this.cmbFeeMonth.TabIndex = 9;
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.Location = new System.Drawing.Point(110, 254);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 36);
			this.btnReset.TabIndex = 10;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// cmbFeeStatus
			// 
			this.cmbFeeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbFeeStatus.FormattingEnabled = true;
			this.cmbFeeStatus.Items.AddRange(new object[] {
            "Paid",
            "Unpaid"});
			this.cmbFeeStatus.Location = new System.Drawing.Point(110, 162);
			this.cmbFeeStatus.Name = "cmbFeeStatus";
			this.cmbFeeStatus.Size = new System.Drawing.Size(121, 21);
			this.cmbFeeStatus.TabIndex = 11;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.DarkGreen;
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(11, 21);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(543, 64);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Black;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(153, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(183, 33);
			this.label4.TabIndex = 1;
			this.label4.Text = "Fee Records";
			// 
			// Fee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(566, 302);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cmbFeeStatus);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.cmbFeeMonth);
			this.Controls.Add(this.gvFee);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtStudentId);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Fee";
			this.Text = "Fee";
			this.Load += new System.EventHandler(this.Fee_Load);
			((System.ComponentModel.ISupportInitialize)(this.gvFee)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtStudentId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.DataGridView gvFee;
		private System.Windows.Forms.ComboBox cmbFeeMonth;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.ComboBox cmbFeeStatus;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
	}
}