using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace foodtiger
{
    class global
    {        
        public static ImageList imageData = new ImageList();
        public static List<product> productsData = new List<product>();
    }
    class modelUser
    {
        string myDBConnectionString = "";
        string logTable = "";
        public store store;
        public static Form1 form1;
        public static List<product> products = new List<product>();
        public modelUser()
        {
            store = new store();
            SqlConnectionStringBuilder scsb;
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
        }
        public static Dictionary<string, string> userInfo = new Dictionary<string, string>() {
            {"id", ""},{ "email", ""},{"password", ""}
        };//ID email password
         
        List<int> favorite  = new List<int>();//favorite

        public void getProductList(ImageList imageList)  //todo :資料來源 要帶入參數 
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from product";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            string image_dir = @"image\";
            string image_name = "";
            
            while (reader.Read())
            {
                product product = new product();
                product.id = (int)reader["ID"];
                product.productName = (string)reader["productName"];               
                product.price = (int)reader["productPrice"];
                product.description = (string)reader["productDescription"];
                product.stock = (int)reader["stock"];
                product.onsale = Convert.ToInt32(reader["on sale"]);
                product.discount = (decimal)reader["discount"];
                product.imageIndex = (int)reader["serual number"];
                image_name = (string)reader["productImage"];
                imageList.Images.Add(System.Drawing.Image.FromFile(image_dir + image_name));               
                product.productImg = image_dir + image_name;
                products.Add(product);
            }
            global.productsData = products.ToList();
            reader.Close();
            con.Close();
        }

        public void getStore(int ID,string name)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            String strSQL = "select s.storeName, s.storeAddress, s.storeCLass" +
                " from storeAccount as s join product as p on s.ID = p.ID where s.ID = @storeID and p.productName = @ProductName";
            SqlCommand cmd = new SqlCommand(strSQL,con);
            cmd.Parameters.AddWithValue("@storeID", ID);
            cmd.Parameters.AddWithValue("@ProductName", name);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                store store = new store();    //todo 搜尋不到 更改條件
                store.storeName = (string)reader["storeName"];
                store.address = (string)reader["storeAddress"];
                store.storeClass = (string)reader["storeClass"];
            }
        }
        
    }

    class product
    {
        public int id = 0;
        public string productName = "";
        public string productImg = "";
        public int price = 0;
        public string description = "";
        public int stock = 0;
        public int onsale = 0;
        public decimal discount = 0;
        public int imageIndex = 0;
    }

    public class store
    {
        public string storeName = "";
        public string address = "";
        public string storeClass = "";       
    }
}
