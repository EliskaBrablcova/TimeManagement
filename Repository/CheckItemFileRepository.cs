using Eli.TimeManagement.Models.Entities;
using Eli.TimeManagement.Models.Filtration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Eli.TimeManagement.Repository
{
	public class CheckItemFileRepository : ICheckItemRepository
	{
		private readonly string _fileName;

		public CheckItemFileRepository(string fileName)
		{
			if (fileName == null)
			{
				throw new ArgumentNullException(nameof(fileName));
			}
			_fileName = fileName;
		}

		public void Add(CheckItem newCheckItem)
		{
			var items = readFromFile();
			newCheckItem.ID = getId(items);
			items.Add(newCheckItem);
			saveToFile(items);
		}

		public void Complete(int id)
		{
			var items = readFromFile();
			var position = getPosition(items, id);
			if (position == null)
			{
				throw new ArgumentOutOfRangeException(nameof(id));
			}
			var item = items[position.Value];
			item.Completed = true;
			saveToFile(items);
		}

		public void Delete(int id)
		{
			var items = readFromFile();
			var position = getPosition(items, id);
			if (position == null)
			{
				throw new ArgumentOutOfRangeException(nameof(id));
			}
			items.RemoveAt(position.Value);
			saveToFile(items);
		}

		public void Edit(CheckItem editCheckItem)
		{
			var items = readFromFile();
			var position = getPosition(items, editCheckItem.ID);
			if (position == null)
			{
				throw new ArgumentOutOfRangeException(nameof(editCheckItem));
			}
			var item = items[position.Value];
			item.Type = editCheckItem.Type;
			item.Text = editCheckItem.Text;
			item.Completed = editCheckItem.Completed;
			saveToFile(items);
		}

		public IList<CheckItem> GetAll(Completion completion, string type)
		{
			var items = readFromFileOrdered();
			if (completion == Completion.All && type == null)
			{
				return items;
			}
			var toReturn = new List<CheckItem>();
			for (int i = 0; i < items.Count; i++)
			{
				var item = items[i];
				if ((type == null || item.Type == type) && (completion == Completion.All || (completion == Completion.Completed && item.Completed) || completion == Completion.NotCompleted && !item.Completed))
				{
					toReturn.Add(item);
				}
			}
			return toReturn;
		}
		public IList<string> GetAllTypes()
		{
			var items = readFromFile();
			var types = new List<string>();
			for (int i = 0; i < items.Count; i++)
			{
				var item = items[i];
				if (item.Type != null && !types.Contains(item.Type))
				{
					types.Add(item.Type);
				}
			}
			types.Sort();
			return types;
		}

		private List<CheckItem> readFromFileOrdered()
		{
			var items = readFromFile();
			return items.OrderBy(c => c.Type).ThenBy(c => c.Completed).ThenBy(c => c.ID).ToList();
		}
		private List<CheckItem> readFromFile()
		{
			//TODO toto Eli ještě neviděla
			using (var sr = new StreamReader(_fileName))
			{
				return JsonConvert.DeserializeObject<List<CheckItem>>(sr.ReadToEnd());
			}
		}

		private void saveToFile(List<CheckItem> items)
		{
			//TODO toto Eli ještě neviděla
			using (var sw = new StreamWriter(_fileName))
			{
				sw.Write(JsonConvert.SerializeObject(items));
			}
		}

		private int? getPosition(List<CheckItem> items, int id)
		{
			for (int i = 0; i < items.Count; i++)
			{
				var item = items[i];
				if (item.ID == id)
				{
					return i;
				}
			}
			return null;
		}

		private int getId(List<CheckItem> items)
		{
			var id = 0;
			for (int i = 0; i < items.Count; i++)
			{
				var item = items[i];
				if (item.ID > id)
				{
					id = item.ID;
				}
			}
			return id + 1;
		}
	}
}
