using Eli.TimeManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eli.TimeManagement.Repository
{
	public interface INoteRepository
	{
		IList<Note> GetAll(DateTime? dateFrom, DateTime? dateTo, string contains);
		void Add(Note newNote);
		void Edit(Note editNote);
		void Delete(int id);
	}
}
