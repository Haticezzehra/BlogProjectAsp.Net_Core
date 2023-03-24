using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            this.writerDal = writerDal;
        }

        public void Add(Writer t)
        {
            writerDal.Add(t);
        }

        public void Delete(Writer t)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Writer GetById(int id)
        {
            return writerDal.GetById(id);
        }

        public List<Writer> GetWriterById(int id)
        {
            return writerDal.GetAll(x => x.WriterID == id);
        }

        public void Update(Writer t)
        {
           writerDal.Update(t);
        }
    }
}
