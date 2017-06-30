using LinqExercises.Infrastructure;
using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;

namespace LinqExercises.Controllers
{
    public class CustomersController : ApiController
    {
        private NORTHWNDEntities _db;

        public CustomersController()
        {
            _db = new NORTHWNDEntities();
        }

        // GET: api/customers/city/London
        [HttpGet, Route("api/customers/city/{city}"), ResponseType(typeof(IQueryable<Customer>))]
        public IHttpActionResult GetAll(string city)
        {
            //throw new NotImplementedException("Write a query to return all customers in the given city");

            var resultSet = _db.Customers.Where(c => c.City == city);

            return Ok(resultSet);
        }

        // GET: api/customers/mexicoSwedenGermany
        [HttpGet, Route("api/customers/mexicoSwedenGermany"), ResponseType(typeof(IQueryable<Customer>))]
        public IHttpActionResult GetAllFromMexicoSwedenGermany()
        {
            //throw new NotImplementedException("Write a query to return all customers from Mexico, Sweden and Germany.");

            var resultSet = _db.Customers.Where(c => c.Country == "Mexico" || c.Country == "Sweden" || c.Country == "Germany");

            return Ok(resultSet);
        }

        // GET: api/customers/shippedUsing/Speedy Express
        [HttpGet, Route("api/customers/shippedUsing/{shipperName}"), ResponseType(typeof(IQueryable<Customer>))]
        public IHttpActionResult GetCustomersThatShipWith(string shipperName)
        {
            //throw new NotImplementedException("Write a query to return all customers with orders that shipped using the given shipperName.");
            var resultSet = _db.Customers.Where(c => c.Orders.Any(o => o.Shipper.CompanyName == shipperName));

            return Ok(resultSet);
        }

        // GET: api/customers/withoutOrders
        [HttpGet, Route("api/customers/withoutOrders"), ResponseType(typeof(IQueryable<Customer>))]
        public IHttpActionResult GetCustomersWithoutOrders()
        {
            //throw new NotImplementedException("Write a query to return all customers with no orders in the Orders table.");
            var resultSet = _db.Customers.Where(c => !c.Orders.Any());

            return Ok(resultSet);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }
    }
}
