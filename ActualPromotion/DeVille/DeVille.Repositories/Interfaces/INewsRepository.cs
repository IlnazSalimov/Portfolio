﻿using Deville.EntityDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deville.Repositories
{
    public interface INewsRepository
    {
        IQueryable<News> GetAll();
        News GetById(int id);
        int Insert(News model);
        void Update(News model);
        void Delete(News model);
        void SaveChanges();
    }
}
