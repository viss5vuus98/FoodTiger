using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace foodtiger
{   
    class controller
    {
        modelUser modelUser = new modelUser();        
        string myDBConnectionString = "";
        string logTable = "";
        public controller()
        {
            modelUser modelUser = new modelUser();
            SqlConnectionStringBuilder scsb;
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
        }
        public bool login(bool check, string account, string password)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "";
            string email = "";
            string pwd = "";
            bool ispwd = false;
            if (check)
            {
                strSQL = "select * from UserAccount where UserEmail = @Email";
                email = "UserEmail";
                pwd = "UserPassWord";
            }
            else
            {
                strSQL = "select * from storeAccount where storeEmail = @Email";
                email = "storeEmail";
                pwd = "storePassWord";
            }
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Email", account);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (password == (string)reader[pwd])
                {
                    modelUser.userInfo["id"] = reader["ID"].ToString();
                    modelUser.userInfo["email"] = (string)reader[email];
                    modelUser.userInfo["password"] = (string)reader[pwd];
                    MessageBox.Show("輸入正確，登入");
                    modelUser.getFavoriteList();
                    ispwd = true;
                }                             
            }
            else
            {
                //MessageBox.Show("無此帳號"); //todo
                return ispwd;
            }
            reader.Close();
            con.Close();
            return ispwd;
        }

        public bool createAccount(string createAC, string createPwd)
        {
            bool result = false;
            if (createAC.Contains("@mail.com"))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into UserAccount values(@email, @password)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@email", createAC);
                cmd.Parameters.AddWithValue("@password", createPwd);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("創建成功");
                result = true;
            }
            else
            {
                MessageBox.Show("請輸入正確的email");
            }
            return result;
        }

        public void viewControl(ListView listView, ImageList imageList)
        {
            if (modelUser.products.Count <= 0)
            {
                modelUser.getProductList(imageList);
            }
            //todo 搜尋功能 如果已經有資料 則提取搜尋的目標去重新render

            //todo 類別分類功能

            //todo: 呼叫model取的目標詳細資料 > 給view render畫面

        }

        public void renderFavorite(bool result, string store, string product)
        {
            if (result)
            {
                modelUser.removeFavorite(store, product);                               
            }
            else
            {
                modelUser.addFavorite(store, product);
            }
            modelUser.getFavoriteList();
        }

        public List<product> search(string keyword) //要回傳直
        {
            string key = keyword.Trim();           
            if (keyword.Length <= 0)
            {                
                global.productsData = modelUser.products.ToList();
                return global.productsData;
            }
            else
            {
                global.productsData.Clear();
                global.productsData.Add(modelUser.products.Find(item => item.productName.Contains(keyword)));
                foreach (product item in global.productsData)
                {
                    Console.WriteLine(item.imageIndex);
                }
                return global.productsData;
            }           
        }
        // controller 收進參數給MODEL  MODEL再回傳處理好的LIST給CONTROL加入TEXTBOX


    }
}
