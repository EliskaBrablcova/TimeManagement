using Eli.TimeManagement.Models.Entities;
using Eli.TimeManagement.Models.Filtration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eli.TimeManagement.Repository
{
	public interface ICheckItemRepository
	{
		IList<CheckItem> GetAll(Completion completion, string type);
		void Add(CheckItem newCheckItem);
		void Edit(CheckItem editCheckItem);
		void Delete(int id);
		void Complete(int id);
		IList<string> GetAllTypes();
	}
}
