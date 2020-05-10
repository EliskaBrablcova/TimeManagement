using Eli.TimeManagement.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eli.TimeManagement.App
{
	public partial class StatisticsForm : Form
	{
		public StatisticsForm(RecordStats stats)
		{
			InitializeComponent();
			display(stats);
		}

		private void display(RecordStats stats)
		{
			minutesTotalValueLbl.Text = stats.MinutesTotal.ToString();
			daysTotalValueLbl.Text = stats.DaysTotal.ToString();
			activeDaysTotalValueLbl.Text = stats.ActiveDaysTotal.ToString();
			activeDaysPercentValueLbl.Text = stats.ActiveDaysPercent.ToString("n2");
			minutesPerDaysValueLbl.Text = stats.MinutesPerDays.ToString("n2");
			minutesPerActiveDaysValueLbl.Text = stats.MinutesPerActiveDays.ToString("n2");
		}
	}
	
}
