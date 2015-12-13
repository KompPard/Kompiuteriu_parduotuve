namespace Kompiuteriu_parduotuve
{
    partial class Form1
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
            this.Login_button = new System.Windows.Forms.Button();
            this.products_Datagrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products_description = new System.Windows.Forms.RichTextBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.comment_textbox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.confirm_comment = new System.Windows.Forms.Button();
            this.user_comments = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.user_reviews = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.confirm_review = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.review_message_textbox = new System.Windows.Forms.RichTextBox();
            this.review_username_textbox = new System.Windows.Forms.TextBox();
            this.contacts_box = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cart_Datagrid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.add_to_cart_button = new System.Windows.Forms.Button();
            this.add_to_cart_label = new System.Windows.Forms.Label();
            this.cart_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_item_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.products_Datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart_Datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(1186, 2);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(75, 23);
            this.Login_button.TabIndex = 0;
            this.Login_button.Text = "Prisijungti";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // products_Datagrid
            // 
            this.products_Datagrid.AllowUserToAddRows = false;
            this.products_Datagrid.AllowUserToDeleteRows = false;
            this.products_Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products_Datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.category,
            this.price,
            this.description});
            this.products_Datagrid.Location = new System.Drawing.Point(12, 2);
            this.products_Datagrid.Name = "products_Datagrid";
            this.products_Datagrid.ReadOnly = true;
            this.products_Datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.products_Datagrid.Size = new System.Drawing.Size(343, 238);
            this.products_Datagrid.TabIndex = 1;
            this.products_Datagrid.SelectionChanged += new System.EventHandler(this.products_Datagrid_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Visible = false;
            // 
            // products_description
            // 
            this.products_description.Location = new System.Drawing.Point(361, 24);
            this.products_description.Name = "products_description";
            this.products_description.ReadOnly = true;
            this.products_description.Size = new System.Drawing.Size(175, 216);
            this.products_description.TabIndex = 2;
            this.products_description.Text = "";
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(100, 246);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(176, 20);
            this.username_textbox.TabIndex = 3;
            // 
            // comment_textbox
            // 
            this.comment_textbox.Location = new System.Drawing.Point(100, 272);
            this.comment_textbox.Name = "comment_textbox";
            this.comment_textbox.Size = new System.Drawing.Size(175, 123);
            this.comment_textbox.TabIndex = 4;
            this.comment_textbox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vartotojo vardas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Komentaras";
            // 
            // confirm_comment
            // 
            this.confirm_comment.Location = new System.Drawing.Point(100, 402);
            this.confirm_comment.Name = "confirm_comment";
            this.confirm_comment.Size = new System.Drawing.Size(176, 23);
            this.confirm_comment.TabIndex = 7;
            this.confirm_comment.Text = "Įvęsti komentarą";
            this.confirm_comment.UseVisualStyleBackColor = true;
            this.confirm_comment.Click += new System.EventHandler(this.confirm_comment_Click);
            // 
            // user_comments
            // 
            this.user_comments.Location = new System.Drawing.Point(542, 24);
            this.user_comments.Name = "user_comments";
            this.user_comments.ReadOnly = true;
            this.user_comments.Size = new System.Drawing.Size(175, 216);
            this.user_comments.TabIndex = 8;
            this.user_comments.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prekės apibūdinimas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pirkėjų nuomonė apie prekę";
            // 
            // user_reviews
            // 
            this.user_reviews.Location = new System.Drawing.Point(1005, 24);
            this.user_reviews.Name = "user_reviews";
            this.user_reviews.ReadOnly = true;
            this.user_reviews.Size = new System.Drawing.Size(175, 216);
            this.user_reviews.TabIndex = 11;
            this.user_reviews.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1012, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pirkėjų nuomonė apie aplikaciją";
            // 
            // confirm_review
            // 
            this.confirm_review.Location = new System.Drawing.Point(1055, 432);
            this.confirm_review.Name = "confirm_review";
            this.confirm_review.Size = new System.Drawing.Size(176, 23);
            this.confirm_review.TabIndex = 17;
            this.confirm_review.Text = "Įvęsti Atsiliepimą";
            this.confirm_review.UseVisualStyleBackColor = true;
            this.confirm_review.Click += new System.EventHandler(this.confirm_review_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(964, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Atsiliepimas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(964, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Vartotojo vardas";
            // 
            // review_message_textbox
            // 
            this.review_message_textbox.Location = new System.Drawing.Point(1055, 302);
            this.review_message_textbox.Name = "review_message_textbox";
            this.review_message_textbox.Size = new System.Drawing.Size(175, 123);
            this.review_message_textbox.TabIndex = 14;
            this.review_message_textbox.Text = "";
            // 
            // review_username_textbox
            // 
            this.review_username_textbox.Location = new System.Drawing.Point(1055, 276);
            this.review_username_textbox.Name = "review_username_textbox";
            this.review_username_textbox.Size = new System.Drawing.Size(176, 20);
            this.review_username_textbox.TabIndex = 13;
            // 
            // contacts_box
            // 
            this.contacts_box.Location = new System.Drawing.Point(282, 359);
            this.contacts_box.Name = "contacts_box";
            this.contacts_box.ReadOnly = true;
            this.contacts_box.Size = new System.Drawing.Size(156, 96);
            this.contacts_box.TabIndex = 18;
            this.contacts_box.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Kontaktai";
            // 
            // cart_Datagrid
            // 
            this.cart_Datagrid.AllowUserToAddRows = false;
            this.cart_Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cart_Datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cart_product_name,
            this.cart_item_id,
            this.product_id,
            this.quantity,
            this.cart_item_price});
            this.cart_Datagrid.Location = new System.Drawing.Point(444, 305);
            this.cart_Datagrid.Name = "cart_Datagrid";
            this.cart_Datagrid.ReadOnly = true;
            this.cart_Datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cart_Datagrid.Size = new System.Drawing.Size(345, 150);
            this.cart_Datagrid.TabIndex = 20;
            this.cart_Datagrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.cart_Datagrid_RowsRemoved);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(444, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Prekių krepšelis";
            // 
            // add_to_cart_button
            // 
            this.add_to_cart_button.Location = new System.Drawing.Point(285, 246);
            this.add_to_cart_button.Name = "add_to_cart_button";
            this.add_to_cart_button.Size = new System.Drawing.Size(75, 50);
            this.add_to_cart_button.TabIndex = 22;
            this.add_to_cart_button.Text = "Pridėti pasirinktą į krepšelį";
            this.add_to_cart_button.UseVisualStyleBackColor = true;
            this.add_to_cart_button.Click += new System.EventHandler(this.add_to_cart_button_Click);
            // 
            // add_to_cart_label
            // 
            this.add_to_cart_label.AutoSize = true;
            this.add_to_cart_label.Location = new System.Drawing.Point(285, 304);
            this.add_to_cart_label.Name = "add_to_cart_label";
            this.add_to_cart_label.Size = new System.Drawing.Size(0, 13);
            this.add_to_cart_label.TabIndex = 23;
            // 
            // cart_product_name
            // 
            this.cart_product_name.HeaderText = "Name";
            this.cart_product_name.Name = "cart_product_name";
            this.cart_product_name.ReadOnly = true;
            // 
            // cart_item_id
            // 
            this.cart_item_id.HeaderText = "ID";
            this.cart_item_id.Name = "cart_item_id";
            this.cart_item_id.ReadOnly = true;
            this.cart_item_id.Visible = false;
            // 
            // product_id
            // 
            this.product_id.HeaderText = "Product_ID";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Visible = false;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // cart_item_price
            // 
            this.cart_item_price.HeaderText = "Price";
            this.cart_item_price.Name = "cart_item_price";
            this.cart_item_price.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 473);
            this.Controls.Add(this.add_to_cart_label);
            this.Controls.Add(this.add_to_cart_button);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cart_Datagrid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.contacts_box);
            this.Controls.Add(this.confirm_review);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.review_message_textbox);
            this.Controls.Add(this.review_username_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.user_reviews);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.user_comments);
            this.Controls.Add(this.confirm_comment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comment_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.products_description);
            this.Controls.Add(this.products_Datagrid);
            this.Controls.Add(this.Login_button);
            this.Name = "Form1";
            this.Text = "Kompiuterių parduotuvė";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.products_Datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart_Datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.DataGridView products_Datagrid;
        private System.Windows.Forms.RichTextBox products_description;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.RichTextBox comment_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirm_comment;
        private System.Windows.Forms.RichTextBox user_comments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox user_reviews;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button confirm_review;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox review_message_textbox;
        private System.Windows.Forms.TextBox review_username_textbox;
        private System.Windows.Forms.RichTextBox contacts_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView cart_Datagrid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button add_to_cart_button;
        private System.Windows.Forms.Label add_to_cart_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_item_price;
    }
}

