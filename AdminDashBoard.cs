using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarmentsZone7June23
{
    public partial class AdminDashBoard : Form
    {
        public AdminDashBoard()
        {
            InitializeComponent();
            

        }
        public AdminDashBoard(string user_name)
        {
            InitializeComponent();
            lblUserName.Text = user_name;
            loadForm(new Reports());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //close button
            DialogResult result = MessageBox.Show("Do you want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Cancel the form closing event
                Application.Exit();
            }
        }
        public void loadForm(object Form)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();


        }
        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            loadForm(new AddProducts());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            loadForm(new AddCategory());
        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            loadForm(new CategoryList());
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            loadForm(new ListOfProducts());
        }

        private void btnBestProducts_Click(object sender, EventArgs e)
        {
            loadForm(new BestProducts());
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            //point of Sale Interface
            loadForm(new PointOfSale());
        }

        private void btnStockList_Click(object sender, EventArgs e)
        {
            loadForm(new RemainingStock());

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Logout button

            
            DialogResult result = MessageBox.Show("Do you want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Cancel the form closing event
                Application.Exit();
            }
        }

        private void btnAddPurchase_Click(object sender, EventArgs e)
        {
            loadForm(new ListOfProducts());
        }

        private void btnLowStockItems_Click(object sender, EventArgs e)
        {
            loadForm(new RemainingStock());
        }

        private void btnVendors_Click(object sender, EventArgs e)
        {
            loadForm(new AddVendors());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            loadForm(new Reports());
        }

        private void pnlSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVendorList_Click(object sender, EventArgs e)
        {
            loadForm(new VendorList());
        }
    }
}
