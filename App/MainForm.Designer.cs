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
			this.recordsLv = new System.Windows.Forms.ListView();
			this.recordDateCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.recordMinutesCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.recordTypeCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.recordDescriptionCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.logoPb = new System.Windows.Forms.PictureBox();
			this.createRecordBtn = new System.Windows.Forms.Button();
			this.editRecordBtn = new System.Windows.Forms.Button();
			this.deleteRecordBtn = new System.Windows.Forms.Button();
			this.versionLbl = new System.Windows.Forms.Label();
			this.mainTc = new System.Windows.Forms.TabControl();
			this.recordsTP = new System.Windows.Forms.TabPage();
			this.recordsTlp = new System.Windows.Forms.TableLayoutPanel();
			this.notesTP = new System.Windows.Forms.TabPage();
			this.notesTlp = new System.Windows.Forms.TableLayoutPanel();
			this.createNoteBtn = new System.Windows.Forms.Button();
			this.notesLv = new System.Windows.Forms.ListView();
			this.noteDateCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.noteTextCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.editNoteBtn = new System.Windows.Forms.Button();
			this.deleteNoteBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.logoPb)).BeginInit();
			this.mainTc.SuspendLayout();
			this.recordsTP.SuspendLayout();
			this.recordsTlp.SuspendLayout();
			this.notesTP.SuspendLayout();
			this.notesTlp.SuspendLayout();
			this.SuspendLayout();
			// 
			// recordsLv
			// 
			this.recordsLv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.recordsLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.recordDateCh,
            this.recordMinutesCh,
            this.recordTypeCh,
            this.recordDescriptionCh});
			this.recordsLv.FullRowSelect = true;
			this.recordsLv.HideSelection = false;
			this.recordsLv.Location = new System.Drawing.Point(198, 3);
			this.recordsLv.MultiSelect = false;
			this.recordsLv.Name = "recordsLv";
			this.recordsTlp.SetRowSpan(this.recordsLv, 4);
			this.recordsLv.Size = new System.Drawing.Size(519, 288);
			this.recordsLv.TabIndex = 0;
			this.recordsLv.UseCompatibleStateImageBehavior = false;
			this.recordsLv.View = System.Windows.Forms.View.Details;
			this.recordsLv.SelectedIndexChanged += new System.EventHandler(this.recordsLv_SelectedIndexChanged);
			this.recordsLv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.recordLv_KeyDown);
			// 
			// recordDateCh
			// 
			this.recordDateCh.Text = "Datum";
			this.recordDateCh.Width = 100;
			// 
			// recordMinutesCh
			// 
			this.recordMinutesCh.Text = "Délka (min)";
			this.recordMinutesCh.Width = 90;
			// 
			// recordTypeCh
			// 
			this.recordTypeCh.Text = "Typ aktivity";
			this.recordTypeCh.Width = 97;
			// 
			// recordDescriptionCh
			// 
			this.recordDescriptionCh.Text = "Popis aktivity";
			this.recordDescriptionCh.Width = 171;
			// 
			// logoPb
			// 
			this.logoPb.Image = ((System.Drawing.Image)(resources.GetObject("logoPb.Image")));
			this.logoPb.Location = new System.Drawing.Point(13, 12);
			this.logoPb.Name = "logoPb";
			this.logoPb.Size = new System.Drawing.Size(199, 112);
			this.logoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logoPb.TabIndex = 1;
			this.logoPb.TabStop = false;
			// 
			// createRecordBtn
			// 
			this.createRecordBtn.Location = new System.Drawing.Point(3, 3);
			this.createRecordBtn.Name = "createRecordBtn";
			this.createRecordBtn.Size = new System.Drawing.Size(189, 23);
			this.createRecordBtn.TabIndex = 2;
			this.createRecordBtn.Text = "Nový záznam";
			this.createRecordBtn.UseVisualStyleBackColor = true;
			this.createRecordBtn.Click += new System.EventHandler(this.createRecordBtn_Click);
			// 
			// editRecordBtn
			// 
			this.editRecordBtn.Enabled = false;
			this.editRecordBtn.Location = new System.Drawing.Point(3, 33);
			this.editRecordBtn.Name = "editRecordBtn";
			this.editRecordBtn.Size = new System.Drawing.Size(189, 23);
			this.editRecordBtn.TabIndex = 3;
			this.editRecordBtn.Text = "Editace";
			this.editRecordBtn.UseVisualStyleBackColor = true;
			this.editRecordBtn.Click += new System.EventHandler(this.editRecordBtn_Click);
			// 
			// deleteRecordBtn
			// 
			this.deleteRecordBtn.Enabled = false;
			this.deleteRecordBtn.Location = new System.Drawing.Point(3, 63);
			this.deleteRecordBtn.Name = "deleteRecordBtn";
			this.deleteRecordBtn.Size = new System.Drawing.Size(189, 23);
			this.deleteRecordBtn.TabIndex = 4;
			this.deleteRecordBtn.Text = "Smazání";
			this.deleteRecordBtn.UseVisualStyleBackColor = true;
			this.deleteRecordBtn.Click += new System.EventHandler(this.deleteRecordBtn_Click);
			// 
			// versionLbl
			// 
			this.versionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.versionLbl.AutoSize = true;
			this.versionLbl.Location = new System.Drawing.Point(719, 459);
			this.versionLbl.Name = "versionLbl";
			this.versionLbl.Size = new System.Drawing.Size(28, 13);
			this.versionLbl.TabIndex = 5;
			this.versionLbl.Text = "v1.0";
			// 
			// mainTc
			// 
			this.mainTc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mainTc.Controls.Add(this.recordsTP);
			this.mainTc.Controls.Add(this.notesTP);
			this.mainTc.Location = new System.Drawing.Point(13, 130);
			this.mainTc.Multiline = true;
			this.mainTc.Name = "mainTc";
			this.mainTc.SelectedIndex = 0;
			this.mainTc.Size = new System.Drawing.Size(734, 326);
			this.mainTc.TabIndex = 6;
			// 
			// recordsTP
			// 
			this.recordsTP.Controls.Add(this.recordsTlp);
			this.recordsTP.Location = new System.Drawing.Point(4, 22);
			this.recordsTP.Name = "recordsTP";
			this.recordsTP.Padding = new System.Windows.Forms.Padding(3);
			this.recordsTP.Size = new System.Drawing.Size(726, 300);
			this.recordsTP.TabIndex = 0;
			this.recordsTP.Text = "Časová evidence";
			this.recordsTP.UseVisualStyleBackColor = true;
			// 
			// recordsTlp
			// 
			this.recordsTlp.ColumnCount = 2;
			this.recordsTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
			this.recordsTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.recordsTlp.Controls.Add(this.createRecordBtn, 0, 0);
			this.recordsTlp.Controls.Add(this.recordsLv, 1, 0);
			this.recordsTlp.Controls.Add(this.editRecordBtn, 0, 1);
			this.recordsTlp.Controls.Add(this.deleteRecordBtn, 0, 2);
			this.recordsTlp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.recordsTlp.Location = new System.Drawing.Point(3, 3);
			this.recordsTlp.Name = "recordsTlp";
			this.recordsTlp.RowCount = 4;
			this.recordsTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.recordsTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.recordsTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.recordsTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.recordsTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.recordsTlp.Size = new System.Drawing.Size(720, 294);
			this.recordsTlp.TabIndex = 0;
			// 
			// notesTP
			// 
			this.notesTP.Controls.Add(this.notesTlp);
			this.notesTP.Location = new System.Drawing.Point(4, 22);
			this.notesTP.Name = "notesTP";
			this.notesTP.Padding = new System.Windows.Forms.Padding(3);
			this.notesTP.Size = new System.Drawing.Size(726, 300);
			this.notesTP.TabIndex = 1;
			this.notesTP.Text = "Poznámky";
			this.notesTP.UseVisualStyleBackColor = true;
			// 
			// notesTlp
			// 
			this.notesTlp.ColumnCount = 2;
			this.notesTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
			this.notesTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.notesTlp.Controls.Add(this.createNoteBtn, 0, 0);
			this.notesTlp.Controls.Add(this.notesLv, 1, 0);
			this.notesTlp.Controls.Add(this.editNoteBtn, 0, 1);
			this.notesTlp.Controls.Add(this.deleteNoteBtn, 0, 2);
			this.notesTlp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.notesTlp.Location = new System.Drawing.Point(3, 3);
			this.notesTlp.Name = "notesTlp";
			this.notesTlp.RowCount = 4;
			this.notesTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.notesTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.notesTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.notesTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.notesTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.notesTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.notesTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.notesTlp.Size = new System.Drawing.Size(720, 294);
			this.notesTlp.TabIndex = 1;
			// 
			// createNoteBtn
			// 
			this.createNoteBtn.Location = new System.Drawing.Point(3, 3);
			this.createNoteBtn.Name = "createNoteBtn";
			this.createNoteBtn.Size = new System.Drawing.Size(189, 23);
			this.createNoteBtn.TabIndex = 2;
			this.createNoteBtn.Text = "Nový záznam";
			this.createNoteBtn.UseVisualStyleBackColor = true;
			this.createNoteBtn.Click += new System.EventHandler(this.createNoteBtn_Click);
			// 
			// notesLv
			// 
			this.notesLv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.notesLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.noteDateCh,
            this.noteTextCh});
			this.notesLv.FullRowSelect = true;
			this.notesLv.HideSelection = false;
			this.notesLv.Location = new System.Drawing.Point(198, 3);
			this.notesLv.MultiSelect = false;
			this.notesLv.Name = "notesLv";
			this.notesTlp.SetRowSpan(this.notesLv, 4);
			this.notesLv.Size = new System.Drawing.Size(519, 288);
			this.notesLv.TabIndex = 0;
			this.notesLv.UseCompatibleStateImageBehavior = false;
			this.notesLv.View = System.Windows.Forms.View.Details;
			this.notesLv.SelectedIndexChanged += new System.EventHandler(this.notesLv_SelectedIndexChanged);
			this.notesLv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.notesLv_KeyDown);
			// 
			// noteDateCh
			// 
			this.noteDateCh.Text = "Datum";
			this.noteDateCh.Width = 110;
			// 
			// noteTextCh
			// 
			this.noteTextCh.Text = "Poznámka";
			this.noteTextCh.Width = 411;
			// 
			// editNoteBtn
			// 
			this.editNoteBtn.Enabled = false;
			this.editNoteBtn.Location = new System.Drawing.Point(3, 33);
			this.editNoteBtn.Name = "editNoteBtn";
			this.editNoteBtn.Size = new System.Drawing.Size(189, 23);
			this.editNoteBtn.TabIndex = 3;
			this.editNoteBtn.Text = "Editace";
			this.editNoteBtn.UseVisualStyleBackColor = true;
			this.editNoteBtn.Click += new System.EventHandler(this.editNoteBtn_Click);
			// 
			// deleteNoteBtn
			// 
			this.deleteNoteBtn.Enabled = false;
			this.deleteNoteBtn.Location = new System.Drawing.Point(3, 63);
			this.deleteNoteBtn.Name = "deleteNoteBtn";
			this.deleteNoteBtn.Size = new System.Drawing.Size(189, 23);
			this.deleteNoteBtn.TabIndex = 4;
			this.deleteNoteBtn.Text = "Smazání";
			this.deleteNoteBtn.UseVisualStyleBackColor = true;
			this.deleteNoteBtn.Click += new System.EventHandler(this.deleteNoteBtn_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(759, 480);
			this.Controls.Add(this.logoPb);
			this.Controls.Add(this.mainTc);
			this.Controls.Add(this.versionLbl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(719, 314);
			this.Name = "MainForm";
			this.Text = "Notýsek";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.logoPb)).EndInit();
			this.mainTc.ResumeLayout(false);
			this.recordsTP.ResumeLayout(false);
			this.recordsTlp.ResumeLayout(false);
			this.notesTP.ResumeLayout(false);
			this.notesTlp.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView recordsLv;
		private System.Windows.Forms.PictureBox logoPb;
		private System.Windows.Forms.Button createRecordBtn;
		private System.Windows.Forms.Button editRecordBtn;
		private System.Windows.Forms.Button deleteRecordBtn;
		private System.Windows.Forms.ColumnHeader recordDateCh;
		private System.Windows.Forms.ColumnHeader recordMinutesCh;
		private System.Windows.Forms.ColumnHeader recordTypeCh;
		private System.Windows.Forms.ColumnHeader recordDescriptionCh;
		private System.Windows.Forms.Label versionLbl;
		private System.Windows.Forms.TableLayoutPanel recordsTlp;
		private System.Windows.Forms.TabControl mainTc;
		private System.Windows.Forms.TabPage recordsTP;
		private System.Windows.Forms.TabPage notesTP;
		private System.Windows.Forms.TableLayoutPanel notesTlp;
		private System.Windows.Forms.Button createNoteBtn;
		private System.Windows.Forms.ListView notesLv;
		private System.Windows.Forms.ColumnHeader noteDateCh;
		private System.Windows.Forms.ColumnHeader noteTextCh;
		private System.Windows.Forms.Button editNoteBtn;
		private System.Windows.Forms.Button deleteNoteBtn;
	}
}

