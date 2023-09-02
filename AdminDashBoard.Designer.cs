
namespace GarmentsZone7June23
{
    partial class AdminDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashBoard));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnVendorList = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLowStockItems = new System.Windows.Forms.Button();
            this.btnVendors = new System.Windows.Forms.Button();
            this.btnBestProducts = new System.Windows.Forms.Button();
            this.btnStockList = new System.Windows.Forms.Button();
            this.btnProductList = new System.Windows.Forms.Button();
            this.btnAddPurchase = new System.Windows.Forms.Button();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnCategoryList = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSide.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1140, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(95, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Admin Panel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Garments Zone";
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlSide.Controls.Add(this.pictureBox2);
            this.pnlSide.Controls.Add(this.tableLayoutPanel1);
            this.pnlSide.Controls.Add(this.label2);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 48);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(328, 474);
            this.pnlSide.TabIndex = 7;
            this.pnlSide.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSide_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.03252F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.96748F));
            this.tableLayoutPanel1.Controls.Add(this.btnLogout, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnVendorList, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnReports, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnLowStockItems, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnVendors, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnBestProducts, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnStockList, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnProductList, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAddPurchase, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAddSale, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAddProducts, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCategory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCategoryList, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 194);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(322, 277);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlHeader.Controls.Add(this.lblUserName);
            this.pnlHeader.Controls.Add(this.button1);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1206, 48);
            this.pnlHeader.TabIndex = 6;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblUserName.Location = new System.Drawing.Point(278, 18);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(24, 20);
            this.lblUserName.TabIndex = 16;
            this.lblUserName.Text = "[ ]";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(328, 48);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(878, 474);
            this.panelMain.TabIndex = 8;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GarmentsZone7June23.Properties.Resources.logo1;
            this.pictureBox2.Location = new System.Drawing.Point(82, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Image = global::GarmentsZone7June23.Properties.Resources.products;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(170, 208);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(149, 23);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Close";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnVendorList
            // 
            this.btnVendorList.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVendorList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVendorList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVendorList.FlatAppearance.BorderSize = 0;
            this.btnVendorList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnVendorList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnVendorList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendorList.ForeColor = System.Drawing.Color.White;
            this.btnVendorList.Image = global::GarmentsZone7June23.Properties.Resources.reg;
            this.btnVendorList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendorList.Location = new System.Drawing.Point(3, 208);
            this.btnVendorList.Name = "btnVendorList";
            this.btnVendorList.Size = new System.Drawing.Size(161, 23);
            this.btnVendorList.TabIndex = 16;
            this.btnVendorList.Text = "Vendor List";
            this.btnVendorList.UseVisualStyleBackColor = false;
            this.btnVendorList.Click += new System.EventHandler(this.btnVendorList_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Image = global::GarmentsZone7June23.Properties.Resources.reports;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(170, 172);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(149, 25);
            this.btnReports.TabIndex = 16;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnLowStockItems
            // 
            this.btnLowStockItems.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLowStockItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLowStockItems.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLowStockItems.FlatAppearance.BorderSize = 0;
            this.btnLowStockItems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLowStockItems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnLowStockItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLowStockItems.ForeColor = System.Drawing.Color.White;
            this.btnLowStockItems.Image = global::GarmentsZone7June23.Properties.Resources.reg1;
            this.btnLowStockItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLowStockItems.Location = new System.Drawing.Point(3, 172);
            this.btnLowStockItems.Name = "btnLowStockItems";
            this.btnLowStockItems.Size = new System.Drawing.Size(161, 25);
            this.btnLowStockItems.TabIndex = 16;
            this.btnLowStockItems.Text = "Low Stock Itmes";
            this.btnLowStockItems.UseVisualStyleBackColor = false;
            this.btnLowStockItems.Click += new System.EventHandler(this.btnLowStockItems_Click);
            // 
            // btnVendors
            // 
            this.btnVendors.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVendors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVendors.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVendors.FlatAppearance.BorderSize = 0;
            this.btnVendors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnVendors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnVendors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendors.ForeColor = System.Drawing.Color.White;
            this.btnVendors.Image = global::GarmentsZone7June23.Properties.Resources.login;
            this.btnVendors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendors.Location = new System.Drawing.Point(170, 137);
            this.btnVendors.Name = "btnVendors";
            this.btnVendors.Size = new System.Drawing.Size(149, 19);
            this.btnVendors.TabIndex = 16;
            this.btnVendors.Text = "Add Vendors";
            this.btnVendors.UseVisualStyleBackColor = false;
            this.btnVendors.Click += new System.EventHandler(this.btnVendors_Click);
            // 
            // btnBestProducts
            // 
            this.btnBestProducts.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBestProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBestProducts.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBestProducts.FlatAppearance.BorderSize = 0;
            this.btnBestProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBestProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnBestProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBestProducts.ForeColor = System.Drawing.Color.White;
            this.btnBestProducts.Image = global::GarmentsZone7June23.Properties.Resources.products;
            this.btnBestProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBestProducts.Location = new System.Drawing.Point(3, 137);
            this.btnBestProducts.Name = "btnBestProducts";
            this.btnBestProducts.Size = new System.Drawing.Size(161, 19);
            this.btnBestProducts.TabIndex = 16;
            this.btnBestProducts.Text = "Best Products";
            this.btnBestProducts.UseVisualStyleBackColor = false;
            this.btnBestProducts.Click += new System.EventHandler(this.btnBestProducts_Click);
            // 
            // btnStockList
            // 
            this.btnStockList.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnStockList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStockList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStockList.FlatAppearance.BorderSize = 0;
            this.btnStockList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnStockList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnStockList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockList.ForeColor = System.Drawing.Color.White;
            this.btnStockList.Image = global::GarmentsZone7June23.Properties.Resources.details1;
            this.btnStockList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockList.Location = new System.Drawing.Point(170, 103);
            this.btnStockList.Name = "btnStockList";
            this.btnStockList.Size = new System.Drawing.Size(149, 21);
            this.btnStockList.TabIndex = 16;
            this.btnStockList.Text = "Stock List";
            this.btnStockList.UseVisualStyleBackColor = false;
            this.btnStockList.Click += new System.EventHandler(this.btnStockList_Click);
            // 
            // btnProductList
            // 
            this.btnProductList.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnProductList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProductList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProductList.FlatAppearance.BorderSize = 0;
            this.btnProductList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnProductList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnProductList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductList.ForeColor = System.Drawing.Color.White;
            this.btnProductList.Image = global::GarmentsZone7June23.Properties.Resources.items;
            this.btnProductList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductList.Location = new System.Drawing.Point(3, 103);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(161, 21);
            this.btnProductList.TabIndex = 16;
            this.btnProductList.Text = "Product List";
            this.btnProductList.UseVisualStyleBackColor = false;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // btnAddPurchase
            // 
            this.btnAddPurchase.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddPurchase.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddPurchase.FlatAppearance.BorderSize = 0;
            this.btnAddPurchase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddPurchase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnAddPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPurchase.ForeColor = System.Drawing.Color.White;
            this.btnAddPurchase.Image = global::GarmentsZone7June23.Properties.Resources.reg;
            this.btnAddPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPurchase.Location = new System.Drawing.Point(3, 63);
            this.btnAddPurchase.Name = "btnAddPurchase";
            this.btnAddPurchase.Size = new System.Drawing.Size(161, 25);
            this.btnAddPurchase.TabIndex = 16;
            this.btnAddPurchase.Text = "Purchase";
            this.btnAddPurchase.UseVisualStyleBackColor = false;
            this.btnAddPurchase.Click += new System.EventHandler(this.btnAddPurchase_Click);
            // 
            // btnAddSale
            // 
            this.btnAddSale.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddSale.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddSale.FlatAppearance.BorderSize = 0;
            this.btnAddSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnAddSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSale.ForeColor = System.Drawing.Color.White;
            this.btnAddSale.Image = global::GarmentsZone7June23.Properties.Resources.login;
            this.btnAddSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSale.Location = new System.Drawing.Point(170, 63);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(149, 25);
            this.btnAddSale.TabIndex = 16;
            this.btnAddSale.Text = "POS";
            this.btnAddSale.UseVisualStyleBackColor = false;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddProducts.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddProducts.FlatAppearance.BorderSize = 0;
            this.btnAddProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnAddProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProducts.ForeColor = System.Drawing.Color.White;
            this.btnAddProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProducts.Image")));
            this.btnAddProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProducts.Location = new System.Drawing.Point(3, 30);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(161, 27);
            this.btnAddProducts.TabIndex = 15;
            this.btnAddProducts.Text = "Add Products";
            this.btnAddProducts.UseVisualStyleBackColor = false;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCategory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Image = global::GarmentsZone7June23.Properties.Resources.products;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(3, 3);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(161, 21);
            this.btnCategory.TabIndex = 17;
            this.btnCategory.Text = "Add Categories";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnCategoryList
            // 
            this.btnCategoryList.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCategoryList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCategoryList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCategoryList.FlatAppearance.BorderSize = 0;
            this.btnCategoryList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCategoryList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnCategoryList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryList.ForeColor = System.Drawing.Color.White;
            this.btnCategoryList.Image = global::GarmentsZone7June23.Properties.Resources.products;
            this.btnCategoryList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoryList.Location = new System.Drawing.Point(170, 3);
            this.btnCategoryList.Name = "btnCategoryList";
            this.btnCategoryList.Size = new System.Drawing.Size(149, 21);
            this.btnCategoryList.TabIndex = 18;
            this.btnCategoryList.Text = "Category List";
            this.btnCategoryList.UseVisualStyleBackColor = false;
            this.btnCategoryList.Click += new System.EventHandler(this.btnCategoryList_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1206, 522);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashBoard";
            this.Text = "AdminDashBoard";
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnVendorList;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLowStockItems;
        private System.Windows.Forms.Button btnVendors;
        private System.Windows.Forms.Button btnBestProducts;
        private System.Windows.Forms.Button btnStockList;
        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.Button btnAddPurchase;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCategoryList;
    }
}