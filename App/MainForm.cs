using Eli.TimeManagement.App.Properties;
using Eli.TimeManagement.Models.Entities;
using Eli.TimeManagement.Models.Stats;
using Eli.TimeManagement.Models.ViewModels;
using Eli.TimeManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eli.TimeManagement.App
{
	public partial class MainForm : Form
	{
		private ITimeManagementRepository _repo;
		private INoteRepository _noteRepo;
		private ICheckItemRepository _checkItemRepo;
		private IList<Record> _records;
		private IList<Note> _notes;
		private IList<CheckItem> _checkItems;
		private bool _activeFiltration;
		private bool _reloadStop;
		public MainForm()
		{
			InitializeComponent();
			_repo = new TimeManagementFileRepository("data\\data.json");
			_noteRepo = new NoteFileRepository("data\\notes.json");
			_checkItemRepo = new CheckItemFileRepository("data\\checklist.json");
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			reload();
		}
		private void reload()
		{
			var records = getRecords();
			var notes = getNotes();
			var items = getCheckItems();
			var types = _repo.GetAllTypes();
			_records = records;
			_notes = notes;
			_checkItems = items;
			display(records);
			display(notes);
			display(items, _checkItemRepo.GetAllTypes());
			setRecordButtonStates();
			setNotesButtonStates();
			setCheckItemsButtonStates();
			setFiltrationTypes(types);
		}

		private IList<Record> getRecords()
		{
			var dateFrom = getDateFrom();
			var dateTo = getDateTo();
			var type = getType();
			return _repo.GetAll(type, dateFrom, dateTo);
		}

		private IList<Note> getNotes()
		{
			var dateFrom = getDateFrom();
			var dateTo = getDateTo();
			return _noteRepo.GetAll(dateFrom, dateTo);
		}

		private IList<CheckItem> getCheckItems()
		{
			return _checkItemRepo.GetAll(false);
		}

		private DateTime? getDateFrom()
		{
			return _activeFiltration
				? dateFromDtp.Value.Date
				: (DateTime?)null;
		}

		private DateTime? getDateTo()
		{
			return _activeFiltration
				? dateToDtp.Value.Date
				: (DateTime?)null;
		}

		private string getType()
		{
			var type = _activeFiltration
				? typeCb.Text
				: null;
			if (type == "")
			{
				type = null;
			}
			return type;
		}
		private void display(IList<Record> records)
		{
			recordsLv.Items.Clear();
			for (int i = 0; i < records.Count; i++)
			{
				addRow(records[i]);
			}
		}

		private void display(IList<Note> notes)
		{
			notesLv.Items.Clear();
			for (int i = 0; i < notes.Count; i++)
			{
				addRow(notes[i]);
			}
		}

		private void display(IList<CheckItem> items, IList<string> types)
		{
			checklistLv.Items.Clear();
			checklistLv.Groups.Clear();
			foreach (var type in types)
			{
				checklistLv.Groups.Add(type, type);
			}
			for (int i = 0; i < items.Count; i++)
			{
				addRow(items[i]);
			}
		}

		private void addRow(Record record)
		{
			var texts = new string[] { record.Start.Date.ToShortDateString(), record.MinutesTotal.ToString(), record.Type, record.Description };
			var item = new ListViewItem(texts);
			recordsLv.Items.Add(item);
		}

		private void addRow(Note note)
		{
			var texts = new string[] { note.Edited.ToString(), note.Text.Replace("\r\n", " ") };
			var item = new ListViewItem(texts);
			notesLv.Items.Add(item);
		}

		private void addRow(CheckItem checkItem)
		{
			var texts = new string[] { checkItem.Text.Replace("\r\n", " ") };
			var item = new ListViewItem(texts);
			item.Group = checklistLv.Groups[checkItem.Type];
			item.StateImageIndex = checkItem.Completed ? 1 : 0;
			checklistLv.Items.Add(item);
		}

		private void deleteRecordBtn_Click(object sender, EventArgs e)
		{
			deleteRecord();
		}

		private void recordsLv_SelectedIndexChanged(object sender, EventArgs e)
		{
			setRecordButtonStates();
		}
		private void setRecordButtonStates()
		{
			var selected = recordsLv.SelectedIndices;
			if (selected.Count == 1)
			{
				setRecordButtonStates(true);
			}
			else
			{
				setRecordButtonStates(false);
			}
			//Altertativa:
			//setButtonStates(selected.Count == 1);
		}

		private void setNotesButtonStates()
		{
			var selected = notesLv.SelectedIndices;
			if (selected.Count == 1)
			{
				setNotesButtonStates(true);
			}
			else
			{
				setNotesButtonStates(false);
			}
		}

		private void setCheckItemsButtonStates()
		{
			var selected = checklistLv.SelectedIndices;
			if (selected.Count == 1)
			{
				setCheckItemsButtonStates(true);
			}
			else
			{
				setCheckItemsButtonStates(false);
			}
		}


		private void setRecordButtonStates(bool enabled)
		{
			deleteRecordBtn.Enabled = enabled;
			editRecordBtn.Enabled = enabled;
		}

		private void setNotesButtonStates(bool enabled)
		{
			deleteNoteBtn.Enabled = enabled;
			editNoteBtn.Enabled = enabled;
		}

		private void setCheckItemsButtonStates(bool enabled)
		{
			deleteCheckItemBtn.Enabled = enabled;
			editCheckItemBtn.Enabled = enabled;
		}

		private void createRecordBtn_Click(object sender, EventArgs e)
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

		private void editRecordBtn_Click(object sender, EventArgs e)
		{
			var selected = recordsLv.SelectedIndices;
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

		private void recordLv_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				deleteRecord();
			}
		}
		private void deleteRecord()
		{
			setRecordButtonStates(false);
			var selected = recordsLv.SelectedIndices;
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
			setRecordButtonStates();
		}

		private void createNoteBtn_Click(object sender, EventArgs e)
		{
			var dialog = new NoteDialog(new Note(), false);
			var result = dialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				_noteRepo.Add(dialog.Item);
				reload();
			}
		}

		private void editNoteBtn_Click(object sender, EventArgs e)
		{
			var selected = notesLv.SelectedIndices;
			if (selected.Count == 1)
			{
				var selectedIndex = selected[0];
				var note = _notes[selectedIndex];

				var dialog = new NoteDialog(note, true);
				var result = dialog.ShowDialog();
				if (result == DialogResult.OK)
				{
					_noteRepo.Edit(dialog.Item);
					reload();
				}
			}
		}

		private void deleteNoteBtn_Click(object sender, EventArgs e)
		{
			deleteNote();
		}

		private void notesLv_SelectedIndexChanged(object sender, EventArgs e)
		{
			setNotesButtonStates();
		}
		private void deleteNote()
		{
			setNotesButtonStates(false);
			var selected = notesLv.SelectedIndices;
			if (selected.Count == 1)
			{
				var result = MessageBox.Show("Opravdu chcete poznámku smazat?", "Varování", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					var selectedIndex = selected[0];
					var id = _notes[selectedIndex].ID;
					_noteRepo.Delete(id);
					reload();
				}
			}
			setNotesButtonStates();
		}

		private void notesLv_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				deleteNote();
			}
		}

		private void setFiltrationTypes(IList<string> types)
		{
			_reloadStop = true;
			var originalValue = typeCb.Text;
			typeCb.Items.Clear();
			for (int i = 0; i < types.Count; i++)
			{
				typeCb.Items.Add(types[i]);
			}
			typeCb.Text = originalValue;
			_reloadStop = false;
		}

		private void filtrationBtn_Click(object sender, EventArgs e)
		{
			_activeFiltration = !_activeFiltration;
			if (_activeFiltration)
			{
				filtrationBtn.Text = "Zrušit filtrování";
			}
			else
			{
				filtrationBtn.Text = "Filtrování";
			}
			reload();
		}

		private void dateFromDtp_ValueChanged(object sender, EventArgs e)
		{
			if (_activeFiltration)
			{
				reload();
			}
		}

		private void dateToDtp_ValueChanged(object sender, EventArgs e)
		{
			if (_activeFiltration)
			{
				reload();
			}
		}

		private void typeCb_TextChanged(object sender, EventArgs e)
		{
			if (_activeFiltration && !_reloadStop)
			{
				reload();
			}
		}

		private void mainTc_SelectedIndexChanged(object sender, EventArgs e)
		{
			typeCb.Enabled = mainTc.SelectedIndex == 0;
		}

		private void statisticsBtn_Click(object sender, EventArgs e)
		{
			var statsCounter = new StatisticsCounter();
			var stats = statsCounter.Count(getRecords(), getDateFrom(), getDateTo());
			var dialogue = new StatisticsForm(stats);
			dialogue.ShowDialog();
		}

		private void createCheckItemBtn_Click(object sender, EventArgs e)
		{
			var dialog = new CheckItemDialog(new CheckItem(), false, _checkItemRepo.GetAllTypes());
			var result = dialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				_checkItemRepo.Add(dialog.Item);
				reload();
			}
		}

		private void editCheckItemBtn_Click(object sender, EventArgs e)
		{
			var selected = checklistLv.SelectedIndices;
			if (selected.Count == 1)
			{
				var selectedIndex = selected[0];
				var checkItem = _checkItems[selectedIndex];

				var dialog = new CheckItemDialog(checkItem, true, _checkItemRepo.GetAllTypes());
				var result = dialog.ShowDialog();
				if (result == DialogResult.OK)
				{
					_checkItemRepo.Edit(dialog.Item);
					reload();
				}
			}
		}

		private void deleteCheckItemBtn_Click(object sender, EventArgs e)
		{
			deleteCheckItem();
		}

		private void completeCheckItemBtn_Click(object sender, EventArgs e)
		{

		}
		private void deleteCheckItem()
		{
			setCheckItemsButtonStates(false);
			var selected = checklistLv.SelectedIndices;
			if (selected.Count == 1)
			{
				var result = MessageBox.Show("Opravdu chcete smazat úkol?", "Varování", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					var selectedIndex = selected[0];
					var id = _checkItems[selectedIndex].ID;
					_checkItemRepo.Delete(id);
					reload();
				}
			}
			setCheckItemsButtonStates();
		}

		private void checklistLv_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				deleteCheckItem();
			}
		}

		private void checklistLv_SelectedIndexChanged(object sender, EventArgs e)
		{
			setCheckItemsButtonStates();
		}
	}
}
