using System;
using System.Collections.Generic;
using System.Text;

namespace Eli.TimeManagement.Models.Entities
{
	public class Note
	{
		public int ID { get; set; }
		public string Text { get; set; }
		public DateTime Edited { get; set; }
	}
}
