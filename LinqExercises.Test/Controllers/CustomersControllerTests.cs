using LinqExercises.Controllers;
using LinqExercises.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace LinqExercises.Test.Controllers
{
    [TestClass]
    public class CustomersControllerTests
    {
        private CustomersController _customersController;

        [TestInitialize]
        public void Initialize()
        {
            // ARRANGE
            _customersController = new CustomersController();
        }

        [TestMethod]
        public void GetAllCustomersInLondonTest()
        {
            // ACT
            IHttpActionResult actionResult = _customersController.GetAll("London");
            var contentResult = actionResult as OkNegotiatedContentResult<IQueryable<Customer>>;

            // ASSERT
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual(6, contentResult.Content.Count());
        }

        [TestMethod]
        public void GetAllCustomersInMexicoSwedenAndGermanyTest()
        {
            // ACT
            IHttpActionResult actionResult = _customersController.GetAllFromMexicoSwedenGermany();
            var contentResult = actionResult as OkNegotiatedContentResult<IQueryable<Customer>>;

            // ASSERT
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual(18, contentResult.Content.Count());
        }

        [TestMethod]
        public void GetAllCustomersThatShipWithSpeedyExpressTest()
        {
            // ACT
            IHttpActionResult actionResult = _customersController.GetCustomersThatShipWith("Speedy Express");
            var contentResult = actionResult as OkNegotiatedContentResult<IQueryable<Customer>>;

            // ASSERT
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual(78, contentResult.Content.Count());
        }

        [TestMethod]
        public void GetCustomersWithoutOrders()
        {
            // ACT
            IHttpActionResult actionResult = _customersController.GetCustomersWithoutOrders();
            var contentResult = actionResult as OkNegotiatedContentResult<IQueryable<Customer>>;

            // ASSERT
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual(2, contentResult.Content.Count());
        }
    }
}
