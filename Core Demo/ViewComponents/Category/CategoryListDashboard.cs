﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.ViewComponents.Category
{
    public class CategoryListDashboard:ViewComponent
    {

        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        {
            var values = categoryManager.GetAll();
            return View(values);
        }
    }
}
