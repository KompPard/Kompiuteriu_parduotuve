namespace Kompiuteriu_parduotuve
{
    partial class Main_Form
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
            this.cart_Datagrid = new System.Windows.Forms.DataGridView();
            this.cart_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_item_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.add_to_cart_button = new System.Windows.Forms.Button();
            this.order_button = new System.Windows.Forms.Button();
            this.main_tab = new System.Windows.Forms.TabControl();
            this.products_tab = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.cart_tab = new System.Windows.Forms.TabPage();
            this.clear_cart_button = new System.Windows.Forms.Button();
            this.search_tab = new System.Windows.Forms.TabPage();
            this.search_button = new System.Windows.Forms.Button();
            this.search_category_box = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.search_name_box = new System.Windows.Forms.TextBox();
            this.search_add_to_cart_button = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.search_results_desc_box = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.search_results_Datagrid = new System.Windows.Forms.DataGridView();
            this.search_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contacts_tab = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.product1_box = new System.Windows.Forms.RichTextBox();
            this.product2_box = new System.Windows.Forms.RichTextBox();
            this.swap_button = new System.Windows.Forms.Button();
            this.compare_box = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.compare_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.products_Datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart_Datagrid)).BeginInit();
            this.main_tab.SuspendLayout();
            this.products_tab.SuspendLayout();
            this.cart_tab.SuspendLayout();
            this.search_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_results_Datagrid)).BeginInit();
            this.contacts_tab.SuspendLayout();
            this.compare_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(531, 12);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(100, 23);
            this.Login_button.TabIndex = 0;
            this.Login_button.Text = "Administravimas";
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
            this.products_Datagrid.Location = new System.Drawing.Point(6, 43);
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
            this.name.HeaderText = "Pavadinimas";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // category
            // 
            this.category.HeaderText = "Kategorija";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Kaina";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // description
            // 
            this.description.HeaderText = "Aprašymas";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Visible = false;
            // 
            // products_description
            // 
            this.products_description.Location = new System.Drawing.Point(6, 300);
            this.products_description.Name = "products_description";
            this.products_description.ReadOnly = true;
            this.products_description.Size = new System.Drawing.Size(343, 107);
            this.products_description.TabIndex = 2;
            this.products_description.Text = "";
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(428, 281);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(176, 20);
            this.username_textbox.TabIndex = 3;
            // 
            // comment_textbox
            // 
            this.comment_textbox.Location = new System.Drawing.Point(428, 307);
            this.comment_textbox.Name = "comment_textbox";
            this.comment_textbox.Size = new System.Drawing.Size(175, 123);
            this.comment_textbox.TabIndex = 4;
            this.comment_textbox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jūsų vardas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Komentaras:";
            // 
            // confirm_comment
            // 
            this.confirm_comment.Location = new System.Drawing.Point(427, 436);
            this.confirm_comment.Name = "confirm_comment";
            this.confirm_comment.Size = new System.Drawing.Size(176, 23);
            this.confirm_comment.TabIndex = 7;
            this.confirm_comment.Text = "Komentuoti";
            this.confirm_comment.UseVisualStyleBackColor = true;
            this.confirm_comment.Click += new System.EventHandler(this.confirm_comment_Click);
            // 
            // user_comments
            // 
            this.user_comments.Location = new System.Drawing.Point(355, 43);
            this.user_comments.Name = "user_comments";
            this.user_comments.ReadOnly = true;
            this.user_comments.Size = new System.Drawing.Size(249, 238);
            this.user_comments.TabIndex = 8;
            this.user_comments.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prekės apibūdinimas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pirkėjų nuomonė apie šią prekę:";
            // 
            // user_reviews
            // 
            this.user_reviews.Location = new System.Drawing.Point(288, 59);
            this.user_reviews.Name = "user_reviews";
            this.user_reviews.ReadOnly = true;
            this.user_reviews.Size = new System.Drawing.Size(265, 204);
            this.user_reviews.TabIndex = 11;
            this.user_reviews.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pirkėjų nuomonė apie aplikaciją:";
            // 
            // confirm_review
            // 
            this.confirm_review.Location = new System.Drawing.Point(378, 424);
            this.confirm_review.Name = "confirm_review";
            this.confirm_review.Size = new System.Drawing.Size(175, 23);
            this.confirm_review.TabIndex = 17;
            this.confirm_review.Text = "Palikti atsiliepimą";
            this.confirm_review.UseVisualStyleBackColor = true;
            this.confirm_review.Click += new System.EventHandler(this.confirm_review_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Atsiliepimas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Vartotojo vardas:";
            // 
            // review_message_textbox
            // 
            this.review_message_textbox.Location = new System.Drawing.Point(378, 295);
            this.review_message_textbox.Name = "review_message_textbox";
            this.review_message_textbox.Size = new System.Drawing.Size(175, 123);
            this.review_message_textbox.TabIndex = 14;
            this.review_message_textbox.Text = "";
            // 
            // review_username_textbox
            // 
            this.review_username_textbox.Location = new System.Drawing.Point(378, 269);
            this.review_username_textbox.Name = "review_username_textbox";
            this.review_username_textbox.Size = new System.Drawing.Size(175, 20);
            this.review_username_textbox.TabIndex = 13;
            // 
            // contacts_box
            // 
            this.contacts_box.Location = new System.Drawing.Point(53, 59);
            this.contacts_box.Name = "contacts_box";
            this.contacts_box.ReadOnly = true;
            this.contacts_box.Size = new System.Drawing.Size(229, 123);
            this.contacts_box.TabIndex = 18;
            this.contacts_box.Text = "";
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
            this.cart_Datagrid.Location = new System.Drawing.Point(79, 90);
            this.cart_Datagrid.Name = "cart_Datagrid";
            this.cart_Datagrid.ReadOnly = true;
            this.cart_Datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cart_Datagrid.Size = new System.Drawing.Size(467, 150);
            this.cart_Datagrid.TabIndex = 20;
            this.cart_Datagrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.cart_Datagrid_RowsRemoved);
            // 
            // cart_product_name
            // 
            this.cart_product_name.HeaderText = "Prekės pavadinimas";
            this.cart_product_name.Name = "cart_product_name";
            this.cart_product_name.ReadOnly = true;
            this.cart_product_name.Width = 220;
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
            this.quantity.HeaderText = "Kiekis";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // cart_item_price
            // 
            this.cart_item_price.HeaderText = "Suma";
            this.cart_item_price.Name = "cart_item_price";
            this.cart_item_price.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Prekių krepšelis:";
            // 
            // add_to_cart_button
            // 
            this.add_to_cart_button.Location = new System.Drawing.Point(242, 413);
            this.add_to_cart_button.Name = "add_to_cart_button";
            this.add_to_cart_button.Size = new System.Drawing.Size(107, 46);
            this.add_to_cart_button.TabIndex = 22;
            this.add_to_cart_button.Text = "Pridėti pasirinktą prekę į krepšelį";
            this.add_to_cart_button.UseVisualStyleBackColor = true;
            this.add_to_cart_button.Click += new System.EventHandler(this.add_to_cart_button_Click);
            // 
            // order_button
            // 
            this.order_button.Location = new System.Drawing.Point(442, 246);
            this.order_button.Name = "order_button";
            this.order_button.Size = new System.Drawing.Size(104, 39);
            this.order_button.TabIndex = 24;
            this.order_button.Text = "Pateikti užsakymą";
            this.order_button.UseVisualStyleBackColor = true;
            this.order_button.Click += new System.EventHandler(this.order_button_Click);
            // 
            // main_tab
            // 
            this.main_tab.Controls.Add(this.products_tab);
            this.main_tab.Controls.Add(this.cart_tab);
            this.main_tab.Controls.Add(this.search_tab);
            this.main_tab.Controls.Add(this.contacts_tab);
            this.main_tab.Location = new System.Drawing.Point(12, 41);
            this.main_tab.Name = "main_tab";
            this.main_tab.SelectedIndex = 0;
            this.main_tab.Size = new System.Drawing.Size(623, 519);
            this.main_tab.TabIndex = 25;
            // 
            // products_tab
            // 
            this.products_tab.Controls.Add(this.label10);
            this.products_tab.Controls.Add(this.products_Datagrid);
            this.products_tab.Controls.Add(this.label4);
            this.products_tab.Controls.Add(this.products_description);
            this.products_tab.Controls.Add(this.label3);
            this.products_tab.Controls.Add(this.user_comments);
            this.products_tab.Controls.Add(this.username_textbox);
            this.products_tab.Controls.Add(this.add_to_cart_button);
            this.products_tab.Controls.Add(this.comment_textbox);
            this.products_tab.Controls.Add(this.label1);
            this.products_tab.Controls.Add(this.label2);
            this.products_tab.Controls.Add(this.confirm_comment);
            this.products_tab.Location = new System.Drawing.Point(4, 22);
            this.products_tab.Name = "products_tab";
            this.products_tab.Padding = new System.Windows.Forms.Padding(3);
            this.products_tab.Size = new System.Drawing.Size(615, 493);
            this.products_tab.TabIndex = 0;
            this.products_tab.Text = "Prekių katalogas";
            this.products_tab.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Prekių katalogas:";
            // 
            // cart_tab
            // 
            this.cart_tab.Controls.Add(this.clear_cart_button);
            this.cart_tab.Controls.Add(this.label9);
            this.cart_tab.Controls.Add(this.order_button);
            this.cart_tab.Controls.Add(this.cart_Datagrid);
            this.cart_tab.Location = new System.Drawing.Point(4, 22);
            this.cart_tab.Name = "cart_tab";
            this.cart_tab.Padding = new System.Windows.Forms.Padding(3);
            this.cart_tab.Size = new System.Drawing.Size(615, 493);
            this.cart_tab.TabIndex = 1;
            this.cart_tab.Text = "Krepšelis";
            this.cart_tab.UseVisualStyleBackColor = true;
            // 
            // clear_cart_button
            // 
            this.clear_cart_button.Location = new System.Drawing.Point(79, 246);
            this.clear_cart_button.Name = "clear_cart_button";
            this.clear_cart_button.Size = new System.Drawing.Size(104, 39);
            this.clear_cart_button.TabIndex = 25;
            this.clear_cart_button.Text = "Išvalyti krepšelį";
            this.clear_cart_button.UseVisualStyleBackColor = true;
            this.clear_cart_button.Click += new System.EventHandler(this.clear_cart_button_Click);
            // 
            // search_tab
            // 
            this.search_tab.Controls.Add(this.compare_button);
            this.search_tab.Controls.Add(this.compare_box);
            this.search_tab.Controls.Add(this.search_button);
            this.search_tab.Controls.Add(this.search_category_box);
            this.search_tab.Controls.Add(this.label14);
            this.search_tab.Controls.Add(this.label13);
            this.search_tab.Controls.Add(this.search_name_box);
            this.search_tab.Controls.Add(this.search_add_to_cart_button);
            this.search_tab.Controls.Add(this.label12);
            this.search_tab.Controls.Add(this.search_results_desc_box);
            this.search_tab.Controls.Add(this.label11);
            this.search_tab.Controls.Add(this.search_results_Datagrid);
            this.search_tab.Location = new System.Drawing.Point(4, 22);
            this.search_tab.Name = "search_tab";
            this.search_tab.Padding = new System.Windows.Forms.Padding(3);
            this.search_tab.Size = new System.Drawing.Size(615, 493);
            this.search_tab.TabIndex = 3;
            this.search_tab.Text = "Paieška / Palyginimas";
            this.search_tab.UseVisualStyleBackColor = true;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(414, 38);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 28;
            this.search_button.Text = "Ieškoti";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // search_category_box
            // 
            this.search_category_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.search_category_box.FormattingEnabled = true;
            this.search_category_box.Location = new System.Drawing.Point(287, 40);
            this.search_category_box.Name = "search_category_box";
            this.search_category_box.Size = new System.Drawing.Size(121, 21);
            this.search_category_box.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(284, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Kategorija:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(109, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Pavadinimas:";
            // 
            // search_name_box
            // 
            this.search_name_box.Location = new System.Drawing.Point(112, 40);
            this.search_name_box.Name = "search_name_box";
            this.search_name_box.Size = new System.Drawing.Size(169, 20);
            this.search_name_box.TabIndex = 24;
            // 
            // search_add_to_cart_button
            // 
            this.search_add_to_cart_button.Location = new System.Drawing.Point(243, 245);
            this.search_add_to_cart_button.Name = "search_add_to_cart_button";
            this.search_add_to_cart_button.Size = new System.Drawing.Size(107, 46);
            this.search_add_to_cart_button.TabIndex = 23;
            this.search_add_to_cart_button.Text = "Pridėti pasirinktą prekę į krepšelį";
            this.search_add_to_cart_button.UseVisualStyleBackColor = true;
            this.search_add_to_cart_button.Click += new System.EventHandler(this.search_add_to_cart_button_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(353, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Prekės apibūdinimas:";
            // 
            // search_results_desc_box
            // 
            this.search_results_desc_box.Location = new System.Drawing.Point(356, 89);
            this.search_results_desc_box.Name = "search_results_desc_box";
            this.search_results_desc_box.ReadOnly = true;
            this.search_results_desc_box.Size = new System.Drawing.Size(253, 150);
            this.search_results_desc_box.TabIndex = 2;
            this.search_results_desc_box.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Paieškos rezultatai:";
            // 
            // search_results_Datagrid
            // 
            this.search_results_Datagrid.AllowUserToAddRows = false;
            this.search_results_Datagrid.AllowUserToDeleteRows = false;
            this.search_results_Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.search_results_Datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.search_id,
            this.search_name,
            this.search_category,
            this.search_price,
            this.search_description});
            this.search_results_Datagrid.Location = new System.Drawing.Point(6, 89);
            this.search_results_Datagrid.Name = "search_results_Datagrid";
            this.search_results_Datagrid.ReadOnly = true;
            this.search_results_Datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.search_results_Datagrid.Size = new System.Drawing.Size(344, 150);
            this.search_results_Datagrid.TabIndex = 0;
            this.search_results_Datagrid.SelectionChanged += new System.EventHandler(this.search_results_Datagrid_SelectionChanged);
            // 
            // search_id
            // 
            this.search_id.HeaderText = "ID";
            this.search_id.Name = "search_id";
            this.search_id.ReadOnly = true;
            this.search_id.Visible = false;
            // 
            // search_name
            // 
            this.search_name.HeaderText = "Pavadinimas";
            this.search_name.Name = "search_name";
            this.search_name.ReadOnly = true;
            // 
            // search_category
            // 
            this.search_category.HeaderText = "Kategorija";
            this.search_category.Name = "search_category";
            this.search_category.ReadOnly = true;
            // 
            // search_price
            // 
            this.search_price.HeaderText = "Kaina";
            this.search_price.Name = "search_price";
            this.search_price.ReadOnly = true;
            // 
            // search_description
            // 
            this.search_description.HeaderText = "Aprašymas";
            this.search_description.Name = "search_description";
            this.search_description.ReadOnly = true;
            this.search_description.Visible = false;
            // 
            // contacts_tab
            // 
            this.contacts_tab.Controls.Add(this.label8);
            this.contacts_tab.Controls.Add(this.label5);
            this.contacts_tab.Controls.Add(this.user_reviews);
            this.contacts_tab.Controls.Add(this.review_username_textbox);
            this.contacts_tab.Controls.Add(this.contacts_box);
            this.contacts_tab.Controls.Add(this.label7);
            this.contacts_tab.Controls.Add(this.confirm_review);
            this.contacts_tab.Controls.Add(this.review_message_textbox);
            this.contacts_tab.Controls.Add(this.label6);
            this.contacts_tab.Location = new System.Drawing.Point(4, 22);
            this.contacts_tab.Name = "contacts_tab";
            this.contacts_tab.Padding = new System.Windows.Forms.Padding(3);
            this.contacts_tab.Size = new System.Drawing.Size(615, 493);
            this.contacts_tab.TabIndex = 2;
            this.contacts_tab.Text = "Kontaktai";
            this.contacts_tab.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Kontaktiniai duomenys:";
            // 
            // product1_box
            // 
            this.product1_box.Location = new System.Drawing.Point(9, 42);
            this.product1_box.Name = "product1_box";
            this.product1_box.Size = new System.Drawing.Size(178, 105);
            this.product1_box.TabIndex = 29;
            this.product1_box.Text = "";
            // 
            // product2_box
            // 
            this.product2_box.Location = new System.Drawing.Point(328, 42);
            this.product2_box.Name = "product2_box";
            this.product2_box.Size = new System.Drawing.Size(178, 105);
            this.product2_box.TabIndex = 30;
            this.product2_box.Text = "";
            // 
            // swap_button
            // 
            this.swap_button.Location = new System.Drawing.Point(221, 79);
            this.swap_button.Name = "swap_button";
            this.swap_button.Size = new System.Drawing.Size(75, 23);
            this.swap_button.TabIndex = 32;
            this.swap_button.Text = "Apkeisti";
            this.swap_button.UseVisualStyleBackColor = true;
            this.swap_button.Click += new System.EventHandler(this.swap_button_Click);
            // 
            // compare_box
            // 
            this.compare_box.Controls.Add(this.label15);
            this.compare_box.Controls.Add(this.product1_box);
            this.compare_box.Controls.Add(this.swap_button);
            this.compare_box.Controls.Add(this.product2_box);
            this.compare_box.Location = new System.Drawing.Point(54, 297);
            this.compare_box.Name = "compare_box";
            this.compare_box.Size = new System.Drawing.Size(512, 164);
            this.compare_box.TabIndex = 33;
            this.compare_box.TabStop = false;
            this.compare_box.Text = "Produktų palyginimas";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(385, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Paieškos lange pasirinkite dvi prekes ir spauskite mygtuką \"Palyginti pasirinktas" +
    "\"";
            // 
            // compare_button
            // 
            this.compare_button.Location = new System.Drawing.Point(6, 245);
            this.compare_button.Name = "compare_button";
            this.compare_button.Size = new System.Drawing.Size(107, 46);
            this.compare_button.TabIndex = 34;
            this.compare_button.Text = "Palyginti pasirinktas";
            this.compare_button.UseVisualStyleBackColor = true;
            this.compare_button.Click += new System.EventHandler(this.compare_button_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 571);
            this.Controls.Add(this.main_tab);
            this.Controls.Add(this.Login_button);
            this.Name = "Main_Form";
            this.Text = "Kompiuterių parduotuvė";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.products_Datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart_Datagrid)).EndInit();
            this.main_tab.ResumeLayout(false);
            this.products_tab.ResumeLayout(false);
            this.products_tab.PerformLayout();
            this.cart_tab.ResumeLayout(false);
            this.cart_tab.PerformLayout();
            this.search_tab.ResumeLayout(false);
            this.search_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_results_Datagrid)).EndInit();
            this.contacts_tab.ResumeLayout(false);
            this.contacts_tab.PerformLayout();
            this.compare_box.ResumeLayout(false);
            this.compare_box.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView cart_Datagrid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button add_to_cart_button;
        private System.Windows.Forms.Button order_button;
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
        private System.Windows.Forms.TabControl main_tab;
        private System.Windows.Forms.TabPage products_tab;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage cart_tab;
        private System.Windows.Forms.Button clear_cart_button;
        private System.Windows.Forms.TabPage contacts_tab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage search_tab;
        private System.Windows.Forms.Button search_add_to_cart_button;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox search_results_desc_box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView search_results_Datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn search_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn search_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn search_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn search_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn search_description;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.ComboBox search_category_box;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox search_name_box;
        private System.Windows.Forms.Button compare_button;
        private System.Windows.Forms.GroupBox compare_box;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox product1_box;
        private System.Windows.Forms.Button swap_button;
        private System.Windows.Forms.RichTextBox product2_box;
    }
}

