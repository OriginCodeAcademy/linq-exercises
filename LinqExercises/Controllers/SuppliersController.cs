using LinqExercises.Infrastructure;
using System;
using System.Web.Http;

namespace LinqExercises.Controllers
{
    public class SuppliersController : ApiController
    {
        private NORTHWNDEntities _db;

        public SuppliersController()
        {
            _db = new NORTHWNDEntities();
        }

        [HttpGet, Route("api/suppliers/salesAndMarketing")]
        public IHttpActionResult GetSalesAndMarketing()
        {
            throw new NotImplementedException("Write a query to return all available properties in the Suppliers collection for the marketing managers and sales representatives that have a FAX number");
        }

        [HttpGet, Route("api/suppliers/search")]
        public IHttpActionResult SearchSuppliers(string term)
        {
            throw new NotImplementedException("Write a query to return all the company names, city, country and postal code from the Suppliers table containing the 'term' variable in their address. The list should ordered alphabetically by company name.");
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }
    }
}
