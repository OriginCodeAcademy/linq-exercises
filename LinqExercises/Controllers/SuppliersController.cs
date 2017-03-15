﻿using LinqExercises.Infrastructure;
using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;

namespace LinqExercises.Controllers
{
    public class SuppliersController : ApiController
    {
        private NORTHWNDEntities _db;

        public SuppliersController()
        {
            _db = new NORTHWNDEntities();
        }

        //GET: api/suppliers/salesAndMarketing
        [HttpGet, Route("api/suppliers/salesAndMarketing"), ResponseType(typeof(IQueryable<Supplier>))]
        public IHttpActionResult GetSalesAndMarketing()
        {
            //throw new NotImplementedException("Write a query to return all Suppliers that are marketing managers or sales representatives that have a fax number");
            var resultSet = _db.Suppliers.Where(s => (s.ContactTitle == "Marketing Manager" || s.ContactTitle == "Sales Representative") && s.Fax != null);
            return Ok(resultSet);
        }

        //GET: api/suppliers/search
        [HttpGet, Route("api/suppliers/search"), ResponseType(typeof(IQueryable<Supplier>))]
        public IHttpActionResult SearchSuppliers(string term)
        {
            //throw new NotImplementedException("Write a query to return all Suppliers containing the 'term' variable in their address. The list should ordered alphabetically by company name.");
            var resultSet = _db.Suppliers.Where(s => s.Address.Contains(term));

            return Ok(resultSet);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }
    }
}
