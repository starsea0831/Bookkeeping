using Bookkeeping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookkeeping.Service;

namespace Bookkeeping.Controllers
{
	public class CreateController : Controller
	{
		// GET: Create
		public ActionResult Index()
		{
			dbService srv =new dbService();
			List<AccountBook> AcBook = srv.GetAccountBooks();
			List<ShowViewModels> shows = new List<ShowViewModels>();
			foreach (var accountBook in AcBook)
			{
				shows.Add(new ShowViewModels()
				{
					Kind = accountBook.Categoryyy == 0 ? "收入" : "支出",
					Date = accountBook.Dateee,
					Money = accountBook.Amounttt
				}
				);
			}

			return View(shows);
		}
	}
}