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
        controller controller = new controller();
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
            scsb.DataSource = @"DESKTOP-J4NHV3D";  //主機名稱
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
            bool loginSelect = false;
            if (cUser.Checked)
            {
                loginSelect = true;
            }
            
            if (!controller.login(loginSelect, txtLogAc.Text, txtlogpwd.Text))
            {
                MessageBox.Show("帳號或密碼錯誤");
                txtlogpwd.Text = "";
            }
            else if (loginSelect)
            {
                index index = new index();
                index.Show();
                modelUser.form1 = this;
                this.Hide();
            }else
            {
                //輸入正確 跳轉頁面
                storeIndex storeIndex = new storeIndex(); 
                storeIndex.Show();
                modelUser.form1 = this;
                this.Hide();
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            createAccount createAccount = new createAccount();
            createAccount.ShowDialog();
        }
    }
}
