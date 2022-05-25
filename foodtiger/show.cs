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
    public partial class show : Form
    {
        public int productIndex = 0;
        modelUser modelUser = new modelUser();
        controller controller = new controller();
        bool isFavorite = false;
        int quantity = 0;
        int stock;
        public show()
        {
            InitializeComponent();
        }

        private void show_Load(object sender, EventArgs e)
        {   
            //Todo: 可以呼叫controller對以下變數賦值,from不需建構modleuser controller處理好後回傳一個arrayList或list<T>

            stock = modelUser.products[productIndex].stock;
            int productId = modelUser.products[productIndex].id;
            string productimg = modelUser.products[productIndex].productImg;
            //Todo: 以下可使用controller會傳的陣列進行render
            lblProductName.Text = modelUser.products[productIndex].productName;
            lblPrice.Text = modelUser.products[productIndex].price.ToString() + "   NT";
            lblDescription.Text = modelUser.products[productIndex].description;
            pictureBox1.Image = Image.FromFile(productimg);
            modelUser.getStore(productId, lblProductName.Text);
            if (modelUser.favorite.Contains(lblProductName.Text))
            {
                lblAddFavorite.ForeColor = Color.Red;
                isFavorite = true;
            }
                

            // Todo: 此函式要放在controller呼叫
            //modelUser.getStore(productId, lblProductName.Text);

            lblStoreName.Text = modelUser.storeName;
            lblAddress.Text = modelUser.address;
            lblClass.Text = modelUser.storeClass;           
            
            //Todo: 檢查是否被使用者加入favorite
        }

        private void btnBack_Click(object sender, EventArgs e)
        {           
            this.Close();
            
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            Form2 form_form2 = new Form2();
            form_form2.Show();
            this.Hide();
        }

        private void btnSpcart_Click(object sender, EventArgs e)
        {
            cart form_cart = new cart();
            form_cart.Show();
            this.Hide();
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            int price = modelUser.products[productIndex].price;
            modelUser.addToCart(lblProductName.Text, lblStoreName.Text, price, quantity, stock);
            MessageBox.Show("已加入");
        }

        private void lblAddFavorite_Click(object sender, EventArgs e)
        {

            
            if (isFavorite)
            {
                controller.renderFavorite(isFavorite, lblStoreName.Text, lblProductName.Text);
                lblAddFavorite.ForeColor = Color.Black;
                isFavorite = false;
            }
            else
            {
                
                controller.renderFavorite(isFavorite, lblStoreName.Text, lblProductName.Text);
                lblAddFavorite.ForeColor = Color.Red;
                isFavorite = true;
            }
        }

        private void show_FormClosing(object sender, FormClosingEventArgs e)
        {
            modelUser.index.Show();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            quantity += 1;
            if (quantity >= 100)
            {
                MessageBox.Show("超過購買上限");
                quantity = 99;
                return;
            }
            if (stock < quantity)
            {
                MessageBox.Show("此商品庫存不足");
                quantity -= 1;
            }
                      
            lblquantity.Text = quantity.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            quantity -= 1;
            if (quantity < 1)
            {
                MessageBox.Show("已經最少了");
                quantity = 1;
                return;
            }           
            lblquantity.Text = quantity.ToString();
        }
    }
}
