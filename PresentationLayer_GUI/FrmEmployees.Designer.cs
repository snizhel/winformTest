
namespace PresentationLayer_GUI
{
    partial class FrmEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployees));
            this.label3 = new System.Windows.Forms.Label();
            this.txt_adddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.gv_employees = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_dob = new System.Windows.Forms.DateTimePicker();
            this.lbl_search = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pic_avatar = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_employees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "SSN Number";
            // 
            // txt_adddress
            // 
            this.txt_adddress.Location = new System.Drawing.Point(22, 235);
            this.txt_adddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_adddress.Name = "txt_adddress";
            this.txt_adddress.Size = new System.Drawing.Size(245, 20);
            this.txt_adddress.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Address";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(22, 147);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(245, 20);
            this.txt_name.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Employee Name";
            // 
            // btn_close
            // 
            this.btn_close.Image = global::PresentationLayer_GUI.Properties.Resources.exit;
            this.btn_close.Location = new System.Drawing.Point(662, 8);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(109, 47);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Close";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::PresentationLayer_GUI.Properties.Resources.delete;
            this.btn_delete.Location = new System.Drawing.Point(338, 8);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(109, 47);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 304);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Email";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(22, 279);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(245, 20);
            this.txt_phone.TabIndex = 41;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(21, 331);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(245, 20);
            this.txt_email.TabIndex = 43;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(289, 78);
            this.txt_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(419, 20);
            this.txt_search.TabIndex = 46;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 432);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(787, 22);
            this.statusStrip1.TabIndex = 50;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Location = new System.Drawing.Point(8, 359);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 64);
            this.panel1.TabIndex = 45;
            // 
            // btn_update
            // 
            this.btn_update.Image = global::PresentationLayer_GUI.Properties.Resources.modify;
            this.btn_update.Location = new System.Drawing.Point(176, 8);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(109, 47);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Update";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.Location = new System.Drawing.Point(14, 8);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(109, 47);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // gv_employees
            // 
            this.gv_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_employees.Location = new System.Drawing.Point(288, 111);
            this.gv_employees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gv_employees.Name = "gv_employees";
            this.gv_employees.RowHeadersWidth = 62;
            this.gv_employees.RowTemplate.Height = 28;
            this.gv_employees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_employees.Size = new System.Drawing.Size(492, 224);
            this.gv_employees.TabIndex = 34;
            this.gv_employees.Click += new System.EventHandler(this.gv_employees_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Dob";
            // 
            // dt_dob
            // 
            this.dt_dob.CustomFormat = "yyyy/MM/dd";
            this.dt_dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_dob.Location = new System.Drawing.Point(22, 191);
            this.dt_dob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dt_dob.Name = "dt_dob";
            this.dt_dob.Size = new System.Drawing.Size(245, 20);
            this.dt_dob.TabIndex = 48;
            // 
            // lbl_search
            // 
            this.lbl_search.Image = global::PresentationLayer_GUI.Properties.Resources.find;
            this.lbl_search.Location = new System.Drawing.Point(705, 78);
            this.lbl_search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(35, 23);
            this.lbl_search.TabIndex = 47;
            this.lbl_search.Text = "     ";
            this.lbl_search.Click += new System.EventHandler(this.lbl_search_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(284, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(485, 55);
            this.label5.TabIndex = 44;
            this.label5.Text = "MANAGEMENT EMPLOYEES";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_avatar
            // 
            this.pic_avatar.Image = global::PresentationLayer_GUI.Properties.Resources.profile;
            this.pic_avatar.Location = new System.Drawing.Point(22, 8);
            this.pic_avatar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_avatar.Name = "pic_avatar";
            this.pic_avatar.Size = new System.Drawing.Size(138, 105);
            this.pic_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_avatar.TabIndex = 36;
            this.pic_avatar.TabStop = false;
            // 
            // FrmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 454);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_adddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.pic_avatar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gv_employees);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dt_dob);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmEmployees";
            this.Text = "EmployeeManagement";
            this.Load += new System.EventHandler(this.FrmEmployees_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_employees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_adddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.PictureBox pic_avatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gv_employees;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_dob;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Label label5;
    }
}

