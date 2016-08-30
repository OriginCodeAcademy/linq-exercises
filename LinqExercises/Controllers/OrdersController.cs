using LinqExercises.Infrastructure;
using System;
using System.Linq;
using System.Web.Http;

namespace LinqExercises.Controllers
{
    public class OrdersController : ApiController
    {
        private NORTHWNDEntities _db;

        public OrdersController()
        {
            _db = new NORTHWNDEntities();
        }

        [HttpGet, Route("api/orders/between/{startDate}/{endDate}")]
        public IHttpActionResult GetOrdersBetween(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException("Write a query to return an array of orders with Customer IDs from the Orders collection with required dates between Jan 1, 1997 and Dec 31, 1997 and with freight under 100 units.");
        }

        [HttpGet, Route("api/orders/reports/purchase")]
        public IHttpActionResult PurchaseReport()
        {
            throw new NotImplementedException("Write a query to return the product id and the quantity ordered for each product labelled as 'QuantityPurchased' in the Order Details table ordered by the Quantity Purchased in descending order.");
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }
    }
}
