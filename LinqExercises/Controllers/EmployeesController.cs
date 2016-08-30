using LinqExercises.Infrastructure;
using System;
using System.Web.Http;

namespace LinqExercises.Controllers
{
    public class EmployeesController : ApiController
    {
        private NORTHWNDEntities _db;

        public EmployeesController()
        {
            _db = new NORTHWNDEntities();
        }

        [HttpGet, Route("api/employees")]
        public IHttpActionResult GetEmployees()
        {
            throw new NotImplementedException("Return all employee first and last names from the Employees table by combining the 2 columns aliased as 'DisplayName'. The combined format should be 'LastName, FirstName'");
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }
    }
}
