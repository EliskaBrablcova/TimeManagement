﻿using Eli.TimeManagement.Models.ViewModels;
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
			timeTotalValueLbl.Text = new TimeSpanVM(stats.MinutesTotal).ToString();
			daysTotalValueLbl.Text = stats.DaysTotal.ToString();
			activeDaysTotalValueLbl.Text = stats.ActiveDaysTotal.ToString();
			activeDaysPercentValueLbl.Text = stats.ActiveDaysPercent.ToString("n2") + " %";
			minutesPerDaysValueLbl.Text = stats.MinutesPerDays.ToString("n2");
			minutesPerActiveDaysValueLbl.Text = stats.MinutesPerActiveDays.ToString("n2");
			display(stats.TypesStats);
		}

		private void display (IList<TypeStats> typeStats)
		{
			foreach (var typeStat in typeStats)
			{
				addRow(typeStat);
			}
		}

		private void addRow(TypeStats typeStat)
		{
			var texts = new string[] { typeStat.Type, new TimeSpanVM(typeStat.Minutes).ToString(), typeStat.Percent.ToString("n2") };
			var item = new ListViewItem(texts);
		    statisticsTypesLv.Items.Add(item);
		}
	}
	
}
