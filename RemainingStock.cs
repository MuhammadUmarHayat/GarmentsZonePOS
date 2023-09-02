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
    public partial class RemainingStock : Form
    {
        public RemainingStock()
        {
            InitializeComponent();
            DAL dal = new DAL();
          DataTable dt= dal.getRemainingStock();
            dataGridView1.DataSource = dt;
        }

    }
}
