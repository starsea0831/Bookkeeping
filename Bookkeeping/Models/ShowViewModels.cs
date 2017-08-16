using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Bookkeeping.Models
{
	public class ShowViewModels
	{		
		public string Kind { get; set; }		
		public DateTime Date { get; set; }		
		public int Money { get; set; }
	}
}