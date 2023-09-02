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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
           

            if (username.Equals("") && password.Equals(""))
            {
                lblResult.Text = "fields should not empty";
            }
            else if (username.Equals("admin") && password.Equals("admin"))
            {
                this.Hide();
                

                AdminDashBoard admin = new AdminDashBoard(username);
                admin.Show();
                this.Hide();

            }
            else
            {
                DAL dal = new DAL();

                DataTable dt = dal.getRecord("users", "user_name", username, "password", password);
                int size = dt.Rows.Count;
                if (size > 0)
                {
                    this.Hide();
                   

                    //  MessageBox.Show("User is existing");

                }
                else
                {
                    lblResult.Text = "Please enter correct username or password";
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //close button
            Application.Exit();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
