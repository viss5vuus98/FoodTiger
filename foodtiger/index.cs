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
            if (imageList1.Images.Count <= 0)
            {
                controller.viewControl(listview, imageList1);
            }         
            //listview.Clear();
            //Console.WriteLine(imageList1.Images.Count);
            render(global.productsData);  //不是原資料了
            Console.WriteLine("FIND: " + modelUser.products.Find(item => item.productName.Contains("1")));

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
            render(controller.search(textSearch.Text));
        }

        private void index_FormClosing(object sender, FormClosingEventArgs e)
        {
            modelUser.products.Clear();
            imageList1.Images.Clear();
            modelUser.form1.Show();          
        }

        void render(List<product> productdata) //todo  products輸入改成參數輸入使函式可複用
        {
            listview.Items.Clear();
            listview.View = View.LargeIcon;           
            imageList1.ImageSize = new Size(130, 135);
            listview.LargeImageList = imageList1;

            for (int i = 0; i < productdata.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = (productdata[i].imageIndex) - 1;
                item.Font = new Font("微軟正黑體", 13, FontStyle.Bold);
                item.Text = productdata[i].productName;
                item.Tag = productdata[i].id;
                listview.Items.Add(item);
            }
        }

        private void listview_Click(object sender, EventArgs e)
        {
            show form_show = new show();
            form_show.productIndex = (int)listview.SelectedItems[0].Index;
            form_show.ShowDialog();
        }
    }
}
