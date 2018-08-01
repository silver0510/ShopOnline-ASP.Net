using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framework;
using System.Data.SqlClient;

namespace Models
{
    public class AccountModel
    {
        private OnlineShopDbContext dbContext = null;
        public AccountModel()
        {
            dbContext = new OnlineShopDbContext();
        }

        public bool Login(string userName, string passWord)
        {
            var sqlParams = new SqlParameter[]
            {
                new SqlParameter("Username",userName),
                new SqlParameter("Password",passWord)
            };

            var res = dbContext.Database.SqlQuery<bool>("Sp_Account_Login @UserName, @Password", sqlParams).SingleOrDefault();
            return res;
        }
    }
}
