namespace Eli.TimeManagement.App
{
	partial class StatisticsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsForm));
			this.statisticsTlp = new System.Windows.Forms.TableLayoutPanel();
			this.minutesTotalLbl = new System.Windows.Forms.Label();
			this.minutesTotalValueLbl = new System.Windows.Forms.Label();
			this.daysTotalLbl = new System.Windows.Forms.Label();
			this.daysTotalValueLbl = new System.Windows.Forms.Label();
			this.activeDaysTotalLbl = new System.Windows.Forms.Label();
			this.activeDaysTotalValueLbl = new System.Windows.Forms.Label();
			this.activeDaysPercentLbl = new System.Windows.Forms.Label();
			this.activeDaysPercentValueLbl = new System.Windows.Forms.Label();
			this.minutesPerDaysLbl = new System.Windows.Forms.Label();
			this.minutesPerDaysValueLbl = new System.Windows.Forms.Label();
			this.minutesPerActiveDaysLbl = new System.Windows.Forms.Label();
			this.minutesPerActiveDaysValueLbl = new System.Windows.Forms.Label();
			this.statisticsTlp.SuspendLayout();
			this.SuspendLayout();
			// 
			// statisticsTlp
			// 
			this.statisticsTlp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.statisticsTlp.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.statisticsTlp.ColumnCount = 2;
			this.statisticsTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.33333F));
			this.statisticsTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.66667F));
			this.statisticsTlp.Controls.Add(this.minutesPerActiveDaysValueLbl, 1, 5);
			this.statisticsTlp.Controls.Add(this.minutesPerActiveDaysLbl, 0, 5);
			this.statisticsTlp.Controls.Add(this.minutesPerDaysValueLbl, 1, 4);
			this.statisticsTlp.Controls.Add(this.minutesPerDaysLbl, 0, 4);
			this.statisticsTlp.Controls.Add(this.activeDaysPercentValueLbl, 1, 3);
			this.statisticsTlp.Controls.Add(this.activeDaysPercentLbl, 0, 3);
			this.statisticsTlp.Controls.Add(this.activeDaysTotalValueLbl, 1, 2);
			this.statisticsTlp.Controls.Add(this.activeDaysTotalLbl, 0, 2);
			this.statisticsTlp.Controls.Add(this.daysTotalValueLbl, 1, 1);
			this.statisticsTlp.Controls.Add(this.daysTotalLbl, 0, 1);
			this.statisticsTlp.Controls.Add(this.minutesTotalValueLbl, 1, 0);
			this.statisticsTlp.Controls.Add(this.minutesTotalLbl, 0, 0);
			this.statisticsTlp.Location = new System.Drawing.Point(12, 12);
			this.statisticsTlp.Name = "statisticsTlp";
			this.statisticsTlp.RowCount = 6;
			this.statisticsTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.statisticsTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.statisticsTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.statisticsTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.statisticsTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.statisticsTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
			this.statisticsTlp.Size = new System.Drawing.Size(420, 126);
			this.statisticsTlp.TabIndex = 0;
			// 
			// minutesTotalLbl
			// 
			this.minutesTotalLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minutesTotalLbl.Location = new System.Drawing.Point(4, 1);
			this.minutesTotalLbl.Name = "minutesTotalLbl";
			this.minutesTotalLbl.Size = new System.Drawing.Size(195, 20);
			this.minutesTotalLbl.TabIndex = 0;
			this.minutesTotalLbl.Text = "Suma minut";
			this.minutesTotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// minutesTotalValueLbl
			// 
			this.minutesTotalValueLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minutesTotalValueLbl.Location = new System.Drawing.Point(206, 1);
			this.minutesTotalValueLbl.Name = "minutesTotalValueLbl";
			this.minutesTotalValueLbl.Size = new System.Drawing.Size(210, 20);
			this.minutesTotalValueLbl.TabIndex = 1;
			this.minutesTotalValueLbl.Text = "N/A";
			this.minutesTotalValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// daysTotalLbl
			// 
			this.daysTotalLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.daysTotalLbl.Location = new System.Drawing.Point(4, 22);
			this.daysTotalLbl.Name = "daysTotalLbl";
			this.daysTotalLbl.Size = new System.Drawing.Size(195, 20);
			this.daysTotalLbl.TabIndex = 2;
			this.daysTotalLbl.Text = "Suma dní";
			this.daysTotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// daysTotalValueLbl
			// 
			this.daysTotalValueLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.daysTotalValueLbl.Location = new System.Drawing.Point(206, 22);
			this.daysTotalValueLbl.Name = "daysTotalValueLbl";
			this.daysTotalValueLbl.Size = new System.Drawing.Size(210, 20);
			this.daysTotalValueLbl.TabIndex = 3;
			this.daysTotalValueLbl.Text = "N/A";
			this.daysTotalValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// activeDaysTotalLbl
			// 
			this.activeDaysTotalLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.activeDaysTotalLbl.Location = new System.Drawing.Point(4, 43);
			this.activeDaysTotalLbl.Name = "activeDaysTotalLbl";
			this.activeDaysTotalLbl.Size = new System.Drawing.Size(195, 20);
			this.activeDaysTotalLbl.TabIndex = 4;
			this.activeDaysTotalLbl.Text = "Suma aktivních dní";
			this.activeDaysTotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// activeDaysTotalValueLbl
			// 
			this.activeDaysTotalValueLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.activeDaysTotalValueLbl.Location = new System.Drawing.Point(206, 43);
			this.activeDaysTotalValueLbl.Name = "activeDaysTotalValueLbl";
			this.activeDaysTotalValueLbl.Size = new System.Drawing.Size(210, 20);
			this.activeDaysTotalValueLbl.TabIndex = 5;
			this.activeDaysTotalValueLbl.Text = "N/A";
			this.activeDaysTotalValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// activeDaysPercentLbl
			// 
			this.activeDaysPercentLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.activeDaysPercentLbl.Location = new System.Drawing.Point(4, 64);
			this.activeDaysPercentLbl.Name = "activeDaysPercentLbl";
			this.activeDaysPercentLbl.Size = new System.Drawing.Size(195, 20);
			this.activeDaysPercentLbl.TabIndex = 6;
			this.activeDaysPercentLbl.Text = "Podíl aktivních dní";
			this.activeDaysPercentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// activeDaysPercentValueLbl
			// 
			this.activeDaysPercentValueLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.activeDaysPercentValueLbl.Location = new System.Drawing.Point(206, 64);
			this.activeDaysPercentValueLbl.Name = "activeDaysPercentValueLbl";
			this.activeDaysPercentValueLbl.Size = new System.Drawing.Size(210, 20);
			this.activeDaysPercentValueLbl.TabIndex = 7;
			this.activeDaysPercentValueLbl.Text = "N/A";
			this.activeDaysPercentValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// minutesPerDaysLbl
			// 
			this.minutesPerDaysLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minutesPerDaysLbl.Location = new System.Drawing.Point(4, 85);
			this.minutesPerDaysLbl.Name = "minutesPerDaysLbl";
			this.minutesPerDaysLbl.Size = new System.Drawing.Size(195, 20);
			this.minutesPerDaysLbl.TabIndex = 8;
			this.minutesPerDaysLbl.Text = "Průměr minut na den";
			this.minutesPerDaysLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// minutesPerDaysValueLbl
			// 
			this.minutesPerDaysValueLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minutesPerDaysValueLbl.Location = new System.Drawing.Point(206, 85);
			this.minutesPerDaysValueLbl.Name = "minutesPerDaysValueLbl";
			this.minutesPerDaysValueLbl.Size = new System.Drawing.Size(210, 20);
			this.minutesPerDaysValueLbl.TabIndex = 9;
			this.minutesPerDaysValueLbl.Text = "N/A";
			this.minutesPerDaysValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// minutesPerActiveDaysLbl
			// 
			this.minutesPerActiveDaysLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minutesPerActiveDaysLbl.Location = new System.Drawing.Point(4, 106);
			this.minutesPerActiveDaysLbl.Name = "minutesPerActiveDaysLbl";
			this.minutesPerActiveDaysLbl.Size = new System.Drawing.Size(195, 19);
			this.minutesPerActiveDaysLbl.TabIndex = 10;
			this.minutesPerActiveDaysLbl.Text = "Průměr minut na aktivní den";
			this.minutesPerActiveDaysLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// minutesPerActiveDaysValueLbl
			// 
			this.minutesPerActiveDaysValueLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minutesPerActiveDaysValueLbl.Location = new System.Drawing.Point(206, 106);
			this.minutesPerActiveDaysValueLbl.Name = "minutesPerActiveDaysValueLbl";
			this.minutesPerActiveDaysValueLbl.Size = new System.Drawing.Size(210, 19);
			this.minutesPerActiveDaysValueLbl.TabIndex = 11;
			this.minutesPerActiveDaysValueLbl.Text = "N/A";
			this.minutesPerActiveDaysValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Statistics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(442, 150);
			this.Controls.Add(this.statisticsTlp);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Statistics";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Statistiky";
			this.statisticsTlp.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel statisticsTlp;
		private System.Windows.Forms.Label minutesPerActiveDaysValueLbl;
		private System.Windows.Forms.Label minutesPerActiveDaysLbl;
		private System.Windows.Forms.Label minutesPerDaysValueLbl;
		private System.Windows.Forms.Label minutesPerDaysLbl;
		private System.Windows.Forms.Label activeDaysPercentValueLbl;
		private System.Windows.Forms.Label activeDaysPercentLbl;
		private System.Windows.Forms.Label activeDaysTotalValueLbl;
		private System.Windows.Forms.Label activeDaysTotalLbl;
		private System.Windows.Forms.Label daysTotalValueLbl;
		private System.Windows.Forms.Label daysTotalLbl;
		private System.Windows.Forms.Label minutesTotalValueLbl;
		private System.Windows.Forms.Label minutesTotalLbl;
	}
}