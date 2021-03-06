﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions.Dal.Interface
{
    public interface IQueryRepositoryBase<T> where T : new()
    {
        Task<T> Read(long id);
        Task<IEnumerable<T>> ReadAllAsync();
    }
}
