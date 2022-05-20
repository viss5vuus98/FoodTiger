
namespace foodtiger
{
    partial class index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSpcart = new System.Windows.Forms.Button();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.listview = new System.Windows.Forms.ListView();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(154)))), ((int)(((byte)(176)))));
            this.label2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "FoodTiger";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogout.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogout.Location = new System.Drawing.Point(716, 22);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(74, 30);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "登出";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSpcart
            // 
            this.btnSpcart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.btnSpcart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSpcart.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSpcart.Location = new System.Drawing.Point(622, 22);
            this.btnSpcart.Name = "btnSpcart";
            this.btnSpcart.Size = new System.Drawing.Size(74, 30);
            this.btnSpcart.TabIndex = 7;
            this.btnSpcart.Text = "購物車";
            this.btnSpcart.UseVisualStyleBackColor = false;
            this.btnSpcart.Click += new System.EventHandler(this.btnSpcart_Click);
            // 
            // btnFavorite
            // 
            this.btnFavorite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.btnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFavorite.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFavorite.Location = new System.Drawing.Point(505, 22);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(96, 30);
            this.btnFavorite.TabIndex = 7;
            this.btnFavorite.Text = "收藏清單";
            this.btnFavorite.UseVisualStyleBackColor = false;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // listview
            // 
            this.listview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.listview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listview.HideSelection = false;
            this.listview.Location = new System.Drawing.Point(0, 181);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(801, 510);
            this.listview.TabIndex = 8;
            this.listview.UseCompatibleStateImageBehavior = false;
            this.listview.Click += new System.EventHandler(this.listview_Click);
            // 
            // textSearch
            // 
            this.textSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(43, 104);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(155, 29);
            this.textSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(223, 104);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 30);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "搜尋";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(80, 80);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(154)))), ((int)(((byte)(176)))));
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 74);
            this.panel1.TabIndex = 29;
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(801, 691);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.listview);
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.btnSpcart);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "index";
            this.Text = "index";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.index_FormClosing);
            this.Load += new System.EventHandler(this.index_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSpcart;
        private System.Windows.Forms.Button btnFavorite;
        private System.Windows.Forms.ListView listview;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
    }
}