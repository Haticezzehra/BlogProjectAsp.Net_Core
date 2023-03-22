﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {

        IBlogDal blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            this.blogDal = blogDal;
        }

        public void Add(Blog blog)
        {
           blogDal.Add(blog);
        }

        public void Delete(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAll()
        {
            return blogDal.GetAll();
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return blogDal.GetListWithCategory();
        }
        public List<Blog> GetLast3Blog()
        {
            return blogDal.GetAll().Take(3).ToList();
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogById(int id)
        {
            return blogDal.GetAll(x => x.BlogID == id);
        }
        public void Update(Blog blog)
        {

        }

        public List<Blog> GetBlogListByWriter(int id)
        {

            return blogDal.GetAll(w => w.WriterID == id);
        }

    }
}
