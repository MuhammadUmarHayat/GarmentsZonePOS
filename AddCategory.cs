using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace GarmentsZone7June23
{
    public partial class AddCategory : Form
    {
        private SqlConnection connection = new SqlConnection(DAL.connectionString);
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        OpenFileDialog opf = new OpenFileDialog();

        public AddCategory()
        {
            InitializeComponent();
            // Initialize database connection

           
            loadData();
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
                //string imagePath = lblPath.Text; 
                Image img = pictureBox1.Image;
                string imgurl = opf.FileName;
                // File.ReadAllBytes(img);
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into categories(category,photo,status) values(@category,@photo,@status)", connection);
                cmd.Parameters.AddWithValue("@category", txtCategory.Text);
                cmd.Parameters.AddWithValue("@photo", arr);
                cmd.Parameters.AddWithValue("@status", imgurl);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Category is added");
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
            dataTable = dal.getAll("categories");

            dataGridView1.DataSource = dataTable;

        }


       
        private void AddCategory_Load(object sender, EventArgs e)
        {
            
        }
        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void dataGridView1_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i=e.RowIndex;
            MessageBox.Show(i.ToString());
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string category = txtCategory.Text;
            //update category
            DAL dal = new DAL();
            dal.updateCategory(id, category);
            MessageBox.Show("Record is updated");
            loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            //delete category
            DAL dal = new DAL();
            dal.deleteCategory(id);
            MessageBox.Show("Record is deleted");
            loadData();
        }
    }
}
