﻿using Eli.TimeManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eli.TimeManagement.Repository
{
	public interface INoteRepository
	{
		IList<Note> GetAll();
		void Add(Note newNote);
		void Edit(Note editNote);
		void Delete(int id);
	}
}