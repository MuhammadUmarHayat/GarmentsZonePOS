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
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }
        public Checkout(string customerName, string orderNo)
        {
            InitializeComponent();
            lblCustomer.Text = customerName;
            lblOrderNo.Text = orderNo;
            DAL dal = new DAL();
            DataTable dt = dal.getOrder(customerName, orderNo);
            dataGridView1.DataSource = dt;
            string orderno = lblOrderNo.Text;
            CalculateBill(orderno);


        }

       
            private void CalculateBill(string orderno)
            {
                DAL dal = new DAL();

                int bill = dal.CalculateBill(orderno);
                lblTotal.Text = bill.ToString();
            }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            string orderno = lblOrderNo.Text;
            string status = "paid";
            DAL dal = new DAL();
            dal.updatestatus(orderno, status);
            MessageBox.Show("Thank you for Shoping");
        }
    }
}
