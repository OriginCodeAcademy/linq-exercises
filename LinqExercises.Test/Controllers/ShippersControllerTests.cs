using LinqExercises.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace LinqExercises.Test.Controllers
{
    [TestClass]
    public class ShippersControllerTests
    {
        private ShippersController _shippersController;

        [TestInitialize]
        public void Initialize()
        {
            // ARRANGE
            _shippersController = new ShippersController();
        }

        [TestMethod]
        public void GetFreightReportTest()
        {
            // ACT
            dynamic contentResult = _shippersController.GetFreightReport();

            var list = ((IEnumerable<dynamic>)contentResult.Content).ToList();

            // ASSERT
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual(3, list.Count);
        }
    }
}
