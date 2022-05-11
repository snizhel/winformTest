using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogicLayer_BLL;

namespace PresentationLayer_GUI
{
    public partial class FrmSignup : Form
    {
        EmployeeManagement mngEmployee = new EmployeeManagement();
        public FrmSignup()
        {
            InitializeComponent();
        }

        private void txt_username_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (string.IsNullOrEmpty(txt_username.Text))
            {
                errorProvider1.SetError(txt_username, "Username is not left blank!");
            }
            else if (mngEmployee.isExistUserName(txt_username.Text)) {
                errorProvider1.SetError(txt_username, "Username existed!!!");
            }
            else
            {
                errorProvider1.SetError(txt_username, null);
                e.Cancel = false;
            }

        }

        private void txt_password_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (string.IsNullOrEmpty(txt_password.Text))
            {
                errorProvider1.SetError(txt_password, "Password is not left blank!");
            }
            else if (txt_password.Text.Trim().Length < 6)
            {
                errorProvider1.SetError(txt_password, "at least 6 characters");

            }
            else {
                errorProvider1.SetError(txt_password, null);
                e.Cancel = false;
            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            
            if (ValidateChildren(ValidationConstraints.Enabled)) {
                MessageBox.Show(this,"Signup Done","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
