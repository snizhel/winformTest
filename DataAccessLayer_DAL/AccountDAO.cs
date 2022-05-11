using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public class AccountDAO :GeneralDAO
    {
        public List<Account> getAllAccounts()
        {
            List<Account> lst = new List<Account>();

            DataSet ds = getAll("Account");
            DataTable dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows) {
                Account acc = new Account()
                {
                    Ssn = dr["ssn"].ToString(),
                    UserName = dr["userName"].ToString(),
                    Password = dr["Password"].ToString(),
                    Role = dr["role"].ToString()
                };
                lst.Add(acc);
            }

            return lst;

        }
            public Account getAccountDetails(string ssn) {
            Account account = null;
            try {
                SqlDataReader dr = findById("Account", " ssn = " + ssn);
                if (dr.Read()) {
                    string userName = dr.GetString(1);
                    string userPassword = dr.GetString(2);
                    string role = dr.GetString(3);
                    account = new Account()
                    {
                        Ssn = ssn,
                        UserName = userName,
                        Password = userPassword,
                        Role = role
                    };
                }
            }
            catch (Exception ex) {
                //log
            }
            return account;
        }
    }
}
