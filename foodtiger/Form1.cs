using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace foodtiger
{
    public partial class Form1 : Form
    {
        modelUser modelUser = new modelUser();
        SqlConnectionStringBuilder scsb;   //SQL 連線字串建立語法
        string myDBConnectionString = "";
        List<int> searchIDs = new List<int>(); //進階搜尋結果
        string logTable = "";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";  //主機名稱
            scsb.InitialCatalog = "mydb"; //資料庫名稱
            scsb.IntegratedSecurity = true; //win安全驗證
            myDBConnectionString = scsb.ToString();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {   
            if (cUser.Checked && cStore.Checked)
            {
                MessageBox.Show("請只選擇一種登入方式");
                return;
            }
            else if(!cUser.Checked && !cStore.Checked)
            {
                MessageBox.Show("請選擇登入方式");
                return;
            }
            string email = "";
            string pwd = "";
            string strSQL ="";
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            if (cUser.Checked)
            {
                strSQL = "select * from UserAccount where UserEmail = @userEmail";
                email = "UserEmail";
                pwd = "UserPassWord";
            }
            else
            {
                strSQL = "select * from storeAccount where storeEmail = @userEmail";
            }
            //string strSQL = "select * from UserAccount where UserEmail = '@userEmail'";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            //cmd.Parameters.AddWithValue("@loginSelect", "%" + logTable + "%");
            cmd.Parameters.AddWithValue("@userEmail", txtLogAc.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Console.WriteLine((string)reader["UserEmail"]);
                //MessageBox.Show(string.Format("{0}",reader["UserEmail"]));
                modelUser.userInfo["id"] = reader["ID"].ToString();
                modelUser.userInfo["email"] = (string)reader["UserEmail"];
                modelUser.userInfo["password"] = (string)reader["UserPassWord"];
            }
            else
            {
                MessageBox.Show("無此帳號");
            }
            foreach (KeyValuePair<string,string> item in modelUser.userInfo)
            {
                Console.WriteLine("id:" + item.Value);
            }


            reader.Close();
            con.Close();
        }
    }
}
