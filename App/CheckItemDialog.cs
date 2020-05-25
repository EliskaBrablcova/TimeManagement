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
	public partial class CheckItemDialog : Form
	{
		private CheckItem _item;
		public CheckItem Item 
		{
			get
			{
				return _item;
			}
			set
			{
				if (value == null)
				{
					throw new NullReferenceException(nameof(Item));
				}
				_item = value;
			} 
		}

		public CheckItemDialog(CheckItem item, bool isEdit)
		{
			InitializeComponent();
			if (item == null)
			{
				throw new NullReferenceException(nameof(item));
			}
			_item = item;
			if (isEdit)
			{
				Text = "Editace úkolu";
			}
			else
			{
				Text = "Založení úkolu";
			}
		}
		private void okBtn_Click(object sender, EventArgs e)
		{
			setItem();
			DialogResult = DialogResult.OK;
			Close();
		}

		private void CheckItemDialog_Load(object sender, EventArgs e)
		{
			setControls();
		}

		private void setControls()
		{
			checkItemTextTB.Text = Item.Text;
			checkItemCompletedCB.Checked = Item.Completed;
			checkItemTypeCB.Text = Item.Text;
		}

		private void setItem()
		{
			Item.Text = checkItemTextTB.Text;
			Item.Completed = checkItemCompletedCB.Checked;
			Item.Text = checkItemTypeCB.Text;
		}
	}
}
