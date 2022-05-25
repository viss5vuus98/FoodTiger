
namespace foodtiger
{
    partial class storeIndex
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.lblfav = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFavoriteQuantity = new System.Windows.Forms.Label();
            this.lblsold = new System.Windows.Forms.Label();
            this.lblSalequantity = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxDiscount = new System.Windows.Forms.CheckBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.pboxProduct = new System.Windows.Forms.PictureBox();
            this.lblproductName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNew.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNew.Location = new System.Drawing.Point(608, 27);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(81, 30);
            this.btnNew.TabIndex = 31;
            this.btnNew.Text = "新增商品";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogout.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogout.Location = new System.Drawing.Point(717, 27);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(59, 30);
            this.btnLogout.TabIndex = 32;
            this.btnLogout.Text = "登出";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(154)))), ((int)(((byte)(176)))));
            this.label2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 30;
            this.label2.Text = "FoodTiger";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(154)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 74);
            this.panel1.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(505, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 30);
            this.button1.TabIndex = 31;
            this.button1.Text = "訂單列表";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewProducts
            // 
            this.listViewProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(1, 134);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(373, 515);
            this.listViewProducts.TabIndex = 34;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.Click += new System.EventHandler(this.listViewProducts_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtstock);
            this.panel2.Controls.Add(this.lblfav);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblFavoriteQuantity);
            this.panel2.Controls.Add(this.lblsold);
            this.panel2.Controls.Add(this.lblSalequantity);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cboxDiscount);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.txtdiscount);
            this.panel2.Controls.Add(this.lblAddress);
            this.panel2.Controls.Add(this.lblproductName);
            this.panel2.Controls.Add(this.lblStoreName);
            this.panel2.Controls.Add(this.pboxProduct);
            this.panel2.Location = new System.Drawing.Point(374, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 515);
            this.panel2.TabIndex = 35;
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(311, 274);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(59, 22);
            this.txtstock.TabIndex = 46;
            // 
            // lblfav
            // 
            this.lblfav.AutoSize = true;
            this.lblfav.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblfav.Location = new System.Drawing.Point(354, 43);
            this.lblfav.Name = "lblfav";
            this.lblfav.Size = new System.Drawing.Size(16, 17);
            this.lblfav.TabIndex = 45;
            this.lblfav.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(229, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "庫存剩餘數:";
            // 
            // lblFavoriteQuantity
            // 
            this.lblFavoriteQuantity.AutoSize = true;
            this.lblFavoriteQuantity.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFavoriteQuantity.Location = new System.Drawing.Point(266, 43);
            this.lblFavoriteQuantity.Name = "lblFavoriteQuantity";
            this.lblFavoriteQuantity.Size = new System.Drawing.Size(63, 17);
            this.lblFavoriteQuantity.TabIndex = 45;
            this.lblFavoriteQuantity.Text = "被收藏數:";
            // 
            // lblsold
            // 
            this.lblsold.AutoSize = true;
            this.lblsold.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblsold.Location = new System.Drawing.Point(354, 14);
            this.lblsold.Name = "lblsold";
            this.lblsold.Size = new System.Drawing.Size(16, 17);
            this.lblsold.TabIndex = 44;
            this.lblsold.Text = "0";
            // 
            // lblSalequantity
            // 
            this.lblSalequantity.AutoSize = true;
            this.lblSalequantity.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSalequantity.Location = new System.Drawing.Point(266, 14);
            this.lblSalequantity.Name = "lblSalequantity";
            this.lblSalequantity.Size = new System.Drawing.Size(50, 17);
            this.lblSalequantity.TabIndex = 44;
            this.lblSalequantity.Text = "已售出:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(331, 452);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(72, 34);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "儲存";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(297, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "NT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(190, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(235, 459);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(56, 22);
            this.txtPrice.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(156, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "折";
            // 
            // cboxDiscount
            // 
            this.cboxDiscount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxDiscount.Location = new System.Drawing.Point(8, 459);
            this.cboxDiscount.Name = "cboxDiscount";
            this.cboxDiscount.Size = new System.Drawing.Size(95, 26);
            this.cboxDiscount.TabIndex = 39;
            this.cboxDiscount.Text = "discount";
            this.cboxDiscount.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDescription.Location = new System.Drawing.Point(9, 309);
            this.txtDescription.MaxLength = 120;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(361, 118);
            this.txtDescription.TabIndex = 38;
            this.txtDescription.Text = "滷肉飯";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtdiscount.Location = new System.Drawing.Point(109, 461);
            this.txtdiscount.MaxLength = 3;
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(41, 25);
            this.txtdiscount.TabIndex = 37;
            this.txtdiscount.Text = "10";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAddress.Location = new System.Drawing.Point(13, 45);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(128, 16);
            this.lblAddress.TabIndex = 35;
            this.lblAddress.Text = "高雄市左營區左營大路";
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStoreName.Location = new System.Drawing.Point(6, 14);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(110, 31);
            this.lblStoreName.TabIndex = 35;
            this.lblStoreName.Text = "商店名稱";
            // 
            // pboxProduct
            // 
            this.pboxProduct.Location = new System.Drawing.Point(0, 77);
            this.pboxProduct.Name = "pboxProduct";
            this.pboxProduct.Size = new System.Drawing.Size(416, 187);
            this.pboxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxProduct.TabIndex = 34;
            this.pboxProduct.TabStop = false;
            this.pboxProduct.Click += new System.EventHandler(this.pboxProduct_Click);
            // 
            // lblproductName
            // 
            this.lblproductName.AutoSize = true;
            this.lblproductName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblproductName.Location = new System.Drawing.Point(10, 268);
            this.lblproductName.Name = "lblproductName";
            this.lblproductName.Size = new System.Drawing.Size(96, 26);
            this.lblproductName.TabIndex = 35;
            this.lblproductName.Text = "商品名稱";
            // 
            // storeIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(789, 646);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "storeIndex";
            this.Text = "storeIndex";
            this.Load += new System.EventHandler(this.storeIndex_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.PictureBox pboxProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cboxDiscount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblfav;
        private System.Windows.Forms.Label lblFavoriteQuantity;
        private System.Windows.Forms.Label lblsold;
        private System.Windows.Forms.Label lblSalequantity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblproductName;
    }
}