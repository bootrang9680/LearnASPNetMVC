using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class CalculatorController : Controller
    {
        //
        // GET: /Calculator/
        public ActionResult Index()
        {
            return View();

        }

        public string ShowAuthor()
        {
            return "Trang Boo";
        }

        public double Factorial(int id)
        {
            int n = id;
            double F = 1;
            for (int i = 1; i <= n; i++) 
            {
                F = F * i;
            }
                return F;
        }
        public int Sum(int a, int b)
        {
           return a + b;
        }
	}
}