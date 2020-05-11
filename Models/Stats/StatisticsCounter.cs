using Eli.TimeManagement.Models.Entities;
using Eli.TimeManagement.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eli.TimeManagement.Models.Stats
{
	public class StatisticsCounter
	{
		public RecordStats Count(IList<Record> records, DateTime? dateFrom, DateTime? dateTo)
		{
			if (records == null || records.Count == 0)
			{
				var statsTmp = new RecordStats();
				if (dateFrom.HasValue && dateTo.HasValue)
				{
					statsTmp.DaysTotal = getDaysDiff(dateFrom.Value, dateTo.Value);
				}
				return new RecordStats();
			}
			var minutesTotal = 0;
			var activeDaysTotal = 0;
			var realDateFrom = dateFrom.HasValue 
				? dateFrom.Value 
				: getMin(records);			
			var realDateTo = dateTo.HasValue 
				? dateTo.Value 
				: getMax(records);
			var daysTotal = getDaysDiff(realDateFrom, realDateTo);
			var activeDays = new HashSet<DateTime>();
			foreach (var record in records)
			{
				minutesTotal += record.MinutesTotal;
				if (!activeDays.Contains(record.Start.Date))
				{
					activeDays.Add(record.Start.Date);
					activeDaysTotal++;
				}
			}
			var stats = new RecordStats();
			stats.DaysTotal = daysTotal;
			stats.ActiveDaysTotal = activeDaysTotal;
			stats.MinutesTotal = minutesTotal;
			stats.MinutesPerDays = daysTotal > 0
				? minutesTotal / (double)daysTotal
				: 0.0;
			stats.MinutesPerActiveDays = activeDaysTotal > 0
				? minutesTotal / (double)activeDaysTotal
				: 0.0;
			stats.ActiveDaysPercent = daysTotal > 0
				? activeDaysTotal / (double)daysTotal * 100
				: 0.0;
			return stats;
		}

		private DateTime getMin(IList<Record> records)
		{
			var min = records[0].Start.Date;
			for (int i = 1; i < records.Count; i++)
			{
				var record = records[i];
				if (record.Start.Date < min)
				{
					min = record.Start.Date;
				}
			}
			return min;
		}

		private DateTime getMax(IList<Record> records)
		{
			var max = records[0].Start.Date;
			for (int i = 1; i < records.Count; i++)
			{
				var record = records[i];
				if (record.Start.Date > max)
				{
					max = record.Start.Date;
				}
			}
			return max;
		}

		private int getDaysDiff(DateTime dateFrom, DateTime dateTo)
		{
			return (int) (dateTo - dateFrom).TotalDays + 1;
		}
	}
}
