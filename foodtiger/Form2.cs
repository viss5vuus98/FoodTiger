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
    public partial class Form2 : Form
    {
        modelUser modelUser = new modelUser();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lsvFavorite.Clear();
            renderView();
        }

        void renderView()
        {
            lsvFavorite.Items.Clear();
            lsvFavorite.View = View.LargeIcon;
            imgListFavorite.ImageSize = new Size(130, 135);
            // favoriteList 

            for (int i = 0; i < modelUser.favoriteList.Count; i++)
            {
                imgListFavorite.Images.Add(Image.FromFile(modelUser.favoriteList[i].productImg));
            }

            lsvFavorite.LargeImageList = imgListFavorite;

            for (int i = 0; i < modelUser.favoriteList.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 13, FontStyle.Bold);
                item.Text = modelUser.favoriteList[i].productName;
                item.Tag = modelUser.favoriteList[i].id;
                lsvFavorite.Items.Add(item);
            }

            //listview.Items.Clear();
            //listview.View = View.LargeIcon;
            //imgListFavorite.ImageSize = new Size(130, 135);
            //listview.LargeImageList = imgListFavorite;

            //for (int i = 0; i < productdata.Count; i++)
            //{
            //    ListViewItem item = new ListViewItem();
            //    item.ImageIndex = (productdata[i].imageIndex) - 1;
            //    item.Font = new Font("微軟正黑體", 13, FontStyle.Bold);
            //    item.Text = productdata[i].productName;
            //    item.Tag = productdata[i].id;
            //    listview.Items.Add(item);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modelUser.removeAllFavorite();
            modelUser.getFavoriteList();
            renderView();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lsvFavorite_Click(object sender, EventArgs e)
        {
            show form_show = new show();
            form_show.Show();
            this.Close();
        }
    }
}
