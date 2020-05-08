using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eli.TimeManagement.App
{
	public partial class NullableDateTimePicker : DateTimePicker
	{
		private bool _isNull = true;
		public DateTime? NullableValue
		{
			get
			{
				if (_isNull)
				{
					return null;
				}
				return Value;
			}
			set
			{
				if (value == null)
				{
					_isNull = true;
				}
				else
				{
					_isNull = false;
					Value = value.Value;
				}
			}
		}
		
		public NullableDateTimePicker()
		{
			
		}
	}
}
