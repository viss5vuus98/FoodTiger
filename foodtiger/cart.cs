using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foodtiger
{
    public partial class cart : Form
    {
        modelUser modelUser = new modelUser();
        public List<int> updateStockList = new List<int>();
        public cart()
        {
            InitializeComponent();
        }
        string productName = "";
        int total = 0;
        int quantity = 0;
        private void cart_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < modelUser.cartList.Count; i++)
            {
                productName = modelUser.cartList[i].productName;
                quantity = modelUser.cartList[i].buyQuantity;
                int price = modelUser.cartList[i].price;
                int updataStock = modelUser.cartList[i].stock;
                updateStockList.Add(updataStock);
                int strlength = productName.Length;
                int count = 32 - strlength;
                //找出字串的長度
                for (int k = 0; k < count; k++)
                {
                    productName += "--";
                }
                productName += quantity.ToString();
                //總長扣字串長度 等於" " 或 "-" 產生次數
                lboxCart.Items.Add(productName);
                total += price * quantity;
            }
            lbltotal.Text = total.ToString();
        }

        private void btnBuyall_Click(object sender, EventArgs e)
        {
            modelUser.checkout();
            MessageBox.Show("送出訂單成功");
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cart_FormClosing(object sender, FormClosingEventArgs e)
        {
            modelUser.index.Show();
        }
    }
}
