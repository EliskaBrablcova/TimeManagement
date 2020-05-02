﻿using Eli.TimeManagement.Models.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Eli.TimeManagement.Repository
{
	public class TimeManagementFileRepository : ITimeManagementRepository
	{
		private string _fileName;

		public TimeManagementFileRepository(string fileName)
		{
			if (fileName == null)
			{
				throw new ArgumentNullException(nameof(fileName));
			}
			_fileName = fileName;
		}

		public void Add(Record newRecord)
		{
			var allRecords = readFromFile();
			var id = getId(allRecords);
			newRecord.ID = id;
			allRecords.Add(newRecord);
			saveToFile(allRecords);
		}

		public void Delete(int id)
		{
			var allRecords = readFromFile();
			var position = getPosition(allRecords, id);
			if (position == null)
			{
				throw new ArgumentOutOfRangeException(nameof(id));
			}
			allRecords.RemoveAt(position.Value);
			saveToFile(allRecords);
		}


		public void Edit(Record editRecord)
		{
			var allRecords = readFromFile();
			var position = getPosition(allRecords, editRecord.ID);
			if (position == null)
			{
				throw new ArgumentOutOfRangeException(nameof(editRecord));
			}
			var record = allRecords[position.Value];
			record.Start = editRecord.Start;
			record.Description = editRecord.Description;
			record.MinutesTotal = editRecord.MinutesTotal;
			record.Type = editRecord.Type;
			saveToFile(allRecords);
		}

		public IList<Record> GetAll(string type)
		{
			var AllRecords = readFromFile();
			if (type == null)
			{
				return AllRecords;
			}
			var toReturn = new List<Record>();
			for (int i = 0; i < AllRecords.Count; i++)
			{
				var record = AllRecords[i];
				if (record.Type == type)
				{
					toReturn.Add(record);
				}
			}
			return toReturn;
		}
		private List<Record> readFromFile()
		{
			//TODO toto Eli ještě neviděla
			using (var sr = new StreamReader(_fileName))
			{
				return JsonConvert.DeserializeObject<List<Record>>(sr.ReadToEnd());
			}
		}
		private void saveToFile(List<Record> records)
		{
			//TODO toto Eli ještě neviděla
			using (var sw = new StreamWriter(_fileName))
			{
				sw.Write(JsonConvert.SerializeObject(records));
			}
		}
		private int getId(List<Record> allRecords)
		{
			var id = 0;
			for (int i = 0; i < allRecords.Count; i++)
			{
				var record = allRecords[i];
				if (record.ID > id)
				{
					id = record.ID;
				}
			}
			return id + 1;
		}
		private int? getPosition(List<Record> allRecords, int id)
		{
			for (int i = 0; i < allRecords.Count; i++)
			{
				if (allRecords[i].ID == id)
				{
					return i;
				}
			}
			return null;
		}
	}
}
