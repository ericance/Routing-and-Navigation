using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
//using RoutingAndNavigation.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingAndNavigation.Controllers
{
	public class HomeController : Controller
	{
		// Attribute Routes

		[Route("/")]
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult About()
		{
			return View();
		}
	}
}
