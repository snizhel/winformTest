
namespace PresentationLayer_GUI
{
    partial class FrmAddEmployees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEmployees));
            this.label3 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pic_avatar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_dob = new System.Windows.Forms.DateTimePicker();
            this.txt_mname = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdo_male = new System.Windows.Forms.RadioButton();
            this.rdo_female = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbx_departments = new System.Windows.Forms.ComboBox();
            this.cbx_manager = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_dno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "SSN Number";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(54, 299);
            this.txt_address.Margin = new System.Windows.Forms.Padding(2);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(422, 20);
            this.txt_address.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 284);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Address";
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(54, 196);
            this.txt_fname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(138, 20);
            this.txt_fname.TabIndex = 54;
            this.txt_fname.Validating += new System.ComponentModel.CancelEventHandler(this.txt_fname_Validating);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_update
            // 
            this.btn_update.Image = global::PresentationLayer_GUI.Properties.Resources.modify;
            this.btn_update.Location = new System.Drawing.Point(108, 22);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(76, 33);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Update";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.Location = new System.Drawing.Point(0, 22);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(76, 33);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // pic_avatar
            // 
            this.pic_avatar.Image = global::PresentationLayer_GUI.Properties.Resources.profile;
            this.pic_avatar.Location = new System.Drawing.Point(56, 24);
            this.pic_avatar.Margin = new System.Windows.Forms.Padding(2);
            this.pic_avatar.Name = "pic_avatar";
            this.pic_avatar.Size = new System.Drawing.Size(160, 134);
            this.pic_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_avatar.TabIndex = 53;
            this.pic_avatar.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 340);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Salary";
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(262, 355);
            this.txt_salary.Margin = new System.Windows.Forms.Padding(2);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(214, 20);
            this.txt_salary.TabIndex = 60;
            this.txt_salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            this.txt_salary.Validating += new System.ComponentModel.CancelEventHandler(this.txt_salary_Validating);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Location = new System.Drawing.Point(54, 505);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 74);
            this.panel1.TabIndex = 62;
            // 
            // btn_close
            // 
            this.btn_close.Image = global::PresentationLayer_GUI.Properties.Resources.exit;
            this.btn_close.Location = new System.Drawing.Point(332, 22);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(74, 33);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Close";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::PresentationLayer_GUI.Properties.Resources.delete;
            this.btn_delete.Location = new System.Drawing.Point(216, 22);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(76, 33);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "FirstName";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(54, 355);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(2);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(204, 20);
            this.txt_phone.TabIndex = 58;
            this.txt_phone.Tag = "number";
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            this.txt_phone.Validating += new System.ComponentModel.CancelEventHandler(this.txt_phone_Validating);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 581);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(543, 22);
            this.statusStrip1.TabIndex = 67;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 228);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "BDate";
            // 
            // dt_dob
            // 
            this.dt_dob.CustomFormat = "yyyy/MM/dd";
            this.dt_dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_dob.Location = new System.Drawing.Point(54, 243);
            this.dt_dob.Margin = new System.Windows.Forms.Padding(2);
            this.dt_dob.Name = "dt_dob";
            this.dt_dob.Size = new System.Drawing.Size(280, 20);
            this.dt_dob.TabIndex = 65;
            // 
            // txt_mname
            // 
            this.txt_mname.Location = new System.Drawing.Point(196, 196);
            this.txt_mname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mname.Name = "txt_mname";
            this.txt_mname.Size = new System.Drawing.Size(138, 20);
            this.txt_mname.TabIndex = 68;
            this.txt_mname.Validating += new System.ComponentModel.CancelEventHandler(this.txt_mname_Validating);
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(338, 196);
            this.txt_lname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(138, 20);
            this.txt_lname.TabIndex = 69;
            this.txt_lname.Validating += new System.ComponentModel.CancelEventHandler(this.txt_lname_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 395);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Sex";
            // 
            // rdo_male
            // 
            this.rdo_male.AutoSize = true;
            this.rdo_male.Location = new System.Drawing.Point(54, 411);
            this.rdo_male.Name = "rdo_male";
            this.rdo_male.Size = new System.Drawing.Size(48, 17);
            this.rdo_male.TabIndex = 71;
            this.rdo_male.TabStop = true;
            this.rdo_male.Text = "Male";
            this.rdo_male.UseVisualStyleBackColor = true;
            // 
            // rdo_female
            // 
            this.rdo_female.AutoSize = true;
            this.rdo_female.Location = new System.Drawing.Point(196, 411);
            this.rdo_female.Name = "rdo_female";
            this.rdo_female.Size = new System.Drawing.Size(59, 17);
            this.rdo_female.TabIndex = 72;
            this.rdo_female.TabStop = true;
            this.rdo_female.Text = "Female";
            this.rdo_female.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 445);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "Department";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 445);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = "Supper Manager";
            // 
            // cbx_departments
            // 
            this.cbx_departments.FormattingEnabled = true;
            this.cbx_departments.Location = new System.Drawing.Point(54, 461);
            this.cbx_departments.Name = "cbx_departments";
            this.cbx_departments.Size = new System.Drawing.Size(167, 21);
            this.cbx_departments.TabIndex = 75;
            this.cbx_departments.SelectedIndexChanged += new System.EventHandler(this.cbx_departments_SelectedIndexChanged);
            // 
            // cbx_manager
            // 
            this.cbx_manager.FormattingEnabled = true;
            this.cbx_manager.Location = new System.Drawing.Point(227, 461);
            this.cbx_manager.Name = "cbx_manager";
            this.cbx_manager.Size = new System.Drawing.Size(249, 21);
            this.cbx_manager.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(193, 181);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 77;
            this.label9.Text = "Minit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(335, 181);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "LastName";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txt_dno
            // 
            this.txt_dno.Location = new System.Drawing.Point(338, 243);
            this.txt_dno.Margin = new System.Windows.Forms.Padding(2);
            this.txt_dno.Name = "txt_dno";
            this.txt_dno.Size = new System.Drawing.Size(138, 20);
            this.txt_dno.TabIndex = 79;
            this.txt_dno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dno_KeyPress);
            this.txt_dno.Validating += new System.ComponentModel.CancelEventHandler(this.txt_dno_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(338, 228);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 80;
            this.label11.Text = "Dno";
            // 
            // FrmAddEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 603);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_dno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbx_manager);
            this.Controls.Add(this.cbx_departments);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdo_female);
            this.Controls.Add(this.rdo_male);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_mname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.pic_avatar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dt_dob);
            this.Name = "FrmAddEmployees";
            this.Text = "FrmAddEmployees";
            this.Load += new System.EventHandler(this.FrmAddEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_avatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox pic_avatar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_dob;
        private System.Windows.Forms.TextBox txt_mname;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdo_male;
        private System.Windows.Forms.RadioButton rdo_female;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbx_departments;
        private System.Windows.Forms.ComboBox cbx_manager;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_dno;
    }
}