using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal newsLetterDal;

        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            this.newsLetterDal = newsLetterDal;
        }

        public void Add(NewsLetter t)
        {
            newsLetterDal.Add(t);
        }

        public void Delete(NewsLetter t)
        {
            throw new NotImplementedException();
        }

        public List<NewsLetter> GetAll()
        {
            throw new NotImplementedException();
        }

        public NewsLetter GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(NewsLetter t)
        {
            throw new NotImplementedException();
        }
    }
}
