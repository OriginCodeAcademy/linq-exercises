using LinqExercises.Infrastructure;
using System;
using System.Web.Http;

namespace LinqExercises.Controllers
{
    public class ProductsController : ApiController
    {
        private NORTHWNDEntities _db;

        public ProductsController()
        {
            _db = new NORTHWNDEntities();
        }

        [HttpGet, Route("api/products/discontinued/count")]
        public IHttpActionResult GetDiscontinuedCount()
        {
            throw new NotImplementedException("Write a query to return a count of the number of discontinued products in the Products table.");
        }

        // GET: api/categories/Condiments/products
        [HttpGet, Route("api/categories/{categoryName}/products")]
        public IHttpActionResult GetProductsInCategory(string categoryName)
        {
            throw new NotImplementedException("Write a query to return all product names from the Products table that are in the given categoryName.");
        }

        // GET: api/products/stockReport
        [HttpGet, Route("api/products/stockReport")]
        public IHttpActionResult GetStockReport()
        {
            throw new NotImplementedException("Return a list of products from the Products table along with the total units in stock for each product. Include only products with TotalUnits greater than 100.");
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }
    }
}
