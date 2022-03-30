﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Business.Abstract
{
    public interface IBlogManager
    {
        List<Blog> GetAll();
        void Create(Blog blog);
        Blog GetById(int? id);
        void Update(Blog blog);
        string SeoURL(string link);
    }
}
