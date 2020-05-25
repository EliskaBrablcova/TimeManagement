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
			this.statisticsBtn = new System.Windows.Forms.Button();
			this.notesTP = new System.Windows.Forms.TabPage();
			this.notesTlp = new System.Windows.Forms.TableLayoutPanel();
			this.createNoteBtn = new System.Windows.Forms.Button();
			this.notesLv = new System.Windows.Forms.ListView();
			this.noteDateCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.noteTextCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.editNoteBtn = new System.Windows.Forms.Button();
			this.deleteNoteBtn = new System.Windows.Forms.Button();
			this.dateToDtp = new System.Windows.Forms.DateTimePicker();
			this.dateFromDtp = new System.Windows.Forms.DateTimePicker();
			this.filtrationBtn = new System.Windows.Forms.Button();
			this.typeCb = new System.Windows.Forms.ComboBox();
			this.filtrationGB = new System.Windows.Forms.GroupBox();
			this.filtrationTlp = new System.Windows.Forms.TableLayoutPanel();
			this.dateFromLbl = new System.Windows.Forms.Label();
			this.typeLbl = new System.Windows.Forms.Label();
			this.dateToLbl = new System.Windows.Forms.Label();
			this.checklistTP = new System.Windows.Forms.TabPage();
			this.checklistTlp = new System.Windows.Forms.TableLayoutPanel();
			this.createCheckItemBtn = new System.Windows.Forms.Button();
			this.checklistLv = new System.Windows.Forms.ListView();
			this.checkItemCompletedCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.checkItemTextCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.editCheckItemBtn = new System.Windows.Forms.Button();
			this.deleteCheckItemBtn = new System.Windows.Forms.Button();
			this.completeCheckItemBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.logoPb)).BeginInit();
			this.mainTc.SuspendLayout();
			this.recordsTP.SuspendLayout();
			this.recordsTlp.SuspendLayout();
			this.notesTP.SuspendLayout();
			this.notesTlp.SuspendLayout();
			this.filtrationGB.SuspendLayout();
			this.filtrationTlp.SuspendLayout();
			this.checklistTP.SuspendLayout();
			this.checklistTlp.SuspendLayout();
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
			this.recordsTlp.SetRowSpan(this.recordsLv, 5);
			this.recordsLv.Size = new System.Drawing.Size(463, 288);
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
			this.recordDescriptionCh.Width = 169;
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
			this.versionLbl.Location = new System.Drawing.Point(663, 459);
			this.versionLbl.Name = "versionLbl";
			this.versionLbl.Size = new System.Drawing.Size(28, 13);
			this.versionLbl.TabIndex = 5;
			this.versionLbl.Text = "v1.2";
			// 
			// mainTc
			// 
			this.mainTc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mainTc.Controls.Add(this.recordsTP);
			this.mainTc.Controls.Add(this.notesTP);
			this.mainTc.Controls.Add(this.checklistTP);
			this.mainTc.Location = new System.Drawing.Point(13, 130);
			this.mainTc.Multiline = true;
			this.mainTc.Name = "mainTc";
			this.mainTc.SelectedIndex = 0;
			this.mainTc.Size = new System.Drawing.Size(678, 326);
			this.mainTc.TabIndex = 6;
			this.mainTc.SelectedIndexChanged += new System.EventHandler(this.mainTc_SelectedIndexChanged);
			// 
			// recordsTP
			// 
			this.recordsTP.Controls.Add(this.recordsTlp);
			this.recordsTP.Location = new System.Drawing.Point(4, 22);
			this.recordsTP.Name = "recordsTP";
			this.recordsTP.Padding = new System.Windows.Forms.Padding(3);
			this.recordsTP.Size = new System.Drawing.Size(670, 300);
			this.recordsTP.TabIndex = 0;
			this.recordsTP.Text = "Časová evidence";
			this.recordsTP.UseVisualStyleBackColor = true;
			// 
			// recordsTlp
			// 
			this.recordsTlp.ColumnCount = 2;
			this.recordsTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
			this.recordsTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.recordsTlp.Controls.Add(this.statisticsBtn, 0, 3);
			this.recordsTlp.Controls.Add(this.createRecordBtn, 0, 0);
			this.recordsTlp.Controls.Add(this.recordsLv, 1, 0);
			this.recordsTlp.Controls.Add(this.editRecordBtn, 0, 1);
			this.recordsTlp.Controls.Add(this.deleteRecordBtn, 0, 2);
			this.recordsTlp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.recordsTlp.Location = new System.Drawing.Point(3, 3);
			this.recordsTlp.Name = "recordsTlp";
			this.recordsTlp.RowCount = 5;
			this.recordsTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.recordsTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.recordsTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.recordsTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.recordsTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.recordsTlp.Size = new System.Drawing.Size(664, 294);
			this.recordsTlp.TabIndex = 0;
			// 
			// statisticsBtn
			// 
			this.statisticsBtn.Location = new System.Drawing.Point(3, 93);
			this.statisticsBtn.Name = "statisticsBtn";
			this.statisticsBtn.Size = new System.Drawing.Size(189, 23);
			this.statisticsBtn.TabIndex = 5;
			this.statisticsBtn.Text = "Statistiky";
			this.statisticsBtn.UseVisualStyleBackColor = true;
			this.statisticsBtn.Click += new System.EventHandler(this.statisticsBtn_Click);
			// 
			// notesTP
			// 
			this.notesTP.Controls.Add(this.notesTlp);
			this.notesTP.Location = new System.Drawing.Point(4, 22);
			this.notesTP.Name = "notesTP";
			this.notesTP.Padding = new System.Windows.Forms.Padding(3);
			this.notesTP.Size = new System.Drawing.Size(670, 300);
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
			this.notesTlp.Size = new System.Drawing.Size(664, 294);
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
			this.notesLv.Size = new System.Drawing.Size(463, 288);
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
			this.noteTextCh.Width = 346;
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
			// dateToDtp
			// 
			this.dateToDtp.CustomFormat = "dd.MM.yyyy HH:mm:ss";
			this.dateToDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateToDtp.Location = new System.Drawing.Point(83, 29);
			this.dateToDtp.Name = "dateToDtp";
			this.dateToDtp.Size = new System.Drawing.Size(200, 20);
			this.dateToDtp.TabIndex = 8;
			this.dateToDtp.ValueChanged += new System.EventHandler(this.dateToDtp_ValueChanged);
			// 
			// dateFromDtp
			// 
			this.dateFromDtp.CustomFormat = "dd.MM.yyyy HH:mm:ss";
			this.dateFromDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateFromDtp.Location = new System.Drawing.Point(83, 3);
			this.dateFromDtp.Name = "dateFromDtp";
			this.dateFromDtp.Size = new System.Drawing.Size(200, 20);
			this.dateFromDtp.TabIndex = 9;
			this.dateFromDtp.ValueChanged += new System.EventHandler(this.dateFromDtp_ValueChanged);
			// 
			// filtrationBtn
			// 
			this.filtrationBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.filtrationBtn.Location = new System.Drawing.Point(364, 55);
			this.filtrationBtn.Name = "filtrationBtn";
			this.filtrationBtn.Size = new System.Drawing.Size(96, 21);
			this.filtrationBtn.TabIndex = 10;
			this.filtrationBtn.Text = "Filtrování";
			this.filtrationBtn.UseVisualStyleBackColor = true;
			this.filtrationBtn.Click += new System.EventHandler(this.filtrationBtn_Click);
			// 
			// typeCb
			// 
			this.typeCb.FormattingEnabled = true;
			this.typeCb.Location = new System.Drawing.Point(83, 55);
			this.typeCb.Name = "typeCb";
			this.typeCb.Size = new System.Drawing.Size(200, 21);
			this.typeCb.TabIndex = 11;
			this.typeCb.TextChanged += new System.EventHandler(this.typeCb_TextChanged);
			// 
			// filtrationGB
			// 
			this.filtrationGB.Controls.Add(this.filtrationTlp);
			this.filtrationGB.Location = new System.Drawing.Point(218, 26);
			this.filtrationGB.Name = "filtrationGB";
			this.filtrationGB.Size = new System.Drawing.Size(469, 98);
			this.filtrationGB.TabIndex = 12;
			this.filtrationGB.TabStop = false;
			this.filtrationGB.Text = "Filtrování";
			// 
			// filtrationTlp
			// 
			this.filtrationTlp.ColumnCount = 3;
			this.filtrationTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.filtrationTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.filtrationTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
			this.filtrationTlp.Controls.Add(this.dateFromLbl, 0, 0);
			this.filtrationTlp.Controls.Add(this.dateToDtp, 1, 1);
			this.filtrationTlp.Controls.Add(this.typeLbl, 0, 2);
			this.filtrationTlp.Controls.Add(this.filtrationBtn, 2, 2);
			this.filtrationTlp.Controls.Add(this.dateToLbl, 0, 1);
			this.filtrationTlp.Controls.Add(this.dateFromDtp, 1, 0);
			this.filtrationTlp.Controls.Add(this.typeCb, 1, 2);
			this.filtrationTlp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.filtrationTlp.Location = new System.Drawing.Point(3, 16);
			this.filtrationTlp.Name = "filtrationTlp";
			this.filtrationTlp.RowCount = 3;
			this.filtrationTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.filtrationTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.filtrationTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.filtrationTlp.Size = new System.Drawing.Size(463, 79);
			this.filtrationTlp.TabIndex = 15;
			// 
			// dateFromLbl
			// 
			this.dateFromLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateFromLbl.Location = new System.Drawing.Point(3, 0);
			this.dateFromLbl.Name = "dateFromLbl";
			this.dateFromLbl.Size = new System.Drawing.Size(74, 26);
			this.dateFromLbl.TabIndex = 12;
			this.dateFromLbl.Text = "Datum od";
			this.dateFromLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// typeLbl
			// 
			this.typeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.typeLbl.Location = new System.Drawing.Point(3, 52);
			this.typeLbl.Name = "typeLbl";
			this.typeLbl.Size = new System.Drawing.Size(74, 27);
			this.typeLbl.TabIndex = 14;
			this.typeLbl.Text = "Typ aktivity";
			this.typeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dateToLbl
			// 
			this.dateToLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateToLbl.Location = new System.Drawing.Point(3, 26);
			this.dateToLbl.Name = "dateToLbl";
			this.dateToLbl.Size = new System.Drawing.Size(74, 26);
			this.dateToLbl.TabIndex = 13;
			this.dateToLbl.Text = "Datum do";
			this.dateToLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checklistTP
			// 
			this.checklistTP.Controls.Add(this.checklistTlp);
			this.checklistTP.Location = new System.Drawing.Point(4, 22);
			this.checklistTP.Name = "checklistTP";
			this.checklistTP.Size = new System.Drawing.Size(670, 300);
			this.checklistTP.TabIndex = 2;
			this.checklistTP.Text = "Úkoly";
			this.checklistTP.UseVisualStyleBackColor = true;
			// 
			// checklistTlp
			// 
			this.checklistTlp.ColumnCount = 2;
			this.checklistTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
			this.checklistTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.checklistTlp.Controls.Add(this.createCheckItemBtn, 0, 0);
			this.checklistTlp.Controls.Add(this.checklistLv, 1, 0);
			this.checklistTlp.Controls.Add(this.editCheckItemBtn, 0, 1);
			this.checklistTlp.Controls.Add(this.deleteCheckItemBtn, 0, 2);
			this.checklistTlp.Controls.Add(this.completeCheckItemBtn, 0, 3);
			this.checklistTlp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checklistTlp.Location = new System.Drawing.Point(0, 0);
			this.checklistTlp.Name = "checklistTlp";
			this.checklistTlp.RowCount = 5;
			this.checklistTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.checklistTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.checklistTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.checklistTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.checklistTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.checklistTlp.Size = new System.Drawing.Size(670, 300);
			this.checklistTlp.TabIndex = 2;
			// 
			// createCheckItemBtn
			// 
			this.createCheckItemBtn.Location = new System.Drawing.Point(3, 3);
			this.createCheckItemBtn.Name = "createCheckItemBtn";
			this.createCheckItemBtn.Size = new System.Drawing.Size(189, 23);
			this.createCheckItemBtn.TabIndex = 2;
			this.createCheckItemBtn.Text = "Nový záznam";
			this.createCheckItemBtn.UseVisualStyleBackColor = true;
			// 
			// checklistLv
			// 
			this.checklistLv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.checklistLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.checkItemCompletedCh,
            this.checkItemTextCh});
			this.checklistLv.FullRowSelect = true;
			this.checklistLv.HideSelection = false;
			this.checklistLv.Location = new System.Drawing.Point(198, 3);
			this.checklistLv.MultiSelect = false;
			this.checklistLv.Name = "checklistLv";
			this.checklistTlp.SetRowSpan(this.checklistLv, 5);
			this.checklistLv.Size = new System.Drawing.Size(469, 294);
			this.checklistLv.TabIndex = 0;
			this.checklistLv.UseCompatibleStateImageBehavior = false;
			this.checklistLv.View = System.Windows.Forms.View.Details;
			// 
			// checkItemCompletedCh
			// 
			this.checkItemCompletedCh.Text = "Dokončeno";
			this.checkItemCompletedCh.Width = 69;
			// 
			// checkItemTextCh
			// 
			this.checkItemTextCh.Text = "Text";
			this.checkItemTextCh.Width = 393;
			// 
			// editCheckItemBtn
			// 
			this.editCheckItemBtn.Enabled = false;
			this.editCheckItemBtn.Location = new System.Drawing.Point(3, 33);
			this.editCheckItemBtn.Name = "editCheckItemBtn";
			this.editCheckItemBtn.Size = new System.Drawing.Size(189, 23);
			this.editCheckItemBtn.TabIndex = 3;
			this.editCheckItemBtn.Text = "Editace";
			this.editCheckItemBtn.UseVisualStyleBackColor = true;
			// 
			// deleteCheckItemBtn
			// 
			this.deleteCheckItemBtn.Enabled = false;
			this.deleteCheckItemBtn.Location = new System.Drawing.Point(3, 63);
			this.deleteCheckItemBtn.Name = "deleteCheckItemBtn";
			this.deleteCheckItemBtn.Size = new System.Drawing.Size(189, 23);
			this.deleteCheckItemBtn.TabIndex = 4;
			this.deleteCheckItemBtn.Text = "Smazání";
			this.deleteCheckItemBtn.UseVisualStyleBackColor = true;
			// 
			// completeCheckItemBtn
			// 
			this.completeCheckItemBtn.Enabled = false;
			this.completeCheckItemBtn.Location = new System.Drawing.Point(3, 93);
			this.completeCheckItemBtn.Name = "completeCheckItemBtn";
			this.completeCheckItemBtn.Size = new System.Drawing.Size(189, 23);
			this.completeCheckItemBtn.TabIndex = 5;
			this.completeCheckItemBtn.Text = "Dokončení";
			this.completeCheckItemBtn.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(703, 480);
			this.Controls.Add(this.logoPb);
			this.Controls.Add(this.mainTc);
			this.Controls.Add(this.versionLbl);
			this.Controls.Add(this.filtrationGB);
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
			this.filtrationGB.ResumeLayout(false);
			this.filtrationTlp.ResumeLayout(false);
			this.checklistTP.ResumeLayout(false);
			this.checklistTlp.ResumeLayout(false);
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
		private System.Windows.Forms.DateTimePicker dateToDtp;
		private System.Windows.Forms.DateTimePicker dateFromDtp;
		private System.Windows.Forms.Button filtrationBtn;
		private System.Windows.Forms.ComboBox typeCb;
		private System.Windows.Forms.GroupBox filtrationGB;
		private System.Windows.Forms.TableLayoutPanel filtrationTlp;
		private System.Windows.Forms.Label dateFromLbl;
		private System.Windows.Forms.Label typeLbl;
		private System.Windows.Forms.Label dateToLbl;
		private System.Windows.Forms.Button statisticsBtn;
		private System.Windows.Forms.TabPage checklistTP;
		private System.Windows.Forms.TableLayoutPanel checklistTlp;
		private System.Windows.Forms.Button createCheckItemBtn;
		private System.Windows.Forms.ListView checklistLv;
		private System.Windows.Forms.ColumnHeader checkItemCompletedCh;
		private System.Windows.Forms.ColumnHeader checkItemTextCh;
		private System.Windows.Forms.Button editCheckItemBtn;
		private System.Windows.Forms.Button deleteCheckItemBtn;
		private System.Windows.Forms.Button completeCheckItemBtn;
	}
}

