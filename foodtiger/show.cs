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

        public show()
        {
            InitializeComponent();
        }

        private void show_Load(object sender, EventArgs e)
        {   
            //Todo: 可以呼叫controller對以下變數賦值,from不需建構modleuser controller處理好後回傳一個arrayList或list<T>

            int stock = modelUser.products[productIndex].stock;
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

            modelUser.addToCart(lblProductName.Text, lblStoreName.Text, price, 1);
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
    }
}
