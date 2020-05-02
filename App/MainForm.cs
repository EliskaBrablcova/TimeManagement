using Eli.TimeManagement.Models.Entities;
using Eli.TimeManagement.Repository;
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
	public partial class MainForm : Form
	{
		private ITimeManagementRepository _repo;
		private IList<Record> _records;
		public MainForm()
		{
			InitializeComponent();
			_repo = new TimeManagementFileRepository("data.json");
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			reload();
		}
		private void reload()
		{
			var records = _repo.GetAll(null);
			_records = records;
			display(records);
			setButtonStates();
		}
		private void display(IList<Record> records)
		{
			dataLv.Items.Clear();
			for (int i = 0; i < records.Count; i++)
			{
				addRow(records[i]);
			}
		}

		private void addRow(Record record)
		{
			var texts = new string[] { record.Start.Date.ToShortDateString(), record.MinutesTotal.ToString(), record.Type, record.Description };
			var item = new ListViewItem(texts);
			dataLv.Items.Add(item);
		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			deleteRecord();
		}

		private void dataLv_SelectedIndexChanged(object sender, EventArgs e)
		{
			setButtonStates();
		}
		private void setButtonStates()
		{
			var selected = dataLv.SelectedIndices;
			if (selected.Count == 1)
			{
				setButtonStates(true);
			}
			else
			{
				setButtonStates(false);
			}
			//Altertativa:
			//setButtonStates(selected.Count == 1);
		}
		private void setButtonStates(bool enabled)
		{
			deleteBtn.Enabled = enabled;
			editBtn.Enabled = enabled;
		}

		private void createBtn_Click(object sender, EventArgs e)
		{
			var record = new Record();
			var dialog = new RecordDialog(record, false, _repo.GetAllTypes());
			var result = dialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				_repo.Add(dialog.Item);
				reload();
			}
		}

		private void editBtn_Click(object sender, EventArgs e)
		{
			var selected = dataLv.SelectedIndices;
			if (selected.Count == 1)
			{
				var selectedIndex = selected[0];
				var record = _records[selectedIndex];

				var dialog = new RecordDialog(record, true, _repo.GetAllTypes());
				var result = dialog.ShowDialog();
				if (result == DialogResult.OK)
				{
					_repo.Edit(dialog.Item);
					reload();
				}

			}
		}

		private void dataLv_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				deleteRecord();
			}
		}
		private void deleteRecord()
		{
			setButtonStates(false);
			var selected = dataLv.SelectedIndices;
			if (selected.Count == 1)
			{
				var result = MessageBox.Show("Opravdu chcete smazat záznam?", "Varování", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					var selectedIndex = selected[0];
					var id = _records[selectedIndex].ID;
					_repo.Delete(id);
					reload();
				}
			}
			setButtonStates();
		}
	}
}
