namespace Eli.TimeManagement.FormsLibrary
{
	partial class NullableDateTimePicker
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dtp = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// dtp
			// 
			this.dtp.CustomFormat = "dd.MM.yyyy";
			this.dtp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp.Location = new System.Drawing.Point(0, 0);
			this.dtp.Margin = new System.Windows.Forms.Padding(0);
			this.dtp.Name = "dtp";
			this.dtp.Size = new System.Drawing.Size(200, 20);
			this.dtp.TabIndex = 0;
			// 
			// NullableDateTimePicker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dtp);
			this.Name = "NullableDateTimePicker";
			this.Size = new System.Drawing.Size(200, 20);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtp;
	}
}
