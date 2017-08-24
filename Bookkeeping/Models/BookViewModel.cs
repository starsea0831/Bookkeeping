using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookkeeping.Models
{
	public class BookViewModel
	{
		[Required]
		public int Kind { get; set; }		
		public DateTime Date { get; set; }
		[Required]
		public int Money { get; set; }

		public string Description { get; set; }
	}	
}