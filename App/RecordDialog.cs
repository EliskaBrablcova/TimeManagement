using Eli.TimeManagement.Models.Entities;
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
	public partial class RecordDialog : Form
	{
		public Record Item;
		public RecordDialog(Record item, bool isEdit, IList<string> types)
		{
			InitializeComponent();
			if (item == null)
			{
				throw new ArgumentNullException(nameof (item));
			}
			Item = item;
			if (isEdit)
			{
				Text = "Editace záznamu";
			}
			else
			{
				Text = "Založení záznamu";
			}
			if (types != null)
			{
				for (int i = 0; i < types.Count; i++)
				{
					typeCB.Items.Add(types[i]);
				}
			}
		}
		private void setControls()
		{
			startDtp.Value = Item.Start;
			minutesNud.Value = Item.MinutesTotal;
			typeCB.Text = Item.Type;
			descriptionTB.Text = Item.Description;
		}
		private void setRecord()
		{
			Item.Start = startDtp.Value;
			Item.MinutesTotal = (int)minutesNud.Value;
			Item.Type = typeCB.Text;
			Item.Description = descriptionTB.Text;
		}

		private void RecordDialog_Load(object sender, EventArgs e)
		{
			setControls();
		}

		private void okBtn_Click(object sender, EventArgs e)
		{
			setRecord();
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
