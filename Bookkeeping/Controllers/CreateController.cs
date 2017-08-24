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
		private dbService _srv;
		public CreateController() {
			if (_srv == null) {
				_srv = new dbService();
			}
		}
		public ActionResult Index()
		{
			return View(updateviewmodel());
		}

		[HttpPost]
		public ActionResult Index(IndexViewModel model)
		{
			DateTime today = DateTime.Now;

			if (today.Ticks < model.Book.Date.Ticks)
			{
				ModelState.AddModelError("DateCompare", "日期不能大於今日");
			}

			if (ModelState.IsValid)
			{
				addNewRecord(model);
				return View(updateviewmodel());
			};
			model.Books = updateviewmodel().Books;
			return View(model);
		}

		private void addNewRecord(IndexViewModel model) {
			AccountBook acBook = new AccountBook();
			acBook.Id = Guid.NewGuid();
			acBook.Amounttt = model.Book.Money;
			acBook.Categoryyy = model.Book.Kind;
			acBook.Dateee = model.Book.Date;
			acBook.Remarkkk = model.Book.Description;
			_srv.AddAccountBook(acBook);
		}

		private IndexViewModel updateviewmodel()
		{
			List<AccountBook> acBooks = _srv.GetAccountBooks();
			List<BookViewModel> books = new List<BookViewModel>();
			foreach (var item in acBooks)
			{
				books.Add(new BookViewModel()
				{
					Date = item.Dateee,
					Description = item.Remarkkk,
					Kind = item.Categoryyy,
					Money = item.Amounttt
				});
			}
			IndexViewModel viewmodel = new IndexViewModel();
			viewmodel.Books = books;
			return viewmodel;
		}
	}
}