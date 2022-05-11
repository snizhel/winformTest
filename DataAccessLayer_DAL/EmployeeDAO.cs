using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer_DAL
{
    public class EmployeeDAO : GeneralDAO
    {

        public DataSet getAllEmployees()
        {
            return getAll("Employee");
        }
        public DataSet searchByName(string name)
        {
            return search("Employee", "Fname like '%" + name + "%' or " +
                                      "Lname like '%" + name + "%' ");
        }

        public SqlDataReader findById(string id)
        {
            getConnection();
            SqlDataReader dr = findById("Employee", " Ssn='" + id + "' ");
            // closeConnection();
            return dr;
        }

        public int deleteEmployee(string id)
        {
            try
            {
                string sql = "delete [EMPLOYEE] where ssn ='" + id + "' ";
                return insert_update_delete(sql); // -1 if error

            }
            catch (Exception ex)
            {
                // log
                return -1;
            }

        }
        public int createEmployee(Employee emp)
        {
            try
            {
                string sql = string.Format("insert [EMPLOYEE] " +
                    "                      values('{0}', 'M', 'LN', '{1}', '{2}', '{3}', 'F', 10000, '333445555', '1')",
                                           emp.FirstName, emp.Ssn, emp.Dob.ToString("yyyy/MM/dd"), emp.Address);

                return insert_update_delete(sql); // -1 if error

            }
            catch (Exception ex)
            {
                // log
                return -1;
            }

        }

        public int updateEmployee(Employee emp)
        {
            try
            {
                //[Fname], [Minit], [Lname], [Ssn], [Bdate], [Address], [Sex], [Salary], [Super_ssn], [Dno]

                string sql = " update Employee set Fname='" + emp.FirstName +
                             "' , Address='" + emp.Address + "',Bdate='" +
                             emp.Dob.ToString("yyyy/MM/dd") +
                             "' where ssn='" + emp.Ssn + "' ";

                string sql_1 = string.Format("update Employee " +
                                                "set Fname='{0}',Address='{1}'," + " Bdate='{2}'" +
                                                 " where ssn ='{3}'  ",
                                             emp.FirstName, emp.Address, emp.Dob.ToString("yyyy/MM/dd"), emp.Ssn);

                return insert_update_delete(sql); // -1 if error

            }
            catch (Exception ex)
            {
                // log
                return -1;
            }

        }
        public SqlDataReader getDnameDepartment()
        {
            getConnection();
            SqlDataReader dr = dropList("Department");
            // closeConnection();
            return dr;
        }
        public SqlDataReader getSuperManager()
        {
            getConnection();
            SqlDataReader dr = dropList("E_DEPENDENT");
            // closeConnection();
            return dr;
        }
    }
}
