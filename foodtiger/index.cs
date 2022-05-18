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
    public partial class index : Form
    {
        modelUser modelUser = new modelUser();
        controller controller = new controller();
        public index()
        {
            InitializeComponent();
        }

        private void index_Load(object sender, EventArgs e)
        {
            controller.renderview(listview, imageList1);

            //listview.Clear();
            Console.WriteLine(imageList1.Images.Count);
            listview.View = View.LargeIcon;
            imageList1.ImageSize = new Size(80, 80);
            listview.LargeImageList = imageList1;
            
            for (int i = 0; i < modelUser.products.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = modelUser.products[i].productName;
                item.Tag = modelUser.products[i].id;
                listview.Items.Add(item);

            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpcart_Click(object sender, EventArgs e)
        {

        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void index_FormClosing(object sender, FormClosingEventArgs e)
        {
            modelUser.form1.Show();


        }
    }
}
