using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TKB.Models;

namespace TKB.Dao
{
    public class AccountDao
    {
        TimeTableDbContext db = null;
        public AccountDao()
        {
            db = new TimeTableDbContext();
        }
        public Account GetAccountByUserName(string userName)
        {
            return db.Accounts.SingleOrDefault(x => x.UserName == userName);
        }
        public bool Login(string userName,string passWord)
        {
            var result = db.Accounts.Count(x => x.UserName == userName && x.PassWord == passWord);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}