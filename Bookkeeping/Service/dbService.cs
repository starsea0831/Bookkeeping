using Bookkeeping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookkeeping.Service
{
	public class dbService
	{	
		public List<AccountBook> GetAccountBooks() {
			SkillTreeHomeworkEntities1 _dbcontext = new SkillTreeHomeworkEntities1();
			return _dbcontext.AccountBook.ToList();
		}
	}
}