using System;
using System.Collections.Generic;
using System.Text;

namespace Eli.TimeManagement.Models.Entities
{
	public class Record
	{
		public Record()
		{
			Start = DateTime.Today;
		}
		public int ID;
		public string Type;
		public string Description;
		public DateTime Start;
		public int MinutesTotal;
	}
}
