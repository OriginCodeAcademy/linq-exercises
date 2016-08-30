using LinqExercises.Infrastructure;
using System;
using System.Web.Http;

namespace LinqExercises.Controllers
{
    public class ShippersController : ApiController
    {
        private NORTHWNDEntities _db;

        public ShippersController()
        {
            _db = new NORTHWNDEntities();
        }

        [HttpGet, Route("/api/shippers/freightReport")]
        public IHttpActionResult GetFreightReport()
        {
            throw new NotImplementedException("Return a complete list of company names from the Shippers table. Include freight totals rounded to the nearest whole number for each shipper from the Orders table for those shippers with orders.");
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }
    }
}
