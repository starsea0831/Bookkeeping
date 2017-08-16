using Bookkeeping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookkeeping.Controllers
{
	public class CreateController : Controller
	{
		// GET: Create
		public ActionResult Index()
		{
			List<ShowViewModels> shows = new List<ShowViewModels>();
			shows.Add(new ShowViewModels() { Kind = "支出", Date = new DateTime(2017, 8, 1), Money = 300 });
			shows.Add(new ShowViewModels() { Kind = "支出", Date = new DateTime(2017, 8, 2), Money = 300 });
			shows.Add(new ShowViewModels() { Kind = "收入", Date = new DateTime(2017, 8, 3), Money = 500 });
			shows.Add(new ShowViewModels() { Kind = "支出", Date = new DateTime(2017, 8, 4), Money = 300 });
			shows.Add(new ShowViewModels() { Kind = "支出", Date = new DateTime(2017, 8, 5), Money = 400 });
			shows.Add(new ShowViewModels() { Kind = "收入", Date = new DateTime(2017, 8, 6), Money = 300 });
			shows.Add(new ShowViewModels() { Kind = "支出", Date = new DateTime(2017, 8, 7), Money = 700 });
			return View(shows);
		}
	}
}