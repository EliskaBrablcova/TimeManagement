namespace Eli.TimeManagement.App
{
	partial class NoteDialog
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
			this.dateDtp = new System.Windows.Forms.DateTimePicker();
			this.dateLbl = new System.Windows.Forms.Label();
			this.textTB = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.textLbl = new System.Windows.Forms.Label();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.okBtn = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dateDtp
			// 
			this.dateDtp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateDtp.Location = new System.Drawing.Point(107, 3);
			this.dateDtp.Name = "dateDtp";
			this.dateDtp.Size = new System.Drawing.Size(388, 20);
			this.dateDtp.TabIndex = 0;
			// 
			// dateLbl
			// 
			this.dateLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateLbl.Location = new System.Drawing.Point(3, 0);
			this.dateLbl.Name = "dateLbl";
			this.dateLbl.Size = new System.Drawing.Size(98, 30);
			this.dateLbl.TabIndex = 5;
			this.dateLbl.Text = "Datum";
			this.dateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textTB
			// 
			this.textTB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textTB.Location = new System.Drawing.Point(107, 33);
			this.textTB.Multiline = true;
			this.textTB.Name = "textTB";
			this.textTB.Size = new System.Drawing.Size(388, 253);
			this.textTB.TabIndex = 8;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.textLbl, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.textTB, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.dateLbl, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.dateDtp, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 289);
			this.tableLayoutPanel1.TabIndex = 9;
			// 
			// textLbl
			// 
			this.textLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textLbl.Location = new System.Drawing.Point(3, 30);
			this.textLbl.Name = "textLbl";
			this.textLbl.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.textLbl.Size = new System.Drawing.Size(98, 259);
			this.textLbl.TabIndex = 10;
			this.textLbl.Text = "Poznámka";
			// 
			// cancelBtn
			// 
			this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelBtn.Location = new System.Drawing.Point(354, 321);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(75, 23);
			this.cancelBtn.TabIndex = 11;
			this.cancelBtn.Text = "Zrušit";
			this.cancelBtn.UseVisualStyleBackColor = true;
			// 
			// okBtn
			// 
			this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okBtn.Location = new System.Drawing.Point(435, 321);
			this.okBtn.Name = "okBtn";
			this.okBtn.Size = new System.Drawing.Size(75, 23);
			this.okBtn.TabIndex = 12;
			this.okBtn.Text = "Uložit";
			this.okBtn.UseVisualStyleBackColor = true;
			this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
			// 
			// NoteDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelBtn;
			this.ClientSize = new System.Drawing.Size(522, 374);
			this.ControlBox = false;
			this.Controls.Add(this.okBtn);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MinimumSize = new System.Drawing.Size(378, 182);
			this.Name = "NoteDialog";
			this.Text = "NoteDialog";
			this.Load += new System.EventHandler(this.NoteDialog_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateDtp;
		private System.Windows.Forms.Label dateLbl;
		private System.Windows.Forms.TextBox textTB;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label textLbl;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.Button okBtn;
	}
}