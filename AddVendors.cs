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
    public partial class AddVendors : Form
    {
        DAL dal = new DAL();
        public AddVendors()
        {
            InitializeComponent();
            loadData();
        }
        private void loadData()
        {
           
          DataTable dt=  dal.getAll("vendors");
            dataGridView1.DataSource = dt;
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string cmpy = txtCompny.Text;
            string address = txtAddress.Text;
            string phone = txtPhoneNo.Text;
            string status = "active";
          
            string[] arr = { name,cmpy,address,phone,status};
            Boolean result = dal.save("vendors", arr);
            if (result)
            {
                MessageBox.Show( "Record is saved successfully");
                lblResult.Text = "Record is saved successfully";




            }
            else
            {
                MessageBox.Show("Something went wrong please try latter");
                lblResult.Text = "Something went wrong please try latter";

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string company = txtCompny.Text;
            string address = txtAddress.Text;
            string phone = txtPhoneNo.Text;
            string id = txtid.Text;
            dal.updateVendor(id, name, company, phone, address);
            MessageBox.Show("Record is updated");
            loadData();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
           
            dal.deleteVendor(id);
            MessageBox.Show("Record is deleted");
            loadData();

        }
    }
}
