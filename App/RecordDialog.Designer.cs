namespace Eli.TimeManagement.App
{
	partial class RecordDialog
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
			this.startDtp = new System.Windows.Forms.DateTimePicker();
			this.typeCB = new System.Windows.Forms.ComboBox();
			this.minutesNud = new System.Windows.Forms.NumericUpDown();
			this.descriptionTB = new System.Windows.Forms.TextBox();
			this.typeLbl = new System.Windows.Forms.Label();
			this.startLbl = new System.Windows.Forms.Label();
			this.minutesLbl = new System.Windows.Forms.Label();
			this.descriptionLbl = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.okBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.minutesNud)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// startDtp
			// 
			this.startDtp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.startDtp.Location = new System.Drawing.Point(107, 3);
			this.startDtp.Name = "startDtp";
			this.startDtp.Size = new System.Drawing.Size(388, 20);
			this.startDtp.TabIndex = 0;
			// 
			// typeCB
			// 
			this.typeCB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.typeCB.FormattingEnabled = true;
			this.typeCB.Location = new System.Drawing.Point(107, 63);
			this.typeCB.Name = "typeCB";
			this.typeCB.Size = new System.Drawing.Size(388, 21);
			this.typeCB.TabIndex = 2;
			// 
			// minutesNud
			// 
			this.minutesNud.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minutesNud.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.minutesNud.Location = new System.Drawing.Point(107, 33);
			this.minutesNud.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.minutesNud.Name = "minutesNud";
			this.minutesNud.Size = new System.Drawing.Size(388, 20);
			this.minutesNud.TabIndex = 1;
			// 
			// descriptionTB
			// 
			this.descriptionTB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.descriptionTB.Location = new System.Drawing.Point(107, 93);
			this.descriptionTB.Name = "descriptionTB";
			this.descriptionTB.Size = new System.Drawing.Size(388, 20);
			this.descriptionTB.TabIndex = 3;
			// 
			// typeLbl
			// 
			this.typeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.typeLbl.Location = new System.Drawing.Point(3, 60);
			this.typeLbl.Name = "typeLbl";
			this.typeLbl.Size = new System.Drawing.Size(98, 30);
			this.typeLbl.TabIndex = 4;
			this.typeLbl.Text = "Typ aktivity";
			this.typeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// startLbl
			// 
			this.startLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.startLbl.Location = new System.Drawing.Point(3, 0);
			this.startLbl.Name = "startLbl";
			this.startLbl.Size = new System.Drawing.Size(98, 30);
			this.startLbl.TabIndex = 5;
			this.startLbl.Text = "Datum";
			this.startLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// minutesLbl
			// 
			this.minutesLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minutesLbl.Location = new System.Drawing.Point(3, 30);
			this.minutesLbl.Name = "minutesLbl";
			this.minutesLbl.Size = new System.Drawing.Size(98, 30);
			this.minutesLbl.TabIndex = 6;
			this.minutesLbl.Text = "Délka (min)";
			this.minutesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// descriptionLbl
			// 
			this.descriptionLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.descriptionLbl.Location = new System.Drawing.Point(3, 90);
			this.descriptionLbl.Name = "descriptionLbl";
			this.descriptionLbl.Size = new System.Drawing.Size(98, 33);
			this.descriptionLbl.TabIndex = 7;
			this.descriptionLbl.Text = "Popis aktivity";
			this.descriptionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.typeLbl, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.minutesNud, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.startLbl, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.startDtp, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.minutesLbl, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.descriptionLbl, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.descriptionTB, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.typeCB, 1, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 123);
			this.tableLayoutPanel1.TabIndex = 8;
			// 
			// okBtn
			// 
			this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okBtn.Location = new System.Drawing.Point(436, 162);
			this.okBtn.Name = "okBtn";
			this.okBtn.Size = new System.Drawing.Size(75, 23);
			this.okBtn.TabIndex = 9;
			this.okBtn.Text = "Uložit";
			this.okBtn.UseVisualStyleBackColor = true;
			this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelBtn.Location = new System.Drawing.Point(355, 162);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(75, 23);
			this.cancelBtn.TabIndex = 10;
			this.cancelBtn.Text = "Zrušit";
			this.cancelBtn.UseVisualStyleBackColor = true;
			// 
			// RecordDialog
			// 
			this.AcceptButton = this.okBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelBtn;
			this.ClientSize = new System.Drawing.Size(524, 220);
			this.ControlBox = false;
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.okBtn);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MinimumSize = new System.Drawing.Size(401, 236);
			this.Name = "RecordDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "RecordDialog";
			this.Load += new System.EventHandler(this.RecordDialog_Load);
			((System.ComponentModel.ISupportInitialize)(this.minutesNud)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DateTimePicker startDtp;
		private System.Windows.Forms.ComboBox typeCB;
		private System.Windows.Forms.NumericUpDown minutesNud;
		private System.Windows.Forms.TextBox descriptionTB;
		private System.Windows.Forms.Label typeLbl;
		private System.Windows.Forms.Label startLbl;
		private System.Windows.Forms.Label minutesLbl;
		private System.Windows.Forms.Label descriptionLbl;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button okBtn;
		private System.Windows.Forms.Button cancelBtn;
	}
}