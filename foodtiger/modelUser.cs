using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

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
        public static Form1 form1;
        public static index index;
        public static List<product> products = new List<product>();
        public string storeName;
        public string address;
        public string storeClass;
        public modelUser()
        {
            SqlConnectionStringBuilder scsb;
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"DESKTOP-J4NHV3D";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
        }
        public static Dictionary<string, string> userInfo = new Dictionary<string, string>() {
            {"id", ""},{ "email", ""},{"password", ""}
        };//ID email password
         
        public static List<string> favorite  = new List<string>();//favorite
        public static List<product> favoriteList = new List<product>();
        public static List<product> cartList = new List<product>();
        public void getFavoriteList()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            //string strSQL = "select * from favorite where ID = @UserID";   //
            string strSQL = "select  p.ID, f.productName, p.productImage from favorite as f join product as p on f.productName = p.productName where f.ID = @UserID";
            SqlCommand cmd = new SqlCommand(strSQL, con);           
            cmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(userInfo["id"]));
            SqlDataReader reader = cmd.ExecuteReader();
            string image_dir = @"image\";
            string image_name = "";
            favorite.Clear();
            favoriteList.Clear();
            while (reader.Read())
            {
                product product = new product();
                favorite.Add((string)reader["productName"]);
                product.id = (int)reader["ID"];
                product.productName = (string)reader["productName"];
                image_name = (string)reader["productImage"];
                product.productImg = image_dir + image_name;
                favoriteList.Add(product);
            }
            reader.Close();
            con.Close();

        }

        public void addFavorite(string store, string product)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "insert into favorite values(@ID, @Store, @Product, 1)";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(userInfo["id"]));
            cmd.Parameters.AddWithValue("@Store", store);
            cmd.Parameters.AddWithValue("@Product", product);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void removeFavorite(string store, string product)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "delete favorite where ID = @ID and storeName = @Store and productName = @Product";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(userInfo["id"]));
            cmd.Parameters.AddWithValue("@Store", store);
            cmd.Parameters.AddWithValue("@Product", product);
            cmd.ExecuteNonQuery();
            con.Close();            
        }

        public void removeAllFavorite()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "delete favorite where ID = @ID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(userInfo["id"]));
            cmd.ExecuteNonQuery();
            con.Close();
        }

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
            string strSQL = "select s.storeName, s.storeAddress, s.storeCLass" +
                " from storeAccount as s join product as p on s.ID = p.ID where s.ID = @storeID and p.productName = @ProductName";
            SqlCommand cmd = new SqlCommand(strSQL,con);
            cmd.Parameters.AddWithValue("@storeID", ID);
            cmd.Parameters.AddWithValue("@ProductName", name);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                storeName = (string)reader["storeName"];
                address = (string)reader["storeAddress"];
                storeClass = (string)reader["storeClass"];                          
            }
        }

        public void addToCart(string productName, string store, int price, int quantity, int updateStock)
        {
            product product = new product();
            product.productName = productName;
            product.store = store;
            product.price = price;
            product.buyQuantity = quantity;
            product.stock = updateStock;
            cartList.Add(product);
        }

        public void checkout()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            for (int i = 0; i < cartList.Count; i++)
            {
                string store = cartList[i].store;
                string product = cartList[i].productName;
                int quantity = cartList[i].buyQuantity; //Todo 修改商品購買數
                int stock = cartList[i].stock;
                string strSQL = "insert into orderList values(@Store, @Product, @User, @Quantity, @Date)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Store", store);
                cmd.Parameters.AddWithValue("@Product", product);
                cmd.Parameters.AddWithValue("@User", userInfo["email"]);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@Date", string.Format("{0:d}", DateTime.Now));
                cmd.ExecuteNonQuery();
                // 更新商品庫存與被購買數
                strSQL = "update product set stock = @UpdataStock, [sold quantity] = (select [sold quantity] from product where productName = @Product) + @Quantity where productName = @Product2";
                SqlCommand cmd2 = new SqlCommand(strSQL, con);
                cmd2.Parameters.AddWithValue("@UpdataStock", stock - quantity);
                cmd2.Parameters.AddWithValue("@Product", product);
                cmd2.Parameters.AddWithValue("@Quantity", quantity);
                cmd2.Parameters.AddWithValue("@Product2", product);
                cmd2.ExecuteNonQuery();
            }            
            con.Close();

        }
        
    }

    class modelStore
    {
        string myDBConnectionString = "";
        public modelStore()
        {
            SqlConnectionStringBuilder scsb;
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"DESKTOP-J4NHV3D";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
        }
        public static Dictionary<string, string> storeInfo = new Dictionary<string, string>() {
            {"id", ""},{ "email", ""},{"password", ""},{"name", ""},{"address", ""}
        };

        public void getProductList(int id)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from product where ID = @StoreID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@StoreID", id);
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
                product.buyQuantity = (int)reader["sold quantity"];
                product.favoriteQuantity = (int)reader["favorite quantity"];
                image_name = (string)reader["productImage"];
                product.productImg = image_dir + image_name;
                modelUser.products.Add(product);
            }
        }

        public void storerender(ListView listView)
        {
            listView.Clear();
            listView.View = View.Details;
            listView.Columns.Add("商品名稱", 200);
            listView.Columns.Add("售出數量", 100);
            for (int i = 0; i < modelUser.products.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = modelUser.products[i].productName;
                item.SubItems.Add(modelUser.products[i].buyQuantity.ToString());
                item.Tag = modelUser.products[i].id;
                listView.Items.Add(item);
            }
        }

        public product getSelect(int index)
        {
            return modelUser.products[index];
        }
        
        public void update(string img, int price, string des, int stock, int onsale, decimal discount, int id, string productName)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "update product set productImage = @Image, productPrice = @Price, productDescription = @Des, stock = @Stock, [on sale] = @Onsale, discount = @Discount where ID = @ID" +
                " and productName = @ProductName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Image", img);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@Des", des);
            cmd.Parameters.AddWithValue("@Stock", stock);
            cmd.Parameters.AddWithValue("@Onsale", onsale);
            cmd.Parameters.AddWithValue("@Discount", discount);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@ProductName", productName);
            cmd.ExecuteNonQuery();
            con.Close();          
        }
    }

    public class product
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
        public int buyQuantity = 0;
        public string store = "";
        public int favoriteQuantity = 0;
    }

}
