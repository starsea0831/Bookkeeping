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
			List<Show> shows = new List<Show>();
			shows.Add(new Show() { Kind = "支出", Date = "2017-08-01", Money = 300 });
			shows.Add(new Show() { Kind = "支出", Date = "2017-08-02", Money = 300 });
			shows.Add(new Show() { Kind = "收入", Date = "2017-08-03", Money = 500 });
			shows.Add(new Show() { Kind = "支出", Date = "2017-08-04", Money = 300 });
			shows.Add(new Show() { Kind = "支出", Date = "2017-08-05", Money = 400 });
			shows.Add(new Show() { Kind = "收入", Date = "2017-08-06", Money = 300 });
			shows.Add(new Show() { Kind = "支出", Date = "2017-08-07", Money = 700 });
			return View(shows);
		}
	}
}