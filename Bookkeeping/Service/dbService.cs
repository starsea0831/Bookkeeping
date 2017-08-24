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

		public void AddAccountBook(AccountBook entity) {
			SkillTreeHomeworkEntities1 _dbcontext = new SkillTreeHomeworkEntities1();
			_dbcontext.AccountBook.Add(entity);
			_dbcontext.SaveChanges();
		}
	}
}