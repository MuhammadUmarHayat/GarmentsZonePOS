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
    public partial class Reports : Form
    {
        DAL dal = new DAL();
        DataTable dt = new DataTable();
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
           
          dt= dal.getAll("sales");
            chart1.DataSource = dt;
            chart1.Series["Series1"].XValueMember = "Productname";
            chart1.Series["Series1"].YValueMembers = "qty";
            chart1.ChartAreas[0].AxisX.Title = "Productname";
            chart1.ChartAreas[0].AxisY.Title = "qty";
            chart1.DataBind();


            dt = dal.getAll("products");
            chart2.DataSource = dt;
            chart2.Series["Series1"].XValueMember = "title";
            chart2.Series["Series1"].YValueMembers = "qty";
            chart2.ChartAreas[0].AxisX.Title = "title";
            chart2.ChartAreas[0].AxisY.Title = "qty";
            chart2.DataBind();

            int totalSale = dal.totalSale();
            int totalPrchase = dal.totalPurchase();
            int totalVendors = dal.totalVendors();
            lblTotalPurchases.Text = "Total Purchases : " + totalPrchase.ToString();
            lblTotalSale.Text = "Total Sales : " + totalSale.ToString();
            lblVendors.Text ="Total Vendors : "+ totalVendors.ToString();
            dt = dal.getRemainingStock();
            dataGridView1.DataSource = dt;


        }
    }
}
