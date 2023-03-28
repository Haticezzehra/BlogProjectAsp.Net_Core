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
    public class Message2Manager : IMessage2Service
    {
        IMessage2Dal messageDal;

        public Message2Manager(IMessage2Dal messageDal)
        {
            this.messageDal = messageDal;
        }
        public void Add(Message2 t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Message2 t)
        {
            throw new NotImplementedException();
        }

        public List<Message2> GetAll()
        {
            return messageDal.GetAll();
        }

        public Message2 GetById(int id)
        {
            return messageDal.GetById(id);
        }

        public List<Message2> GetInboxListByWritter(int id)
        {
            return messageDal.GetListWithMessageByWriter(id);

        }

        public List<Message2> GetInboxListByWritter(string p)
        {
            throw new NotImplementedException();
        }

        public void Update(Message2 t)
        {
            throw new NotImplementedException();
        }
    }
}
