using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookkeeping.Models
{
	public class IndexViewModel
	{
		public BookViewModel Book { get; set; }

		public List<BookViewModel> Books { get; set; }

	}

	//public enum MyCategory {
	//	[Display(Name = "支出")]
	//	Expend,
	//	[Display(Name = "收入")]
	//	InCome
	//}
}