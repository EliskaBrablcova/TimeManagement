using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eli.TimeManagement.FormsLibrary
{
	public partial class CustomMessageBox : Form
	{
		public CustomMessageBox()
		{
			InitializeComponent();
			Text = "";
			textLbl.Text = "";
		}

		public CustomMessageBox(string caption, string text)
			:this()
		{
			Text = caption;
			textLbl.Text = text;
		}

		public CustomMessageBox(string text)
			:this("", text)
		{

		}

		public CustomMessageBox SetOkBtnText(string text)
		{
			okBtn.Text = text;
			return this;
		}

		public CustomMessageBox SetCancelBtnText(string text)
		{
			cancelBtn.Text = text;
			return this;
		}

		private void okBtn_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Yes;
			Close();
		}
	}
}
