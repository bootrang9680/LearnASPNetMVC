using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Controllers;
using System.Web.Mvc;

namespace WebApplication1.Tests.Controllers
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestIndex()
        {            
            var controller = new CalculatorController();
       
            var result = controller.Index();

            Assert.IsNotNull(result);
        }

        }
    }
}
