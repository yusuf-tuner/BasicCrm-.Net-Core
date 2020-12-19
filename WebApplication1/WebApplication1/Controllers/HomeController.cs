using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}
		Context data = new Context();

		
		public IActionResult Index()
		{
			var values = data.Customers.ToList();
			return View(values);
		}

		[Authorize]
		[HttpGet] // sayfayı olduğu gibi dönderiyoruz.
		public IActionResult customerAdd()
		{
			return View();
		}

		[Authorize]
		[HttpPost] // ekleme gerçekleştirilirse dönderiyor.
		public IActionResult customerAdd(Customer c)
		{
			data.Customers.Add(c);
			data.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult customerUpdate(int id)
		{
			var value1 = data.Customers.Find(id);
			return View("CustomerUpdate", value1);
		}

		public IActionResult customerUpdate(Customer cs)
		{
			var x = data.Customers.Find(cs.customerID);

			x.customerName = cs.customerName;
			x.customerSurname = cs.customerSurname;
			x.customerAge = cs.customerAge;
			x.customerGender = cs.customerGender;
			x.customerAdress = cs.customerAdress;
			data.SaveChanges();

			return RedirectToAction("Index");
		}

		public IActionResult customerDetails(int id)
		{
			var value2 = data.Customers.Find(id);
			return View("CustomerDetails", value2);
		}

		public IActionResult Details()
		{
			var values = data.Customers.FromSqlRaw("customerDetails").ToList();
			return View(values);
		}

		public IActionResult customerDelete(int id)
		{
			var values = data.Customers.Find(id);
			data.Customers.Remove(values);
			data.SaveChanges();
			return RedirectToAction("Index");
		}


		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
