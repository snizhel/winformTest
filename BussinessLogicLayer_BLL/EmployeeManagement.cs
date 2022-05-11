using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer_DAL;

namespace BussinessLogicLayer_BLL
{
    public class EmployeeManagement
    {
        EmployeeDAO eDAO = new EmployeeDAO();
        AccountDAO accDAO = new AccountDAO();
        //admin
        public DataSet viewEmployees() {
            return eDAO.getAllEmployees();
        }

        public DataSet searchByName(string name)
        {
            return eDAO.searchByName(name);
        }

        public SqlDataReader getDetails(string id) {
            return eDAO.findById(id);
        }

        public void closeConnection()
        {
            eDAO.closeConnection();
        }
        public SqlDataReader getDnameDepartment() {
            return eDAO.getDnameDepartment();
        }

        public int AddEmployee(Employee emp) {
            // check valid

            //call DAO
            return eDAO.createEmployee(emp);

        }
        public int UpdateEmployee(Employee emp)
        {
            // check valid

            //call DAO
            return eDAO.updateEmployee(emp);

        }
        public int RemoveEmployee(string id)
        {
            // check valid

            //call DAO
            return eDAO.deleteEmployee(id);

        }

        public bool isExistUserName(string userName) {
            List<Account> lst = accDAO.getAllAccounts();
            foreach(Account acc in lst)
            {
                string userName_indb = acc.UserName;
                if (userName_indb == userName) {
                    return true; // tk da ton tai
                }

            }
            return false; // tk chua ton tai
        }
        public SqlDataReader getDepartmentName()
        {
            return eDAO.getDnameDepartment();
        }
        public SqlDataReader getSuperManager()
        {
            return eDAO.getSuperManager();
        }
    }
}
