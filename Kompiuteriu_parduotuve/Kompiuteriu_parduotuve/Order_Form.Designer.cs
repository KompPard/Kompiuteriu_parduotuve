namespace Kompiuteriu_parduotuve
{
    partial class Order_Form
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
            this.card_number_textbox = new System.Windows.Forms.TextBox();
            this.exp_year_textbox = new System.Windows.Forms.TextBox();
            this.exp_month_textbox = new System.Windows.Forms.TextBox();
            this.cvc_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.save_order_button = new System.Windows.Forms.Button();
            this.cancel_order_button = new System.Windows.Forms.Button();
            this.order_cart_Datagrid = new System.Windows.Forms.DataGridView();
            this.total_price_label = new System.Windows.Forms.Label();
            this.cart_guid_label = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.order_cart_Datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // card_number_textbox
            // 
            this.card_number_textbox.Location = new System.Drawing.Point(111, 181);
            this.card_number_textbox.Name = "card_number_textbox";
            this.card_number_textbox.Size = new System.Drawing.Size(100, 20);
            this.card_number_textbox.TabIndex = 0;
            // 
            // exp_year_textbox
            // 
            this.exp_year_textbox.Location = new System.Drawing.Point(111, 207);
            this.exp_year_textbox.Name = "exp_year_textbox";
            this.exp_year_textbox.Size = new System.Drawing.Size(100, 20);
            this.exp_year_textbox.TabIndex = 1;
            // 
            // exp_month_textbox
            // 
            this.exp_month_textbox.Location = new System.Drawing.Point(111, 233);
            this.exp_month_textbox.Name = "exp_month_textbox";
            this.exp_month_textbox.Size = new System.Drawing.Size(100, 20);
            this.exp_month_textbox.TabIndex = 2;
            // 
            // cvc_textbox
            // 
            this.cvc_textbox.Location = new System.Drawing.Point(111, 259);
            this.cvc_textbox.Name = "cvc_textbox";
            this.cvc_textbox.Size = new System.Drawing.Size(100, 20);
            this.cvc_textbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kortelės nr.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Galiojimo metai:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Galiojimo mėnuo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CVC:";
            // 
            // save_order_button
            // 
            this.save_order_button.Location = new System.Drawing.Point(292, 303);
            this.save_order_button.Name = "save_order_button";
            this.save_order_button.Size = new System.Drawing.Size(75, 23);
            this.save_order_button.TabIndex = 8;
            this.save_order_button.Text = "Užsakyti";
            this.save_order_button.UseVisualStyleBackColor = true;
            this.save_order_button.Click += new System.EventHandler(this.save_order_button_Click);
            // 
            // cancel_order_button
            // 
            this.cancel_order_button.Location = new System.Drawing.Point(136, 303);
            this.cancel_order_button.Name = "cancel_order_button";
            this.cancel_order_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_order_button.TabIndex = 9;
            this.cancel_order_button.Text = "Atgal";
            this.cancel_order_button.UseVisualStyleBackColor = true;
            this.cancel_order_button.Click += new System.EventHandler(this.cancel_order_button_Click);
            // 
            // order_cart_Datagrid
            // 
            this.order_cart_Datagrid.AllowUserToAddRows = false;
            this.order_cart_Datagrid.AllowUserToDeleteRows = false;
            this.order_cart_Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_cart_Datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.product_id,
            this.cart_id,
            this.quantity,
            this.price});
            this.order_cart_Datagrid.Location = new System.Drawing.Point(12, 25);
            this.order_cart_Datagrid.Name = "order_cart_Datagrid";
            this.order_cart_Datagrid.ReadOnly = true;
            this.order_cart_Datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.order_cart_Datagrid.Size = new System.Drawing.Size(470, 150);
            this.order_cart_Datagrid.TabIndex = 10;
            // 
            // total_price_label
            // 
            this.total_price_label.AutoSize = true;
            this.total_price_label.Location = new System.Drawing.Point(392, 210);
            this.total_price_label.Name = "total_price_label";
            this.total_price_label.Size = new System.Drawing.Size(40, 13);
            this.total_price_label.TabIndex = 11;
            this.total_price_label.Text = "Iš viso:";
            // 
            // cart_guid_label
            // 
            this.cart_guid_label.AutoSize = true;
            this.cart_guid_label.Location = new System.Drawing.Point(217, 184);
            this.cart_guid_label.Name = "cart_guid_label";
            this.cart_guid_label.Size = new System.Drawing.Size(77, 13);
            this.cart_guid_label.TabIndex = 12;
            this.cart_guid_label.Text = "Užsakymo nr.: ";
            // 
            // name
            // 
            this.name.HeaderText = "Pavadinimas";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 220;
            // 
            // product_id
            // 
            this.product_id.HeaderText = "ID";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Visible = false;
            // 
            // cart_id
            // 
            this.cart_id.HeaderText = "Cart GUID";
            this.cart_id.Name = "cart_id";
            this.cart_id.ReadOnly = true;
            this.cart_id.Visible = false;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Kiekis";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Suma";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Prekių sąrašas:";
            // 
            // Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 341);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cart_guid_label);
            this.Controls.Add(this.total_price_label);
            this.Controls.Add(this.order_cart_Datagrid);
            this.Controls.Add(this.cancel_order_button);
            this.Controls.Add(this.save_order_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cvc_textbox);
            this.Controls.Add(this.exp_month_textbox);
            this.Controls.Add(this.exp_year_textbox);
            this.Controls.Add(this.card_number_textbox);
            this.Name = "Order_Form";
            this.Text = "Pateikti užsakymą";
            this.Load += new System.EventHandler(this.Order_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.order_cart_Datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox card_number_textbox;
        private System.Windows.Forms.TextBox exp_year_textbox;
        private System.Windows.Forms.TextBox exp_month_textbox;
        private System.Windows.Forms.TextBox cvc_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button save_order_button;
        private System.Windows.Forms.Button cancel_order_button;
        private System.Windows.Forms.DataGridView order_cart_Datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Label total_price_label;
        private System.Windows.Forms.Label cart_guid_label;
        private System.Windows.Forms.Label label5;
    }
}