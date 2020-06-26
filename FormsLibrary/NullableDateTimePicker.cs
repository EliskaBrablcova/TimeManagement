using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Eli.TimeManagement.FormsLibrary
{
	public partial class NullableDateTimePicker : UserControl
	{
		public NullableDateTimePicker()
		{
			InitializeComponent();
			dtp.ValueChanged += Dtp_ValueChanged;
			dtp.KeyDown += Dtp_KeyDown;
		}

		private DateTime? _value;
		private bool _reactToValueChange = true;
		private EventHandler _onValueChanged;
		private string _customFormat;
		private const string _nullFormat = " ";

		public event EventHandler ValueChanged
		{
			add => _onValueChanged += value;
			remove => _onValueChanged -= value;
		}

		[Bindable(true)]
		[RefreshProperties(RefreshProperties.All)]
		[DefaultValue(null)]
		public DateTime? Value
		{
			get => _value;
			set
			{
				var changed = value != _value;
				_value = value;
				if (value != null)
				{
					_reactToValueChange = false;
					dtp.Value = value.Value;
					dtp.CustomFormat = _customFormat;
					_reactToValueChange = true;
				}
				else
				{
					dtp.CustomFormat = _nullFormat;
				}

				if (changed)
				{
					OnValueChanged(EventArgs.Empty);
				}
			}
		}

		[DefaultValue("dd.MM.yyyy")]
		[RefreshProperties(RefreshProperties.Repaint)]
		public string CustomFormat
		{
			get => _customFormat;
			set
			{
				if (value != null)
				{
					_customFormat = value;
					if (_value != null)
					{
						dtp.CustomFormat = value;
					}
				}
			}
		}

		protected virtual void OnValueChanged(EventArgs eventArgs)
			=> _onValueChanged?.Invoke(this, eventArgs);

		private void Dtp_ValueChanged(object sender, EventArgs e)
		{
			if (_reactToValueChange)
			{
				Value = dtp.Value;
			}
		}

		private void Dtp_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				Value = null;
			}
		}

	}
}
