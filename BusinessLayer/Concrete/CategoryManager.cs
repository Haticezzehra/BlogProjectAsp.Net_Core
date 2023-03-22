using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {

        ICategoryDal categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }

        public void Add(Category t)
        {
            categoryDal.Add(t);
        }

        public void Delete(Category t)
        {
            categoryDal.Delete(t);
        }

        public List<Category> GetAll()
        {
            return categoryDal.GetAll();
        }

        public Category GetById(int id)
        {
            return categoryDal.GetById(id);
        }


        public void Update(Category t)
        {
            categoryDal.Update(t);
        }
    }
}
/*
public void Add(Category category)
{

}

public void Delete(Category category)
{

}

public List<Category> GetAll()
{
    return categoryDal.GetAll();
}

public Category GetById(int id)
{
    return categoryDal.GetById(id);
}

public void Update(Category category)
{
    categoryDal.Update(category);
}*/