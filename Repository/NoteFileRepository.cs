﻿using Eli.TimeManagement.Models.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

		public IList<Note> GetAll(DateTime? dateFrom, DateTime? dateTo, string contains)
		{
			var notes = readFromFileOrdered();
			if (dateFrom == null && dateTo == null)
			{
				return notes;
			}
			var toReturn = new List<Note>();
			for (int i = 0; i < notes.Count; i++)
			{
				var note = notes[i];
				if (matchDateFrom(dateFrom, note) && matchDateTo(dateTo, note) && matchFulltext(contains, note))
				{
					toReturn.Add(note);
				}
			}
			return toReturn;
		}

		private List<Note> readFromFileOrdered()
		{
			var notes = readFromFile();
			return notes.OrderByDescending(c => c.Edited).ThenBy(c => c.ID).ToList();
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

		private bool matchDateFrom(DateTime? dateFrom, Note note)
		{
			return dateFrom == null || note.Edited >= dateFrom;
		}

		private bool matchDateTo(DateTime? dateTo, Note note)
		{
			return dateTo == null || note.Edited <= dateTo;
		}

		// ?? == coalesce
		private bool matchFulltext(string contains, Note note)
		{
			return contains == null || (note.Text?.ToLowerInvariant().Contains(contains.ToLowerInvariant()) ?? false);
		}

	}
}
