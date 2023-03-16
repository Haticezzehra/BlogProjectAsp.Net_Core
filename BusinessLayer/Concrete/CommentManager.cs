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
    public class CommentManager : ICommentService
    {
        ICommentDal commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            this.commentDal = commentDal;
        }

        public void Add(Comment comment)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetAll(int id)
        {
            return commentDal.GetAll(x => x.CommentID == id);
        }


    }
}
