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
			this.components = new System.ComponentModel.Container();
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
			this.checklistTP = new System.Windows.Forms.TabPage();
			this.checklistTlp = new System.Windows.Forms.TableLayoutPanel();
			this.createCheckItemBtn = new System.Windows.Forms.Button();
			this.checklistLv = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.checkedImageList = new System.Windows.Forms.ImageList(this.components);
			this.editCheckItemBtn = new System.Windows.Forms.Button();
			this.deleteCheckItemBtn = new System.Windows.Forms.Button();
			this.completeCheckItemBtn = new System.Windows.Forms.Button();
			this.filtrationTC = new System.Windows.Forms.TabControl();
			this.recordsFiltrationTP = new System.Windows.Forms.TabPage();
			this.recordsFiltrationTlp = new System.Windows.Forms.TableLayoutPanel();
			this.dateFromRecordsFiltrationLbl = new System.Windows.Forms.Label();
			this.dateToRecordsFiltrationDtp = new System.Windows.Forms.DateTimePicker();
			this.typeRecordsFiltrationLbl = new System.Windows.Forms.Label();
			this.recordsFiltrationBtn = new System.Windows.Forms.Button();
			this.dateToRecordsFiltrationLbl = new System.Windows.Forms.Label();
			this.dateFromRecordsFiltrationDtp = new System.Windows.Forms.DateTimePicker();
			this.typeRecordsFiltrationCb = new System.Windows.Forms.ComboBox();
			this.notesFiltrationTP = new System.Windows.Forms.TabPage();
			this.notesFiltrationTlp = new System.Windows.Forms.TableLayoutPanel();
			this.dateFromNotesFiltrationLbl = new System.Windows.Forms.Label();
			this.dateToNotesFiltrationDtp = new System.Windows.Forms.DateTimePicker();
			this.notesFiltrationBtn = new System.Windows.Forms.Button();
			this.dateToNotesFiltrationLbl = new System.Windows.Forms.Label();
			this.dateFromNotesFiltrationDtp = new System.Windows.Forms.DateTimePicker();
			this.checkItemsFiltrationTP = new System.Windows.Forms.TabPage();
			this.checkItemsFiltrationTlp = new System.Windows.Forms.TableLayoutPanel();
			this.completedCheckItemsFiltrationCB = new System.Windows.Forms.ComboBox();
			this.completedCheckItemsFiltrationLbl = new System.Windows.Forms.Label();
			this.typeCheckItemsFiltrationLbl = new System.Windows.Forms.Label();
			this.typeCheckItemsFiltrationCb = new System.Windows.Forms.ComboBox();
			this.checkItemsFiltrationBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.logoPb)).BeginInit();
			this.mainTc.SuspendLayout();
			this.recordsTP.SuspendLayout();
			this.recordsTlp.SuspendLayout();
			this.notesTP.SuspendLayout();
			this.notesTlp.SuspendLayout();
			this.checklistTP.SuspendLayout();
			this.checklistTlp.SuspendLayout();
			this.filtrationTC.SuspendLayout();
			this.recordsFiltrationTP.SuspendLayout();
			this.recordsFiltrationTlp.SuspendLayout();
			this.notesFiltrationTP.SuspendLayout();
			this.notesFiltrationTlp.SuspendLayout();
			this.checkItemsFiltrationTP.SuspendLayout();
			this.checkItemsFiltrationTlp.SuspendLayout();
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
			this.recordDescriptionCh.Width = 143;
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
			this.versionLbl.Text = "v1.4";
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
			this.noteTextCh.Width = 320;
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
			this.createCheckItemBtn.Click += new System.EventHandler(this.createCheckItemBtn_Click);
			// 
			// checklistLv
			// 
			this.checklistLv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.checklistLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.checklistLv.FullRowSelect = true;
			this.checklistLv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.checklistLv.HideSelection = false;
			this.checklistLv.Location = new System.Drawing.Point(198, 3);
			this.checklistLv.MultiSelect = false;
			this.checklistLv.Name = "checklistLv";
			this.checklistTlp.SetRowSpan(this.checklistLv, 5);
			this.checklistLv.Size = new System.Drawing.Size(469, 294);
			this.checklistLv.StateImageList = this.checkedImageList;
			this.checklistLv.TabIndex = 0;
			this.checklistLv.UseCompatibleStateImageBehavior = false;
			this.checklistLv.View = System.Windows.Forms.View.Details;
			this.checklistLv.SelectedIndexChanged += new System.EventHandler(this.checklistLv_SelectedIndexChanged);
			this.checklistLv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checklistLv_KeyDown);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Úkoly";
			this.columnHeader1.Width = 444;
			// 
			// checkedImageList
			// 
			this.checkedImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("checkedImageList.ImageStream")));
			this.checkedImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.checkedImageList.Images.SetKeyName(0, "check_false.png");
			this.checkedImageList.Images.SetKeyName(1, "check_true.png");
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
			this.editCheckItemBtn.Click += new System.EventHandler(this.editCheckItemBtn_Click);
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
			this.deleteCheckItemBtn.Click += new System.EventHandler(this.deleteCheckItemBtn_Click);
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
			this.completeCheckItemBtn.Click += new System.EventHandler(this.completeCheckItemBtn_Click);
			// 
			// filtrationTC
			// 
			this.filtrationTC.Controls.Add(this.recordsFiltrationTP);
			this.filtrationTC.Controls.Add(this.notesFiltrationTP);
			this.filtrationTC.Controls.Add(this.checkItemsFiltrationTP);
			this.filtrationTC.Location = new System.Drawing.Point(218, 12);
			this.filtrationTC.Name = "filtrationTC";
			this.filtrationTC.SelectedIndex = 0;
			this.filtrationTC.Size = new System.Drawing.Size(473, 132);
			this.filtrationTC.TabIndex = 13;
			// 
			// recordsFiltrationTP
			// 
			this.recordsFiltrationTP.Controls.Add(this.recordsFiltrationTlp);
			this.recordsFiltrationTP.Location = new System.Drawing.Point(4, 22);
			this.recordsFiltrationTP.Name = "recordsFiltrationTP";
			this.recordsFiltrationTP.Padding = new System.Windows.Forms.Padding(3);
			this.recordsFiltrationTP.Size = new System.Drawing.Size(465, 106);
			this.recordsFiltrationTP.TabIndex = 0;
			this.recordsFiltrationTP.Text = "Filtrování";
			this.recordsFiltrationTP.UseVisualStyleBackColor = true;
			// 
			// recordsFiltrationTlp
			// 
			this.recordsFiltrationTlp.ColumnCount = 3;
			this.recordsFiltrationTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.recordsFiltrationTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.recordsFiltrationTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
			this.recordsFiltrationTlp.Controls.Add(this.dateFromRecordsFiltrationLbl, 0, 0);
			this.recordsFiltrationTlp.Controls.Add(this.dateToRecordsFiltrationDtp, 1, 1);
			this.recordsFiltrationTlp.Controls.Add(this.typeRecordsFiltrationLbl, 0, 2);
			this.recordsFiltrationTlp.Controls.Add(this.recordsFiltrationBtn, 2, 2);
			this.recordsFiltrationTlp.Controls.Add(this.dateToRecordsFiltrationLbl, 0, 1);
			this.recordsFiltrationTlp.Controls.Add(this.dateFromRecordsFiltrationDtp, 1, 0);
			this.recordsFiltrationTlp.Controls.Add(this.typeRecordsFiltrationCb, 1, 2);
			this.recordsFiltrationTlp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.recordsFiltrationTlp.Location = new System.Drawing.Point(3, 3);
			this.recordsFiltrationTlp.Name = "recordsFiltrationTlp";
			this.recordsFiltrationTlp.RowCount = 3;
			this.recordsFiltrationTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.recordsFiltrationTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.recordsFiltrationTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.recordsFiltrationTlp.Size = new System.Drawing.Size(459, 100);
			this.recordsFiltrationTlp.TabIndex = 16;
			// 
			// dateFromRecordsFiltrationLbl
			// 
			this.dateFromRecordsFiltrationLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateFromRecordsFiltrationLbl.Location = new System.Drawing.Point(3, 0);
			this.dateFromRecordsFiltrationLbl.Name = "dateFromRecordsFiltrationLbl";
			this.dateFromRecordsFiltrationLbl.Size = new System.Drawing.Size(74, 33);
			this.dateFromRecordsFiltrationLbl.TabIndex = 12;
			this.dateFromRecordsFiltrationLbl.Text = "Datum od";
			this.dateFromRecordsFiltrationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dateToRecordsFiltrationDtp
			// 
			this.dateToRecordsFiltrationDtp.CustomFormat = "dd.MM.yyyy HH:mm:ss";
			this.dateToRecordsFiltrationDtp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateToRecordsFiltrationDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateToRecordsFiltrationDtp.Location = new System.Drawing.Point(83, 36);
			this.dateToRecordsFiltrationDtp.Name = "dateToRecordsFiltrationDtp";
			this.dateToRecordsFiltrationDtp.Size = new System.Drawing.Size(228, 20);
			this.dateToRecordsFiltrationDtp.TabIndex = 8;
			this.dateToRecordsFiltrationDtp.ValueChanged += new System.EventHandler(this.dateToRecordsFiltrationDtp_ValueChanged);
			// 
			// typeRecordsFiltrationLbl
			// 
			this.typeRecordsFiltrationLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.typeRecordsFiltrationLbl.Location = new System.Drawing.Point(3, 66);
			this.typeRecordsFiltrationLbl.Name = "typeRecordsFiltrationLbl";
			this.typeRecordsFiltrationLbl.Size = new System.Drawing.Size(74, 34);
			this.typeRecordsFiltrationLbl.TabIndex = 14;
			this.typeRecordsFiltrationLbl.Text = "Typ aktivity";
			this.typeRecordsFiltrationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// recordsFiltrationBtn
			// 
			this.recordsFiltrationBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.recordsFiltrationBtn.Location = new System.Drawing.Point(360, 76);
			this.recordsFiltrationBtn.Name = "recordsFiltrationBtn";
			this.recordsFiltrationBtn.Size = new System.Drawing.Size(96, 21);
			this.recordsFiltrationBtn.TabIndex = 10;
			this.recordsFiltrationBtn.Text = "Filtrování";
			this.recordsFiltrationBtn.UseVisualStyleBackColor = true;
			this.recordsFiltrationBtn.Click += new System.EventHandler(this.recordsFiltrationBtn_Click);
			// 
			// dateToRecordsFiltrationLbl
			// 
			this.dateToRecordsFiltrationLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateToRecordsFiltrationLbl.Location = new System.Drawing.Point(3, 33);
			this.dateToRecordsFiltrationLbl.Name = "dateToRecordsFiltrationLbl";
			this.dateToRecordsFiltrationLbl.Size = new System.Drawing.Size(74, 33);
			this.dateToRecordsFiltrationLbl.TabIndex = 13;
			this.dateToRecordsFiltrationLbl.Text = "Datum do";
			this.dateToRecordsFiltrationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dateFromRecordsFiltrationDtp
			// 
			this.dateFromRecordsFiltrationDtp.CustomFormat = "dd.MM.yyyy HH:mm:ss";
			this.dateFromRecordsFiltrationDtp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateFromRecordsFiltrationDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateFromRecordsFiltrationDtp.Location = new System.Drawing.Point(83, 3);
			this.dateFromRecordsFiltrationDtp.Name = "dateFromRecordsFiltrationDtp";
			this.dateFromRecordsFiltrationDtp.Size = new System.Drawing.Size(228, 20);
			this.dateFromRecordsFiltrationDtp.TabIndex = 9;
			this.dateFromRecordsFiltrationDtp.ValueChanged += new System.EventHandler(this.dateFromRecordsFiltrationDtp_ValueChanged);
			// 
			// typeRecordsFiltrationCb
			// 
			this.typeRecordsFiltrationCb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.typeRecordsFiltrationCb.FormattingEnabled = true;
			this.typeRecordsFiltrationCb.Location = new System.Drawing.Point(83, 69);
			this.typeRecordsFiltrationCb.Name = "typeRecordsFiltrationCb";
			this.typeRecordsFiltrationCb.Size = new System.Drawing.Size(228, 21);
			this.typeRecordsFiltrationCb.TabIndex = 11;
			this.typeRecordsFiltrationCb.TextChanged += new System.EventHandler(this.typeRecordsFiltrationCb_TextChanged);
			// 
			// notesFiltrationTP
			// 
			this.notesFiltrationTP.Controls.Add(this.notesFiltrationTlp);
			this.notesFiltrationTP.Location = new System.Drawing.Point(4, 22);
			this.notesFiltrationTP.Name = "notesFiltrationTP";
			this.notesFiltrationTP.Padding = new System.Windows.Forms.Padding(3);
			this.notesFiltrationTP.Size = new System.Drawing.Size(465, 106);
			this.notesFiltrationTP.TabIndex = 1;
			this.notesFiltrationTP.Text = "Filtrování";
			this.notesFiltrationTP.UseVisualStyleBackColor = true;
			// 
			// notesFiltrationTlp
			// 
			this.notesFiltrationTlp.ColumnCount = 3;
			this.notesFiltrationTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.notesFiltrationTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.notesFiltrationTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
			this.notesFiltrationTlp.Controls.Add(this.dateFromNotesFiltrationLbl, 0, 0);
			this.notesFiltrationTlp.Controls.Add(this.dateToNotesFiltrationDtp, 1, 1);
			this.notesFiltrationTlp.Controls.Add(this.notesFiltrationBtn, 2, 2);
			this.notesFiltrationTlp.Controls.Add(this.dateToNotesFiltrationLbl, 0, 1);
			this.notesFiltrationTlp.Controls.Add(this.dateFromNotesFiltrationDtp, 1, 0);
			this.notesFiltrationTlp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.notesFiltrationTlp.Location = new System.Drawing.Point(3, 3);
			this.notesFiltrationTlp.Name = "notesFiltrationTlp";
			this.notesFiltrationTlp.RowCount = 3;
			this.notesFiltrationTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.notesFiltrationTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.notesFiltrationTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.notesFiltrationTlp.Size = new System.Drawing.Size(459, 100);
			this.notesFiltrationTlp.TabIndex = 17;
			// 
			// dateFromNotesFiltrationLbl
			// 
			this.dateFromNotesFiltrationLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateFromNotesFiltrationLbl.Location = new System.Drawing.Point(3, 0);
			this.dateFromNotesFiltrationLbl.Name = "dateFromNotesFiltrationLbl";
			this.dateFromNotesFiltrationLbl.Size = new System.Drawing.Size(74, 33);
			this.dateFromNotesFiltrationLbl.TabIndex = 12;
			this.dateFromNotesFiltrationLbl.Text = "Datum od";
			this.dateFromNotesFiltrationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dateToNotesFiltrationDtp
			// 
			this.dateToNotesFiltrationDtp.CustomFormat = "dd.MM.yyyy HH:mm:ss";
			this.dateToNotesFiltrationDtp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateToNotesFiltrationDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateToNotesFiltrationDtp.Location = new System.Drawing.Point(83, 36);
			this.dateToNotesFiltrationDtp.Name = "dateToNotesFiltrationDtp";
			this.dateToNotesFiltrationDtp.Size = new System.Drawing.Size(228, 20);
			this.dateToNotesFiltrationDtp.TabIndex = 8;
			this.dateToNotesFiltrationDtp.ValueChanged += new System.EventHandler(this.dateToNotesFiltrationDtp_ValueChanged);
			// 
			// notesFiltrationBtn
			// 
			this.notesFiltrationBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.notesFiltrationBtn.Location = new System.Drawing.Point(360, 76);
			this.notesFiltrationBtn.Name = "notesFiltrationBtn";
			this.notesFiltrationBtn.Size = new System.Drawing.Size(96, 21);
			this.notesFiltrationBtn.TabIndex = 10;
			this.notesFiltrationBtn.Text = "Filtrování";
			this.notesFiltrationBtn.UseVisualStyleBackColor = true;
			this.notesFiltrationBtn.Click += new System.EventHandler(this.notesFiltrationBtn_Click);
			// 
			// dateToNotesFiltrationLbl
			// 
			this.dateToNotesFiltrationLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateToNotesFiltrationLbl.Location = new System.Drawing.Point(3, 33);
			this.dateToNotesFiltrationLbl.Name = "dateToNotesFiltrationLbl";
			this.dateToNotesFiltrationLbl.Size = new System.Drawing.Size(74, 33);
			this.dateToNotesFiltrationLbl.TabIndex = 13;
			this.dateToNotesFiltrationLbl.Text = "Datum do";
			this.dateToNotesFiltrationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dateFromNotesFiltrationDtp
			// 
			this.dateFromNotesFiltrationDtp.CustomFormat = "dd.MM.yyyy HH:mm:ss";
			this.dateFromNotesFiltrationDtp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateFromNotesFiltrationDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateFromNotesFiltrationDtp.Location = new System.Drawing.Point(83, 3);
			this.dateFromNotesFiltrationDtp.Name = "dateFromNotesFiltrationDtp";
			this.dateFromNotesFiltrationDtp.Size = new System.Drawing.Size(228, 20);
			this.dateFromNotesFiltrationDtp.TabIndex = 9;
			this.dateFromNotesFiltrationDtp.ValueChanged += new System.EventHandler(this.dateFromNotesFiltrationDtp_ValueChanged);
			// 
			// checkItemsFiltrationTP
			// 
			this.checkItemsFiltrationTP.Controls.Add(this.checkItemsFiltrationTlp);
			this.checkItemsFiltrationTP.Location = new System.Drawing.Point(4, 22);
			this.checkItemsFiltrationTP.Name = "checkItemsFiltrationTP";
			this.checkItemsFiltrationTP.Padding = new System.Windows.Forms.Padding(3);
			this.checkItemsFiltrationTP.Size = new System.Drawing.Size(465, 106);
			this.checkItemsFiltrationTP.TabIndex = 2;
			this.checkItemsFiltrationTP.Text = "Filtrování";
			this.checkItemsFiltrationTP.UseVisualStyleBackColor = true;
			// 
			// checkItemsFiltrationTlp
			// 
			this.checkItemsFiltrationTlp.ColumnCount = 3;
			this.checkItemsFiltrationTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.checkItemsFiltrationTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.checkItemsFiltrationTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
			this.checkItemsFiltrationTlp.Controls.Add(this.completedCheckItemsFiltrationCB, 1, 1);
			this.checkItemsFiltrationTlp.Controls.Add(this.completedCheckItemsFiltrationLbl, 0, 1);
			this.checkItemsFiltrationTlp.Controls.Add(this.typeCheckItemsFiltrationLbl, 0, 0);
			this.checkItemsFiltrationTlp.Controls.Add(this.typeCheckItemsFiltrationCb, 1, 0);
			this.checkItemsFiltrationTlp.Controls.Add(this.checkItemsFiltrationBtn, 2, 2);
			this.checkItemsFiltrationTlp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkItemsFiltrationTlp.Location = new System.Drawing.Point(3, 3);
			this.checkItemsFiltrationTlp.Name = "checkItemsFiltrationTlp";
			this.checkItemsFiltrationTlp.RowCount = 3;
			this.checkItemsFiltrationTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.checkItemsFiltrationTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.checkItemsFiltrationTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.checkItemsFiltrationTlp.Size = new System.Drawing.Size(459, 100);
			this.checkItemsFiltrationTlp.TabIndex = 18;
			// 
			// completedCheckItemsFiltrationCB
			// 
			this.completedCheckItemsFiltrationCB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.completedCheckItemsFiltrationCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.completedCheckItemsFiltrationCB.FormattingEnabled = true;
			this.completedCheckItemsFiltrationCB.Location = new System.Drawing.Point(83, 36);
			this.completedCheckItemsFiltrationCB.Name = "completedCheckItemsFiltrationCB";
			this.completedCheckItemsFiltrationCB.Size = new System.Drawing.Size(228, 21);
			this.completedCheckItemsFiltrationCB.TabIndex = 16;
			this.completedCheckItemsFiltrationCB.SelectedIndexChanged += new System.EventHandler(this.completedCheckItemsFiltrationCB_SelectedIndexChanged);
			// 
			// completedCheckItemsFiltrationLbl
			// 
			this.completedCheckItemsFiltrationLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.completedCheckItemsFiltrationLbl.Location = new System.Drawing.Point(3, 33);
			this.completedCheckItemsFiltrationLbl.Name = "completedCheckItemsFiltrationLbl";
			this.completedCheckItemsFiltrationLbl.Size = new System.Drawing.Size(74, 33);
			this.completedCheckItemsFiltrationLbl.TabIndex = 15;
			this.completedCheckItemsFiltrationLbl.Text = "Dokončenost";
			this.completedCheckItemsFiltrationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// typeCheckItemsFiltrationLbl
			// 
			this.typeCheckItemsFiltrationLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.typeCheckItemsFiltrationLbl.Location = new System.Drawing.Point(3, 0);
			this.typeCheckItemsFiltrationLbl.Name = "typeCheckItemsFiltrationLbl";
			this.typeCheckItemsFiltrationLbl.Size = new System.Drawing.Size(74, 33);
			this.typeCheckItemsFiltrationLbl.TabIndex = 13;
			this.typeCheckItemsFiltrationLbl.Text = "Typ úkolů";
			this.typeCheckItemsFiltrationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// typeCheckItemsFiltrationCb
			// 
			this.typeCheckItemsFiltrationCb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.typeCheckItemsFiltrationCb.FormattingEnabled = true;
			this.typeCheckItemsFiltrationCb.Location = new System.Drawing.Point(83, 3);
			this.typeCheckItemsFiltrationCb.Name = "typeCheckItemsFiltrationCb";
			this.typeCheckItemsFiltrationCb.Size = new System.Drawing.Size(228, 21);
			this.typeCheckItemsFiltrationCb.TabIndex = 14;
			this.typeCheckItemsFiltrationCb.TextChanged += new System.EventHandler(this.typeCheckItemsFiltrationCb_TextChanged);
			// 
			// checkItemsFiltrationBtn
			// 
			this.checkItemsFiltrationBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.checkItemsFiltrationBtn.Location = new System.Drawing.Point(360, 76);
			this.checkItemsFiltrationBtn.Name = "checkItemsFiltrationBtn";
			this.checkItemsFiltrationBtn.Size = new System.Drawing.Size(96, 21);
			this.checkItemsFiltrationBtn.TabIndex = 10;
			this.checkItemsFiltrationBtn.Text = "Filtrování";
			this.checkItemsFiltrationBtn.UseVisualStyleBackColor = true;
			this.checkItemsFiltrationBtn.Click += new System.EventHandler(this.checkItemsFiltrationBtn_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(703, 480);
			this.Controls.Add(this.filtrationTC);
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
			this.checklistTP.ResumeLayout(false);
			this.checklistTlp.ResumeLayout(false);
			this.filtrationTC.ResumeLayout(false);
			this.recordsFiltrationTP.ResumeLayout(false);
			this.recordsFiltrationTlp.ResumeLayout(false);
			this.notesFiltrationTP.ResumeLayout(false);
			this.notesFiltrationTlp.ResumeLayout(false);
			this.checkItemsFiltrationTP.ResumeLayout(false);
			this.checkItemsFiltrationTlp.ResumeLayout(false);
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
		private System.Windows.Forms.Button statisticsBtn;
		private System.Windows.Forms.TabPage checklistTP;
		private System.Windows.Forms.TableLayoutPanel checklistTlp;
		private System.Windows.Forms.Button createCheckItemBtn;
		private System.Windows.Forms.ListView checklistLv;
		private System.Windows.Forms.Button editCheckItemBtn;
		private System.Windows.Forms.Button deleteCheckItemBtn;
		private System.Windows.Forms.Button completeCheckItemBtn;
		private System.Windows.Forms.ImageList checkedImageList;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.TabControl filtrationTC;
		private System.Windows.Forms.TabPage recordsFiltrationTP;
		private System.Windows.Forms.TableLayoutPanel recordsFiltrationTlp;
		private System.Windows.Forms.Label dateFromRecordsFiltrationLbl;
		private System.Windows.Forms.DateTimePicker dateToRecordsFiltrationDtp;
		private System.Windows.Forms.Label typeRecordsFiltrationLbl;
		private System.Windows.Forms.Button recordsFiltrationBtn;
		private System.Windows.Forms.Label dateToRecordsFiltrationLbl;
		private System.Windows.Forms.DateTimePicker dateFromRecordsFiltrationDtp;
		private System.Windows.Forms.ComboBox typeRecordsFiltrationCb;
		private System.Windows.Forms.TabPage notesFiltrationTP;
		private System.Windows.Forms.TableLayoutPanel notesFiltrationTlp;
		private System.Windows.Forms.Label dateFromNotesFiltrationLbl;
		private System.Windows.Forms.DateTimePicker dateToNotesFiltrationDtp;
		private System.Windows.Forms.Button notesFiltrationBtn;
		private System.Windows.Forms.Label dateToNotesFiltrationLbl;
		private System.Windows.Forms.DateTimePicker dateFromNotesFiltrationDtp;
		private System.Windows.Forms.TabPage checkItemsFiltrationTP;
		private System.Windows.Forms.TableLayoutPanel checkItemsFiltrationTlp;
		private System.Windows.Forms.Button checkItemsFiltrationBtn;
		private System.Windows.Forms.Label completedCheckItemsFiltrationLbl;
		private System.Windows.Forms.Label typeCheckItemsFiltrationLbl;
		private System.Windows.Forms.ComboBox typeCheckItemsFiltrationCb;
		private System.Windows.Forms.ComboBox completedCheckItemsFiltrationCB;
	}
}

