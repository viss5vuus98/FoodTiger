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
    public partial class storeIndex : Form
    {
        modelUser modelUser = new modelUser();
        modelStore modelStore = new modelStore();
        string image_dir = @"image\";
        string image_name = "";
        bool isChangeImg = false;
        int id = Convert.ToInt32(modelStore.storeInfo["id"]);

        public storeIndex()
        {
            InitializeComponent();
        }

        private void storeIndex_Load(object sender, EventArgs e)
        {
            
            modelStore.getProductList(id);
            modelStore.storerender(listViewProducts);
        }

        private void listViewProducts_Click(object sender, EventArgs e)
        {
            int productIndex = (int)listViewProducts.SelectedItems[0].Index;
            renderDetail(modelStore.getSelect(productIndex));
        }

        void renderDetail(product product)
        {
            Console.WriteLine(product.productName);
            string productimg = product.productImg;
            lblStoreName.Text = modelStore.storeInfo["name"];
            lblAddress.Text = modelStore.storeInfo["address"];
            lblsold.Text = product.buyQuantity.ToString();
            lblfav.Text = product.favoriteQuantity.ToString();
            pboxProduct.Image = Image.FromFile(productimg);
            lblproductName.Text = product.productName;
            txtDescription.Text = product.description;
            txtPrice.Text = product.price.ToString();
            txtstock.Text = product.stock.ToString();
            if (product.onsale == 1)
            {
                cboxDiscount.Checked = true;
                txtdiscount.Text = product.discount.ToString();
            }
            else
            {
                cboxDiscount.Checked = false;
                txtdiscount.Text = "0";
            }
        }

        private void pboxProduct_Click(object sender, EventArgs e)
        {
            //OpenFileDialog f = new OpenFileDialog();
            //f.Filter = "圖檔類型 (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";

            //DialogResult r = f.ShowDialog();
            //if (r == DialogResult.OK)
            //{
            //    pictureBox1.Image = Image.FromFile(f.FileName);
            //    string fileExt = System.IO.Path.GetExtension(f.SafeFileName);
            //    Random myRand = new Random();
            //    image_name = DateTime.Now.ToString("yyMMddHHmmss") + myRand.Next(100, 1000) + fileExt;
            //    is已修改圖檔 = true;
            //    Console.WriteLine(image_name);
            //}
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "圖檔類型 (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";
            DialogResult r = f.ShowDialog();
            if (r == DialogResult.OK)
            {
                pboxProduct.Image = Image.FromFile(f.FileName);
                image_name = f.SafeFileName;
                isChangeImg = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            getProductData();
        }

        void getProductData()
        {
            int stock = 0;
            int.TryParse(txtstock.Text, out stock);
            int price = 0;
            int.TryParse(txtPrice.Text, out price);
            decimal discount = 1;
            decimal.TryParse(txtdiscount.Text, out discount);
            int onsale = 0;

            if (stock < 0)
            {
                MessageBox.Show("請輸入庫存");
                return;
            }
            else if (price <= 0)
            {
                MessageBox.Show("請輸入正確價格");
                return;
            }
            else if (txtDescription.Text.Length <= 0)
            {
                MessageBox.Show("請輸入商品描述");
                return;
            }
            if (cboxDiscount.Checked)
            {
                onsale = 1;
            }
            else
            {
                onsale = 0;
                discount = 1;
            }
            if (isChangeImg)
            {
                pboxProduct.Image.Save(image_dir + image_name);  //換圖片 發生泛行錯誤 解決是路徑名稱錯誤 目前檔名以原名儲存
                isChangeImg = false;
            }
            modelStore.update(image_name, price, txtDescription.Text, stock, onsale, discount, id, lblproductName.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //product_name lbl換成txtbox
            //要換from
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }


    }
}
