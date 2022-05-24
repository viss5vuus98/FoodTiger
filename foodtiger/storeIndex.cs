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

        public storeIndex()
        {
            InitializeComponent();
        }

        private void storeIndex_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(modelStore.storeInfo["id"]);
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
            txtpName.Text = product.productName;
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
                string fileExt = System.IO.Path.GetExtension(f.SafeFileName);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }


    }
}
