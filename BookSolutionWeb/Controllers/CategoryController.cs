﻿using BookSolutionWeb.Data;
using BookSolutionWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookSolutionWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }
        
        //GET
        public IActionResult Create()
        {
           
            return View();
        }
    }
}
