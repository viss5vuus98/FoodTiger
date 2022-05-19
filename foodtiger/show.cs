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
        

        public show()
        {
            InitializeComponent();
        }

        private void show_Load(object sender, EventArgs e)
        {           
            int stock = modelUser.products[productIndex].stock;
            int productId = modelUser.products[productIndex].id;
            string productimg = modelUser.products[productIndex].productImg;
            lblProductName.Text = modelUser.products[productIndex].productName;
            lblPrice.Text = modelUser.products[productIndex].price.ToString() + "   NT";
            lblDescription.Text = modelUser.products[productIndex].description;
            pictureBox1.Image = Image.FromFile(productimg);
            modelUser.getStore(productId, lblProductName.Text);
            lblStoreName.Text = (string)modelUser.store.storeName;
            lblAddress.Text = (string)modelUser.store.address;
            lblClass.Text = (string)modelUser.store.storeClass;
        }
    }
}
