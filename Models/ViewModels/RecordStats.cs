using System;
using System.Collections.Generic;
using System.Text;

namespace Eli.TimeManagement.Models.ViewModels
{
	public class RecordStats
	{
		public int MinutesTotal { get; set; }
		public int ActiveDaysTotal { get; set; }
		public int DaysTotal { get; set; }
		public double ActiveDaysPercent { get; set; }
		public double MinutesPerActiveDays { get; set; }
		public double MinutesPerDays { get; set; }
		public List<TypeStats> TypesStats { get; set; }
	}
}
