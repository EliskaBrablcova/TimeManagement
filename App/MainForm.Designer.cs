namespace Eli.TimeManagement.App
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.dataLv = new System.Windows.Forms.ListView();
			this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chMinutes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.logoPb = new System.Windows.Forms.PictureBox();
			this.createBtn = new System.Windows.Forms.Button();
			this.editBtn = new System.Windows.Forms.Button();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.versionLbl = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.logoPb)).BeginInit();
			this.SuspendLayout();
			// 
			// dataLv
			// 
			this.dataLv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDate,
            this.chMinutes,
            this.chType,
            this.chDescription});
			this.dataLv.FullRowSelect = true;
			this.dataLv.HideSelection = false;
			this.dataLv.Location = new System.Drawing.Point(214, 12);
			this.dataLv.MultiSelect = false;
			this.dataLv.Name = "dataLv";
			this.dataLv.Size = new System.Drawing.Size(535, 349);
			this.dataLv.TabIndex = 0;
			this.dataLv.UseCompatibleStateImageBehavior = false;
			this.dataLv.View = System.Windows.Forms.View.Details;
			this.dataLv.SelectedIndexChanged += new System.EventHandler(this.dataLv_SelectedIndexChanged);
			this.dataLv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataLv_KeyDown);
			// 
			// chDate
			// 
			this.chDate.Text = "Datum";
			this.chDate.Width = 100;
			// 
			// chMinutes
			// 
			this.chMinutes.Text = "Délka (min)";
			this.chMinutes.Width = 90;
			// 
			// chType
			// 
			this.chType.Text = "Typ aktivity";
			this.chType.Width = 97;
			// 
			// chDescription
			// 
			this.chDescription.Text = "Popis aktivity";
			this.chDescription.Width = 240;
			// 
			// logoPb
			// 
			this.logoPb.Image = ((System.Drawing.Image)(resources.GetObject("logoPb.Image")));
			this.logoPb.Location = new System.Drawing.Point(13, 12);
			this.logoPb.Name = "logoPb";
			this.logoPb.Size = new System.Drawing.Size(195, 108);
			this.logoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logoPb.TabIndex = 1;
			this.logoPb.TabStop = false;
			// 
			// createBtn
			// 
			this.createBtn.Location = new System.Drawing.Point(12, 126);
			this.createBtn.Name = "createBtn";
			this.createBtn.Size = new System.Drawing.Size(196, 23);
			this.createBtn.TabIndex = 2;
			this.createBtn.Text = "Nový záznam";
			this.createBtn.UseVisualStyleBackColor = true;
			this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
			// 
			// editBtn
			// 
			this.editBtn.Enabled = false;
			this.editBtn.Location = new System.Drawing.Point(12, 155);
			this.editBtn.Name = "editBtn";
			this.editBtn.Size = new System.Drawing.Size(196, 23);
			this.editBtn.TabIndex = 3;
			this.editBtn.Text = "Editace";
			this.editBtn.UseVisualStyleBackColor = true;
			this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
			// 
			// deleteBtn
			// 
			this.deleteBtn.Enabled = false;
			this.deleteBtn.Location = new System.Drawing.Point(12, 184);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(196, 23);
			this.deleteBtn.TabIndex = 4;
			this.deleteBtn.Text = "Smazání";
			this.deleteBtn.UseVisualStyleBackColor = true;
			this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// versionLbl
			// 
			this.versionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.versionLbl.AutoSize = true;
			this.versionLbl.Location = new System.Drawing.Point(710, 365);
			this.versionLbl.Name = "versionLbl";
			this.versionLbl.Size = new System.Drawing.Size(28, 13);
			this.versionLbl.TabIndex = 5;
			this.versionLbl.Text = "v1.0";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(761, 387);
			this.Controls.Add(this.versionLbl);
			this.Controls.Add(this.deleteBtn);
			this.Controls.Add(this.editBtn);
			this.Controls.Add(this.createBtn);
			this.Controls.Add(this.logoPb);
			this.Controls.Add(this.dataLv);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(677, 271);
			this.Name = "MainForm";
			this.Text = "Notýsek";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.logoPb)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView dataLv;
		private System.Windows.Forms.PictureBox logoPb;
		private System.Windows.Forms.Button createBtn;
		private System.Windows.Forms.Button editBtn;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.ColumnHeader chDate;
		private System.Windows.Forms.ColumnHeader chMinutes;
		private System.Windows.Forms.ColumnHeader chType;
		private System.Windows.Forms.ColumnHeader chDescription;
		private System.Windows.Forms.Label versionLbl;
	}
}

