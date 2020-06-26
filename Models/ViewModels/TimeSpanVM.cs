using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Eli.TimeManagement.Models.ViewModels
{
	public class TimeSpanVM
	{
		private readonly int _minutes;
		//1440 = 24 * 60
		private const int _minutesInDays = 1440;

		public TimeSpanVM(int minutes)
		{
			if (minutes < 0)
			{
				throw new ArgumentOutOfRangeException(nameof(minutes));
			}
			_minutes = minutes;
		}
		public override string ToString()
		{
			var sb = new StringBuilder();
			var minutes = _minutes;
			var days = _minutes / _minutesInDays;
			minutes %= _minutesInDays;
			var hours =  minutes / 60;
			minutes %= 60;
			if (days > 0)
			{
				// var result = days.ToString() + "D " + hours.ToString() + "H " + minutes.ToString() + "M "; 
				sb.Append(days).Append(" dní ");
				// sb.Append(days);
				// sb.Append("D ");
			}
			if (hours > 0 || days > 0)
			{
				sb.Append(hours).Append(" hod ");
			}
			sb.Append(minutes).Append(" min");
			return sb.ToString();
		}
	}
}
