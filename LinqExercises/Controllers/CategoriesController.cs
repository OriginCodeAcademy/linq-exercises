using LinqExercises.Infrastructure;
using System;
using System.Collections.Generic;
using System.Web.Http;

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
        [HttpGet, Route("api/categories")]
        public IHttpActionResult GetAll()
        {
            throw new NotImplementedException("Write a query to return all category names with their descriptions");
        }

        //GET: /api/categories/search?term={term}
        [HttpGet, Route("api/categories/search")]
        public IHttpActionResult Search(string term)
        {
            throw new NotImplementedException("Write a query to return all category names with their descriptions where the category name contains the search term.");
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }
    }
}
