using Eli.TimeManagement.Models.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Eli.TimeManagement.Repository
{
	public class NoteFileRepository : INoteRepository
	{
		private string _fileName;

		public NoteFileRepository(string fileName)
		{
			if (fileName == null)
			{
				throw new ArgumentNullException(nameof(fileName));
			}
			_fileName = fileName;
		}

		public void Add(Note newNote)
		{
			var notes = readFromFile();
			newNote.ID = getId(notes);
			notes.Add(newNote);
			saveToFile(notes);
		}


		public void Delete(int id)
		{
			var notes = readFromFile();
			var position = getPosition(notes, id);
			if (position == null)
			{
				throw new ArgumentOutOfRangeException(nameof (id));
			}
			notes.RemoveAt(position.Value);
			saveToFile(notes);
		}

		public void Edit(Note editNote)
		{
			var notes = readFromFile();
			var position = getPosition(notes, editNote.ID);
			if (position == null)
			{
				throw new ArgumentOutOfRangeException(nameof(editNote));
			}
			var note = notes[position.Value];
			note.Edited = editNote.Edited;
			note.Text = editNote.Text;
			saveToFile(notes);
		}

		public IList<Note> GetAll(DateTime? dateFrom, DateTime? dateTo)
		{
			var notes = readFromFile();
			if (dateFrom == null && dateTo == null)
			{
				return notes;
			}
			var toReturn = new List<Note>();
			for (int i = 0; i < notes.Count; i++)
			{
				var note = notes[i];
				if ((dateFrom == null || note.Edited.Date >= dateFrom) && (dateTo == null || note.Edited.Date <= dateTo))
				{
					toReturn.Add(note);
				}
			}
			return toReturn;
		}
		private List<Note> readFromFile()
		{
			//TODO toto Eli ještě neviděla
			using (var sr = new StreamReader(_fileName))
			{
				return JsonConvert.DeserializeObject<List<Note>>(sr.ReadToEnd());
			}
		}
		private void saveToFile(List<Note> notes)
		{
			//TODO toto Eli ještě neviděla
			using (var sw = new StreamWriter(_fileName))
			{
				sw.Write(JsonConvert.SerializeObject(notes));
			}
		}
		private int? getPosition(List<Note> notes, int id)
		{
			for (int i = 0; i < notes.Count; i++)
			{
				var note = notes[i];
				if (note.ID == id)
				{
					return i;
				}
			}
			return null;
		}
		private int getId(List<Note> notes)
		{
			var id = 0;
			for (int i = 0; i < notes.Count; i++)
			{
				var note = notes[i];
				if (note.ID > id)
				{
					id = note.ID;
				}
			}
			//alternativa
			//foreach (var note in notes)
			//{
			//	if (note.ID > id)
			//	{
			//		id = note.ID;
			//	}
			//}
			return id + 1;
		}

	}
}
