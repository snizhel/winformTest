using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

using BussinessLogicLayer_BLL;
using DataAccessLayer_DAL;
namespace PresentationLayer_GUI
{
    public partial class FrmEmployees : Form
    {
        EmployeeManagement mngEmployees = new EmployeeManagement();
        BindingSource bs;
        public FrmEmployees()
        {
            InitializeComponent();
        }

        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            DataSet ds = mngEmployees.viewEmployees();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_employees.DataSource = bs;
        }

        private void lbl_search_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            if (txt_search.Text.Trim() == "") {
                ds = mngEmployees.searchByName(txt_search.Text);
            }
            else
            {
                ds = mngEmployees.searchByName(txt_search.Text);
            }
            
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_employees.DataSource = bs;
        }

        private void gv_employees_Click(object sender, EventArgs e)
        {
            int index = gv_employees.CurrentRow.Index;
            string ssn = gv_employees.Rows[index].Cells[3].Value.ToString();
            SqlDataReader dr=  mngEmployees.getDetails(ssn);
            //select * from employee where ...
            if (dr.Read()) {
                txt_adddress.Text = dr.GetString(5);
                txt_name.Text = dr.GetString(0) + " " + dr.GetString(1) + "" + dr.GetString(2);
                dt_dob.Value = dr.GetDateTime(4);

            }
            mngEmployees.closeConnection();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee()
            {
                FirstName = txt_name.Text,
                Address = txt_adddress.Text,
                Ssn = txt_phone.Text,
                Dob = dt_dob.Value
            };
            // 
            int result = mngEmployees.AddEmployee(emp);
            if (result < 0)
            {
                toolStripStatusLabel1.Text = "Save error!!!";
            }
            else {
                toolStripStatusLabel1.Text = "Create employee successfully !!!";
            }

            // refresh
            DataSet ds = mngEmployees.viewEmployees();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_employees.DataSource = bs;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee()
            {
                FirstName = txt_name.Text,
                Address = txt_adddress.Text,
                Ssn = txt_phone.Text,
                Dob = dt_dob.Value
            };
            // 
            int result = mngEmployees.UpdateEmployee(emp);
            if (result < 0)
            {
                toolStripStatusLabel1.Text = "Update error!!!";
            }
            else
            {
                toolStripStatusLabel1.Text = "update employee done !!!";
            }

            // refresh
            DataSet ds = mngEmployees.viewEmployees();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_employees.DataSource = bs;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int result = mngEmployees.RemoveEmployee(txt_phone.Text); // cot phone dang su dung lam khoa chinh ssn
            if (result < 0)
            {
                toolStripStatusLabel1.Text = "Delete error!!!";
            }
            else
            {
                toolStripStatusLabel1.Text = "Delete employee done !!!";
            }

            // refresh
            DataSet ds = mngEmployees.viewEmployees();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_employees.DataSource = bs;
        }
    }
}
