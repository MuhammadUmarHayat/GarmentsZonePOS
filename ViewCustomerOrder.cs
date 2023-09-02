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
    public partial class ViewCustomerOrder : Form
    {
        public ViewCustomerOrder()
        {
            InitializeComponent();
        }
        public ViewCustomerOrder(string customerName,string orderNo)
        {
            InitializeComponent();
            lblCustomerName.Text = customerName;
            lblOrderNo.Text = orderNo;
            DAL dal = new DAL();
          DataTable dt=  dal.getOrder(customerName, orderNo);
            dataGridView1.DataSource = dt;
            string orderno = lblOrderNo.Text;
            CalculateBill(orderno);


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewCustomerOrder_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            DAL dal = new DAL();
            dal.deleteOrder(id);
            loadData();
            string orderno = lblOrderNo.Text;
            CalculateBill(orderno);

        }
        private void loadData()
        {
            string customerName = lblCustomerName.Text;
            string orderNo = lblOrderNo.Text;
            DAL dal = new DAL();
            DataTable dt = dal.getOrder(customerName, orderNo);
            dataGridView1.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //update quatitiy
            string id = txtID.Text;
            string q = txtQty.Text;
            DAL dal = new DAL();
          int price=  dal.getPrice(id);
            int qty = Convert.ToInt32(q);
            int total = price * qty;
            dal.updateOrder(id,qty.ToString(),total.ToString());
            MessageBox.Show("Quantity is updated");
            loadData();
            string orderno = lblOrderNo.Text;
            CalculateBill(orderno);


        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CalculateBill(string orderno)
        {
            DAL dal = new DAL();

            int bill = dal.CalculateBill(orderno);
            lblTotal.Text = bill.ToString();
        }
    }
}
