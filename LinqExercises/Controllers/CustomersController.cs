using LinqExercises.Infrastructure;
using System;
using System.Web.Http;

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
        [HttpGet, Route("api/customers/city/{city}")]
        public IHttpActionResult GetAll(string city)
        {
            throw new NotImplementedException("Write a query to return the contact name, customer id, company name and city name of all Customers in the given city");
        }

        // GET: api/customers/mexicoSwedenGermany
        [HttpGet, Route("api/customers/mexicoSwedenGermany")]
        public IHttpActionResult GetAllFromMexicoSwedenGermany()
        {
            throw new NotImplementedException("Write a query to return a list of company names and contact names of all customers from Mexico, Sweden and Germany.");
        }

        // GET: api/customers/shippedUsing/Speedy Express
        [HttpGet, Route("api/customers/shippedUsing/{shipperName}")]
        public IHttpActionResult GetCustomersThatShipWith(string shipperName)
        {
            throw new NotImplementedException("Write a query to return the company name, address, city, postal code and country of all customers with orders that shipped using the given shipperName.");
        }

        // GET: api/customers/withoutOrders
        [HttpGet, Route("api/customers/withoutOrders")]
        public IHttpActionResult GetCustomersWithoutOrders()
        {
            throw new NotImplementedException("Write a query to return a list of customers who have no orders in the Orders table.");
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }
    }
}
