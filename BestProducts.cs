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
    public partial class BestProducts : Form
    {
        public BestProducts()
        {
            InitializeComponent();
        }

        private void BestProducts_Load(object sender, EventArgs e)
        {
            DAL dal = new DAL();
          DataTable dt=  dal.getBestSellingProducts();
            dataGridView1.DataSource = dt;
        }
    }
}
