﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(b => b.Category).ToList();
            }
        }

        public List<Blog> GetListWithCategoryByWriter(int id)
        {

            using (var c = new Context())
            {
                return c.Blogs.Include(b => b.Category).Where(b => b.WriterID == id).ToList();
            }
        }
    }
}
