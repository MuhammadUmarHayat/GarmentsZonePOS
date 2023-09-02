using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarmentsZone7June23
{
    public partial class AddProducts : Form
    {
        private SqlConnection connection = new SqlConnection(DAL.connectionString);
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        OpenFileDialog opf = new OpenFileDialog();
        public AddProducts()
        {
            InitializeComponent();
            loadData();
            loadCategories();
        }
       
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //browse image
           opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
                string path = pictureBox1.Location.ToString();
                lblPath.Text = opf.FileName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Close();//close previous connection
                //string imagePath = lblPath.Text; 
                Image img = pictureBox1.Image;
                string imgurl= opf.FileName;
                Random sku = new Random();// stock keeping no 
                int no = sku.Next(1234, 666666);
                // File.ReadAllBytes(img);
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img,typeof(byte[]));

               
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into products(title,category,size,price,photo1,qty,vendor,purchasing_date,skuno,details,addedby,status,SalePrice) values(@title,@category,@size,@price,@photo,@qty,@vendor,@purchasing_date,@skuno,@details,@addedby,@status,@SalePrice)", connection);
                //,,,,photo1,photo2,photo3,photo4,photo5,qty,vendor,purchase_date,skuno,details,addedby,status
                cmd.Parameters.AddWithValue("@title",txtTitle.Text);
                cmd.Parameters.AddWithValue("@category",cmbCategory.Text);
                cmd.Parameters.AddWithValue("@size",txtSize.Text);
                cmd.Parameters.AddWithValue("@price",txtPrice.Text);//SalePrice
                cmd.Parameters.AddWithValue("@SalePrice", txtPrice.Text);//
                cmd.Parameters.AddWithValue("@photo", arr);
                //cmd.Parameters.AddWithValue("@photo2", arr);
                //cmd.Parameters.AddWithValue("@photo3", arr);
                //cmd.Parameters.AddWithValue("@photo4", arr);
                //cmd.Parameters.AddWithValue("@photo5", arr);

                cmd.Parameters.AddWithValue("@qty",txtQty.Text);
                cmd.Parameters.AddWithValue("@vendor",txtVendor.Text);
                cmd.Parameters.AddWithValue("@purchasing_date",DateTime.Now);
                cmd.Parameters.AddWithValue("@skuno", no.ToString());
                cmd.Parameters.AddWithValue("@details",txtDetails.Text);
                cmd.Parameters.AddWithValue("@addedby","admin");
                
                cmd.Parameters.AddWithValue("@status","ok");
                cmd.ExecuteNonQuery();

                MessageBox.Show("product is saved");
                connection.Close();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public void loadData()
        {
           
           
            dataTable = new DataTable();
            DAL dal = new DAL();
            dataTable= dal.getProducts();
       
            dataGridView1.DataSource = dataTable;

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


            cmbCategory.ValueMember = "category";
            cmbCategory.DisplayMember = "category";
           
            cmbCategory.DataSource = dt;
            con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete product by id
            string id = txtID.Text;
            
            DAL dal = new DAL();
            dal.deleteProduct(id);
            MessageBox.Show("Data is deleted");
            loadData();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //update products
            DAL dal = new DAL();
            string id = txtID.Text;
            string title = txtTitle.Text;
            string category = cmbCategory.Text;
            string size = txtSize.Text; 
                string salePrice = txtSalePrice.Text;
            dal.updateProduct(id, title, category, size, salePrice);
            MessageBox.Show("Data is updated");
            loadData();
        }

        private void AddProducts_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
