﻿using LinqExercises.Infrastructure;
using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;

namespace LinqExercises.Controllers
{
    public class CategoriesController : ApiController
    {
        private NORTHWNDEntities _db;

        public CategoriesController()
        {
            _db = new NORTHWNDEntities();
        }

        //GET: /api/categories
        [HttpGet, Route("api/categories"), ResponseType(typeof(IQueryable<Category>))]
        public IHttpActionResult GetAll()
        {
            //throw new NotImplementedException("Write a query to return all categories");
            var resultSet = _db.Categories;

            return Ok(resultSet);
        }

        //GET: /api/categories/search?term={term}
        [HttpGet, Route("api/categories/search"), ResponseType(typeof(IQueryable<Category>))]
        public IHttpActionResult Search(string term)
        {
            //throw new NotImplementedException("Write a query to return all categories where the category name contains the search term.");
            var resultSet = _db.Categories.Where(c => c.CategoryName.Contains(term));

            return Ok(resultSet);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }
    }
}
