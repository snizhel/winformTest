
namespace PresentationLayer_GUI
{
    partial class FrmSomeControls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSomeControls));
            this.lv_products = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.lst_categories = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_largeicon = new System.Windows.Forms.RadioButton();
            this.rad_tile = new System.Windows.Forms.RadioButton();
            this.rad_list = new System.Windows.Forms.RadioButton();
            this.cbx_view = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_products
            // 
            this.lv_products.HideSelection = false;
            this.lv_products.LargeImageList = this.imageList1;
            this.lv_products.Location = new System.Drawing.Point(294, 121);
            this.lv_products.Name = "lv_products";
            this.lv_products.Size = new System.Drawing.Size(816, 455);
            this.lv_products.SmallImageList = this.imageList2;
            this.lv_products.StateImageList = this.imageList2;
            this.lv_products.TabIndex = 6;
            this.lv_products.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Cabbage-icon.png");
            this.imageList1.Images.SetKeyName(1, "Eggplant-icon.png");
            this.imageList1.Images.SetKeyName(2, "strawberry-icon.png");
            this.imageList1.Images.SetKeyName(3, "watermelon-icon.png");
            this.imageList1.Images.SetKeyName(4, "Tomato-icon.png");
            this.imageList1.Images.SetKeyName(5, "Coffee-icon (1).png");
            this.imageList1.Images.SetKeyName(6, "Coffee-icon.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "fruit1.png");
            this.imageList2.Images.SetKeyName(1, "fruit2.png");
            this.imageList2.Images.SetKeyName(2, "fruits.png");
            // 
            // lst_categories
            // 
            this.lst_categories.FormattingEnabled = true;
            this.lst_categories.ItemHeight = 20;
            this.lst_categories.Location = new System.Drawing.Point(18, 32);
            this.lst_categories.Name = "lst_categories";
            this.lst_categories.Size = new System.Drawing.Size(237, 544);
            this.lst_categories.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_largeicon);
            this.groupBox1.Controls.Add(this.rad_tile);
            this.groupBox1.Controls.Add(this.rad_list);
            this.groupBox1.Controls.Add(this.cbx_view);
            this.groupBox1.Location = new System.Drawing.Point(291, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 76);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Setting";
            // 
            // rad_largeicon
            // 
            this.rad_largeicon.AutoSize = true;
            this.rad_largeicon.Checked = true;
            this.rad_largeicon.Location = new System.Drawing.Point(379, 29);
            this.rad_largeicon.Name = "rad_largeicon";
            this.rad_largeicon.Size = new System.Drawing.Size(106, 24);
            this.rad_largeicon.TabIndex = 4;
            this.rad_largeicon.TabStop = true;
            this.rad_largeicon.Text = "LargeIcon";
            this.rad_largeicon.UseVisualStyleBackColor = true;
            // 
            // rad_tile
            // 
            this.rad_tile.AutoSize = true;
            this.rad_tile.Location = new System.Drawing.Point(217, 29);
            this.rad_tile.Name = "rad_tile";
            this.rad_tile.Size = new System.Drawing.Size(58, 24);
            this.rad_tile.TabIndex = 3;
            this.rad_tile.TabStop = true;
            this.rad_tile.Text = "Tile";
            this.rad_tile.UseVisualStyleBackColor = true;
            // 
            // rad_list
            // 
            this.rad_list.AutoSize = true;
            this.rad_list.Location = new System.Drawing.Point(41, 29);
            this.rad_list.Name = "rad_list";
            this.rad_list.Size = new System.Drawing.Size(59, 24);
            this.rad_list.TabIndex = 2;
            this.rad_list.TabStop = true;
            this.rad_list.Text = "List";
            this.rad_list.UseVisualStyleBackColor = true;
            // 
            // cbx_view
            // 
            this.cbx_view.FormattingEnabled = true;
            this.cbx_view.Items.AddRange(new object[] {
            "List",
            "Tile",
            "LargeIcon",
            "Details"});
            this.cbx_view.Location = new System.Drawing.Point(587, 25);
            this.cbx_view.Name = "cbx_view";
            this.cbx_view.Size = new System.Drawing.Size(209, 28);
            this.cbx_view.TabIndex = 0;
            // 
            // FrmSomeControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 600);
            this.Controls.Add(this.lv_products);
            this.Controls.Add(this.lst_categories);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSomeControls";
            this.Text = "FrmSomeControls";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_products;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ListBox lst_categories;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_largeicon;
        private System.Windows.Forms.RadioButton rad_tile;
        private System.Windows.Forms.RadioButton rad_list;
        private System.Windows.Forms.ComboBox cbx_view;
    }
}