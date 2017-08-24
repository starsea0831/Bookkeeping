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
		
		public int Kind { get; set; }	
		
		public DateTime Date { get; set; }
		[Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
		public int Money { get; set; }
		[StringLength(100, ErrorMessage = "備註最多輸入100個字元")]
		public string Description { get; set; }
	}	
}