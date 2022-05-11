using BussinessLogicLayer_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer_GUI
{
    public partial class FrmAddEmployees : Form
    {
        EmployeeManagement mngEmployee = new EmployeeManagement();
        public FrmAddEmployees()
        {
            InitializeComponent();
        }

        private void FrmAddEmployees_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataReader reader = mngEmployee.getDepartmentName();
            dataTable.Load(reader);
            cbx_departments.DataSource = dataTable;
            cbx_departments.DisplayMember = "Dname";
            cbx_departments.ValueMember = "Mgr_ssn";
            cbx_departments.SelectedIndex = -1;
            mngEmployee.closeConnection();
            DataTable dataTable1 = new DataTable();
            SqlDataReader reader2 = mngEmployee.getSuperManager();
            dataTable1.Load(reader2);
            cbx_manager.DataSource = dataTable1;
            cbx_manager.DisplayMember = "Dependent_name";
            cbx_manager.ValueMember = "Essn";
            cbx_manager.SelectedIndex = -1;



        }

        private void txt_phone_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (string.IsNullOrEmpty(txt_phone.Text))
            {
                errorProvider1.SetError(txt_phone, "Ssn is not left blank!");
            }
            else if (((char)txt_phone.Text.Trim().Length) > 9 || ((char)txt_phone.Text.Trim().Length) < 9)
            {
                errorProvider1.SetError(txt_phone, "Please enter 9 characters");

            }
            else
            {
                errorProvider1.SetError(txt_phone, null);
                e.Cancel = false;
            }
        }

        private void txt_fname_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (string.IsNullOrEmpty(txt_fname.Text))
            {
                errorProvider1.SetError(txt_fname, "FirstName is not left blank!");
            }
            else if (mngEmployee.isExistUserName(txt_fname.Text))
            {
                errorProvider1.SetError(txt_fname, "FirstName existed!!!");
            }
            else
            {
                errorProvider1.SetError(txt_fname, null);
                e.Cancel = false;
            }
        }

        private void txt_mname_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (string.IsNullOrEmpty(txt_mname.Text))
            {
                errorProvider1.SetError(txt_mname, "MinitName is not left blank!");
            }
            else if (mngEmployee.isExistUserName(txt_mname.Text))
            {
                errorProvider1.SetError(txt_mname, "MinitName existed!!!");
            }
            else
            {
                errorProvider1.SetError(txt_mname, null);
                e.Cancel = false;
            }
        }

        private void txt_lname_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (string.IsNullOrEmpty(txt_lname.Text))
            {
                errorProvider1.SetError(txt_lname, "LastName is not left blank!");
            }
            else if (mngEmployee.isExistUserName(txt_lname.Text))
            {
                errorProvider1.SetError(txt_lname, "LastName existed!!!");
            }
            else
            {
                errorProvider1.SetError(txt_lname, null);
                e.Cancel = false;
            }
        }

        private void txt_dno_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (string.IsNullOrEmpty(txt_dno.Text))
            {
                errorProvider1.SetError(txt_dno, "Dno is not left blank!");
            }
            else if (Int32.Parse(txt_dno.Text)  < 18)
            {
                errorProvider1.SetError(txt_dno, "At least 18 years old");

            }
            else
            {
                errorProvider1.SetError(txt_dno, null);
                e.Cancel = false;
            }
        }

        private void txt_salary_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (string.IsNullOrEmpty(txt_salary.Text))
            {
                errorProvider1.SetError(txt_salary, "Salary is not left blank!");
            }
            else if (Int32.Parse(txt_salary.Text) < 0)
            {
                errorProvider1.SetError(txt_salary, "Salary greater than 0");
            }
            else
            {
                errorProvider1.SetError(txt_salary, null);
                e.Cancel = false;
            }
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_dno_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cbx_departments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
