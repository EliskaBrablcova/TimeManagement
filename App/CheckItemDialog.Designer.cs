namespace Eli.TimeManagement.App
{
	partial class CheckItemDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckItemDialog));
			this.cancelBtn = new System.Windows.Forms.Button();
			this.okBtn = new System.Windows.Forms.Button();
			this.checkItemDialogTlp = new System.Windows.Forms.TableLayoutPanel();
			this.checkItemTextTB = new System.Windows.Forms.TextBox();
			this.checkItemTextLbl = new System.Windows.Forms.Label();
			this.checkItemCompletedLbl = new System.Windows.Forms.Label();
			this.checkItemCompletedCB = new System.Windows.Forms.CheckBox();
			this.checkItemTypeLbl = new System.Windows.Forms.Label();
			this.checkItemTypeCB = new System.Windows.Forms.ComboBox();
			this.checkItemDialogTlp.SuspendLayout();
			this.SuspendLayout();
			// 
			// cancelBtn
			// 
			this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelBtn.Location = new System.Drawing.Point(180, 157);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(75, 23);
			this.cancelBtn.TabIndex = 12;
			this.cancelBtn.Text = "Zrušit";
			this.cancelBtn.UseVisualStyleBackColor = true;
			// 
			// okBtn
			// 
			this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okBtn.Location = new System.Drawing.Point(261, 157);
			this.okBtn.Name = "okBtn";
			this.okBtn.Size = new System.Drawing.Size(75, 23);
			this.okBtn.TabIndex = 13;
			this.okBtn.Text = "Uložit";
			this.okBtn.UseVisualStyleBackColor = true;
			this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
			// 
			// checkItemDialogTlp
			// 
			this.checkItemDialogTlp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.checkItemDialogTlp.ColumnCount = 2;
			this.checkItemDialogTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
			this.checkItemDialogTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.checkItemDialogTlp.Controls.Add(this.checkItemTextTB, 1, 2);
			this.checkItemDialogTlp.Controls.Add(this.checkItemTextLbl, 0, 2);
			this.checkItemDialogTlp.Controls.Add(this.checkItemCompletedLbl, 0, 0);
			this.checkItemDialogTlp.Controls.Add(this.checkItemCompletedCB, 1, 0);
			this.checkItemDialogTlp.Controls.Add(this.checkItemTypeLbl, 0, 1);
			this.checkItemDialogTlp.Controls.Add(this.checkItemTypeCB, 1, 1);
			this.checkItemDialogTlp.Location = new System.Drawing.Point(12, 12);
			this.checkItemDialogTlp.Name = "checkItemDialogTlp";
			this.checkItemDialogTlp.RowCount = 3;
			this.checkItemDialogTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.checkItemDialogTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.checkItemDialogTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.checkItemDialogTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.checkItemDialogTlp.Size = new System.Drawing.Size(324, 139);
			this.checkItemDialogTlp.TabIndex = 14;
			// 
			// checkItemTextTB
			// 
			this.checkItemTextTB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkItemTextTB.Location = new System.Drawing.Point(107, 53);
			this.checkItemTextTB.Multiline = true;
			this.checkItemTextTB.Name = "checkItemTextTB";
			this.checkItemTextTB.Size = new System.Drawing.Size(214, 83);
			this.checkItemTextTB.TabIndex = 12;
			// 
			// checkItemTextLbl
			// 
			this.checkItemTextLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkItemTextLbl.Location = new System.Drawing.Point(3, 50);
			this.checkItemTextLbl.Name = "checkItemTextLbl";
			this.checkItemTextLbl.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.checkItemTextLbl.Size = new System.Drawing.Size(98, 89);
			this.checkItemTextLbl.TabIndex = 10;
			this.checkItemTextLbl.Text = "Text";
			// 
			// checkItemCompletedLbl
			// 
			this.checkItemCompletedLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkItemCompletedLbl.Location = new System.Drawing.Point(3, 0);
			this.checkItemCompletedLbl.Name = "checkItemCompletedLbl";
			this.checkItemCompletedLbl.Size = new System.Drawing.Size(98, 25);
			this.checkItemCompletedLbl.TabIndex = 5;
			this.checkItemCompletedLbl.Text = "Dokončeno";
			this.checkItemCompletedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkItemCompletedCB
			// 
			this.checkItemCompletedCB.AutoSize = true;
			this.checkItemCompletedCB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkItemCompletedCB.Location = new System.Drawing.Point(107, 3);
			this.checkItemCompletedCB.Name = "checkItemCompletedCB";
			this.checkItemCompletedCB.Size = new System.Drawing.Size(214, 19);
			this.checkItemCompletedCB.TabIndex = 11;
			this.checkItemCompletedCB.UseVisualStyleBackColor = true;
			// 
			// checkItemTypeLbl
			// 
			this.checkItemTypeLbl.AutoSize = true;
			this.checkItemTypeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkItemTypeLbl.Location = new System.Drawing.Point(3, 25);
			this.checkItemTypeLbl.Name = "checkItemTypeLbl";
			this.checkItemTypeLbl.Size = new System.Drawing.Size(98, 25);
			this.checkItemTypeLbl.TabIndex = 13;
			this.checkItemTypeLbl.Text = "Typ úkolu";
			this.checkItemTypeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkItemTypeCB
			// 
			this.checkItemTypeCB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkItemTypeCB.FormattingEnabled = true;
			this.checkItemTypeCB.Location = new System.Drawing.Point(107, 28);
			this.checkItemTypeCB.Name = "checkItemTypeCB";
			this.checkItemTypeCB.Size = new System.Drawing.Size(214, 21);
			this.checkItemTypeCB.TabIndex = 14;
			// 
			// CheckItemDialog
			// 
			this.AcceptButton = this.okBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelBtn;
			this.ClientSize = new System.Drawing.Size(348, 215);
			this.ControlBox = false;
			this.Controls.Add(this.checkItemDialogTlp);
			this.Controls.Add(this.okBtn);
			this.Controls.Add(this.cancelBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(364, 231);
			this.Name = "CheckItemDialog";
			this.Text = "CheckItemDialog";
			this.Load += new System.EventHandler(this.CheckItemDialog_Load);
			this.checkItemDialogTlp.ResumeLayout(false);
			this.checkItemDialogTlp.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.Button okBtn;
		private System.Windows.Forms.TableLayoutPanel checkItemDialogTlp;
		private System.Windows.Forms.Label checkItemTextLbl;
		private System.Windows.Forms.Label checkItemCompletedLbl;
		private System.Windows.Forms.CheckBox checkItemCompletedCB;
		private System.Windows.Forms.TextBox checkItemTextTB;
		private System.Windows.Forms.Label checkItemTypeLbl;
		private System.Windows.Forms.ComboBox checkItemTypeCB;
	}
}