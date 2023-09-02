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

namespace GarmentsZone7June23
{
    public partial class PointOfSale : Form
    {
        public PointOfSale()
        {
            InitializeComponent();
            loadCategories();
            getOrderNo();
            string orderno = lblOrderNo.Text;
            CalculateBill(orderno);
        }
        private void CalculateBill(string orderno)
        {
            DAL dal = new DAL();

            int bill = dal.CalculateBill(orderno);
            lblTotalBill.Text = bill.ToString();
        }
        private void PointOfSale_Load(object sender, EventArgs e)
        {
            loadCategories();
            getOrderNo();
        }
        private void getOrderNo()
        {
            Random r = new Random();
            int orderNo = r.Next(1, 666666);
            lblOrderNo.Text = orderNo.ToString();


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = comboBox1.Text;
            loadProducts(category);
        }
        private void loadCategories()
        {
            SqlConnection con = new SqlConnection(DAL.connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT category from categories";
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);

            // bind category with the combobox


            comboBox1.ValueMember = "category";
            comboBox1.DisplayMember = "category";

            comboBox1.DataSource = dt;
            con.Close();
        }
        private void loadProducts(string category)
        {
            SqlConnection con = new SqlConnection(DAL.connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT title from products where category='"+ category + "'";
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);

            // bind category with the combobox


            comboBox2.ValueMember = "title";
            comboBox2.DisplayMember = "title";

            comboBox2.DataSource = dt;
            con.Close();
        }

        private void btnCalBill_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = comboBox2.Text;
                string q = txtQty.Text;
                DAL dal = new DAL();
                DataTable dt = dal.getProduct(productName);
                lblpid.Text = dt.Rows[0]["id"].ToString();
                string p = dt.Rows[0]["saleprice"].ToString();
                lblUnitPrice.Text = p;
                int quantity = Convert.ToInt32(q);
                int price = Convert.ToInt32(p);
                int total = price * quantity;
                lblTotal.Text = total.ToString();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Please enter correct quantity");
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            //view order
            string customer = txtCustomerName.Text;
            string orderno = lblOrderNo.Text;
            ViewCustomerOrder f = new ViewCustomerOrder(customer, orderno);
            f.Show();
            this.Close();

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //order now
            try
            {
                string pid = lblpid.Text;
                string productName = comboBox2.Text;
                string orderno = lblOrderNo.Text;
                string qty = txtQty.Text;
                string price = lblUnitPrice.Text;
                string total = lblTotal.Text;
                string customer = txtCustomerName.Text;
                string phone = txtPhonNo.Text;
                string saling_date = DateTime.Now.ToString();
                string status = "submitted";

                DAL dal = new DAL();
                string[] arr = { pid, qty, pid, price, total, customer, customer, saling_date, phone, status, productName, orderno };
                Boolean result = dal.save("sales", arr);
                if (result)
                {
                    lblResult.Text = "Order is saved successfully";

                    //  loadForm(new  ViewCustomerOrder(customer, orderno));
                    ViewCustomerOrder f = new ViewCustomerOrder(customer, orderno);
                    f.Show();


                }
                else
                {
                    lblResult.Text = "Something went wrong please try latter";
                }
                string orderno1 = lblOrderNo.Text;
                CalculateBill(orderno1);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Please enter correct quantity and fill the required fileds ");
            }

        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewOrder_Click_1(object sender, EventArgs e)
        {
            string orderno = lblOrderNo.Text;
            string customer = txtCustomerName.Text;
            ViewCustomerOrder f = new ViewCustomerOrder(customer, orderno);
            f.Show();

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            //checout button 
            string orderno = lblOrderNo.Text;
            string customer = txtCustomerName.Text;
        Checkout c=new  Checkout(customer,orderno);
            c.Show();
            


        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c)&& c!=8 && c!= 46)
            {
                e.Handled = true;
            }
        }
    }
}
