﻿using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class ICategoryRepository : Repository<Category>, ICategoryRepository<Category>
    {
        public ICategoryRepository()
        {
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
