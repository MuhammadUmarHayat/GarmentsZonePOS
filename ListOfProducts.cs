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
    public partial class ListOfProducts : Form
    {
        public ListOfProducts()
        {
            InitializeComponent();
        }

        private void ListOfProducts_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {


          DataTable  dataTable = new DataTable();
            DAL dal = new DAL();
            dataTable = dal.getProducts();

            dataGridView1.DataSource = dataTable;

        }
    }
}
