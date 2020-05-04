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
	public partial class NoteDialog : Form
	{
		public Note Item;
		public NoteDialog(Note item, bool isEdit)
		{
			InitializeComponent();
			if (item == null)
			{
				throw new ArgumentNullException(nameof(item));
			}
			Item = item;
			if (isEdit)
			{
				Text = "Editace poznámky";
			}
			else
			{
				Text = "Založení poznámky";
			}
		}

		private void okBtn_Click(object sender, EventArgs e)
		{
			setNote();
			Close();
		}
		
		private void NoteDialog_Load(object sender, EventArgs e)
		{
			setControls();
		}
		
		private void setControls()
		{
			dateDtp.Value = Item.Edited;
			textTB.Text = Item.Text;
		}
		
		private void setNote()
		{
			Item.Edited = dateDtp.Value;
			Item.Text = textTB.Text;
		}
	}
}
