using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GarmentsZone7June23
{
    class DAL
    {
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=GarmentsZoneFinalDB;Integrated Security=True;Pooling=False";

        public Boolean save(string tableName, string[] values)
        {
            string query = "";
            switch (tableName)
            {
                case "users":

                    query = "insert into users(user_name, password, name, mobile, address, usertype, status) values('" + values[0] + "','" + values[1] + "','" + values[2] + "','" + values[3] + "','" + values[4] + "','" + values[5] + "','" + values[6] + "')";


                    break;
                
                case "products":
                    query = "insert into products(title, category, size, price, photo1, photo2, photo3, photo4, photo5, qty, vendor, purchasing_date, SKUNo, details, addedby, status) values('" + values[0] + "','" + values[1] + "','" + values[2] + "','" + values[3] + "','" + values[4] + "','" + values[5] + "','" + values[6] + "','" + values[7] + "','" + values[8] + "','" + values[9] + "','" + values[10] + "','" + values[11] + "','" + values[12] + "','" + values[13] + "','" + values[14] + "','" + values[15] + "')";
                    break;
                case "vendors":
                    query = "insert into vendors(name,company,address,phoneNo,status) values('" + values[0] + "','" + values[1] + "','" + values[2] + "','" + values[3] + "','" + values[4] + "')";
                    break;
                case "purchases":
                    query = "insert into purchases(product_id,name,size,,price,vendor,qty,purchasing_date,status,skuNO) values('" + values[0] + "','" + values[1] + "','" + values[2] + "','" + values[3] + "','" + values[4] + "','" + values[5] + "','" + values[6] + "','" + values[7] + "','" + values[8] + "')";
                    break;
                case "sales":
                    query = "insert into sales(productId,qty,size,price,total,customerid,customerName,saling_date,phoneNo,status,productname,orderNo) values('" + values[0] + "','" + values[1] + "','" + values[2] + "','" + values[3] + "','" + values[4] + "','" + values[5] + "','" + values[6] + "','" + values[7] + "','" + values[8] + "','" + values[9] + "','" + values[10] + "','" + values[11] + "')";
                    break;
            }
            SqlConnection con = new SqlConnection(DAL.connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }
        public Boolean deleteCategory(string id)
        {
            string query = "DELETE FROM categories where id='" + id + "' ";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }
        public Boolean deleteProduct(string id)
        {
            string query = "DELETE FROM products where id='" + id+"' ";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }

        public Boolean deleteOrder(string id)
        {
            string query = "DELETE FROM sales where id='" + id + "' ";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }

        public Boolean deleteVendor(string id)
        {
            string query = "DELETE FROM vendors where id='" + id + "' ";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }
        public Boolean updateVendor(string id, string name, string company,string phone,string address)
        {
            string query = "update vendors set name='" + name + "',company='" + company + "',address='"+address+"',phoneNo='"+phone+"'  where id='" + id + "' ";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }
        public Boolean updateOrder(string id,string qty,string total)
        {
            string query = "update sales set qty='"+qty+"',total='"+total+"'  where id='" + id + "' ";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }
        public Boolean updatestatus(string orderno, string status)
        {
            string query = "update sales set status='" + status +"'  where orderNo='" + orderno+ "' ";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }
        public int getPrice(string id)
        {
            string query = "select * from sales where id='"+id+"'";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count>0)
            {
              string p=  dt.Rows[0]["price"].ToString();
                int price = Convert.ToInt32(p);
                return price;
            }

            return 0;
        }
        public int CalculateBill(string orderNo)
        {
            string query = "SELECT SUM(total) FROM sales WHERE orderNo = @orderNo";
            int price = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@orderNo", orderNo);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        price = Convert.ToInt32(result);
                    }
                }
            }

            return price;

            
        }


        public int totalSale()
        {
            string query = "SELECT SUM(total) FROM sales ";
            int price = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                   

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        price = Convert.ToInt32(result);
                    }
                }
            }

            return price;


        }
        public int totalPurchase()
        {
            string query = "SELECT SUM(price) FROM products ";
            int price = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {


                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        price = Convert.ToInt32(result);
                    }
                }
            }

            return price;


        }
        public int totalVendors()
        {
            string query = "SELECT count(*) FROM  vendors";
            int price = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {


                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        price = Convert.ToInt32(result);
                    }
                }
            }

            return price;


        }

        public Boolean updateCategory(string id, string category)
        {
            string query = "update categories set category='" + category + "' where id='" + id + "'";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }
        public Boolean updateProduct(string id,string title,string category, string size,string salePrice)
        {
            string query = "update products set title='"+title+"',category='"+category+"',size='"+size+"',salePrice='"+salePrice+"' where id='" + id + "'";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }
        public DataTable getAll(string tableName)
        {
            string query = "select * from " + tableName + "";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getProducts()
        {
            string query = "select id,title,photo1,size,price as Purchasing_Price,salePrice from products";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getProduct(string name)
        {
            string query = "select * from products where title='"+name+"'";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getOrder(string customer, string orderno)
        {
            string query = "select * from sales where customerName='"+customer+"' and orderNo='" + orderno + "'";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable getBestSellingProducts()
        {
            string query = "SELECT productname, productId, SUM(qty) AS total_qty FROM sales GROUP BY productId, productname ORDER BY total_qty DESC";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getRemainingStock()
        {
            string query = "SELECT * FROM ProductRemainingQuantityView";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getRecord(string tableName, string col1, string value1)
        {
            string query = "select * from " + tableName + " where " + col1 + "='" + value1 + "' ";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }



        public DataTable getRecord(string tableName, string col1, string value1, string col2, string value2)
        {

            //select * from users where 
            string query = "select * from " + tableName + " where " + col1 + "='" + value1 + "' and " + col2 + "='" + value2 + "'";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

public bool saveCategory(string category,byte[] photo,string status)
        {


                   string query = "insert into categories(category, photo, status) values('" + category + "','" + photo + "','" + status + "')";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            return true;


        }


    }
}
