﻿using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public interface ICategoryRepository:IDisposable
    {

        IEnumerable<Category> GetAll();

        Category GetById(int categoryId);

        bool Create(Category category);

        bool Edit(Category category);

        bool DeleteById(int categoryId);

        void Saave();





    }
}
