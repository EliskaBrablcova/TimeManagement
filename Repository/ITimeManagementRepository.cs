using Eli.TimeManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eli.TimeManagement.Repository
{
	public interface ITimeManagementRepository
	{
		IList<Record> GetAll(string type, DateTime? dateFrom, DateTime? dateTo);
		void Add(Record newRecord);
		void Edit(Record editRecord);
		void Delete(int id);
		IList<string> GetAllTypes();
	}
}
