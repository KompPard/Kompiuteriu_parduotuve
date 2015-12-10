namespace Kompiuteriu_parduotuve
{
    partial class Admin_form
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
            this.button1 = new System.Windows.Forms.Button();
            this.confirm_worker_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.hide_button = new System.Windows.Forms.Button();
            this.type_textbox = new System.Windows.Forms.TextBox();
            this.ID_textbox = new System.Windows.Forms.TextBox();
            this.product_grid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_description_textbox = new System.Windows.Forms.RichTextBox();
            this.product_name_textbox = new System.Windows.Forms.TextBox();
            this.product_price_textbox = new System.Windows.Forms.TextBox();
            this.product_confirm = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.category_id_textobx = new System.Windows.Forms.TextBox();
            this.category_name_textbox = new System.Windows.Forms.TextBox();
            this.confirm_category = new System.Windows.Forms.Button();
            this.update_category = new System.Windows.Forms.Button();
            this.product_category_comb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.to_main_form = new System.Windows.Forms.Button();
            this.product_comment_datagrid = new System.Windows.Forms.DataGridView();
            this.iden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.delete_comment_button = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.review_datagrid = new System.Windows.Forms.DataGridView();
            this.identifikatorius = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorius = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atsiliepimas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete_review_button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.product_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_comment_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.review_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(840, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kurti nauja vartotoja";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirm_worker_button
            // 
            this.confirm_worker_button.Location = new System.Drawing.Point(891, 188);
            this.confirm_worker_button.Name = "confirm_worker_button";
            this.confirm_worker_button.Size = new System.Drawing.Size(75, 23);
            this.confirm_worker_button.TabIndex = 1;
            this.confirm_worker_button.Text = "Atlikti";
            this.confirm_worker_button.UseVisualStyleBackColor = true;
            this.confirm_worker_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Redaguoti vartotoją";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(853, 81);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(100, 20);
            this.username_textbox.TabIndex = 3;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(853, 107);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(100, 20);
            this.password_textbox.TabIndex = 4;
            // 
            // hide_button
            // 
            this.hide_button.Location = new System.Drawing.Point(810, 188);
            this.hide_button.Name = "hide_button";
            this.hide_button.Size = new System.Drawing.Size(75, 23);
            this.hide_button.TabIndex = 5;
            this.hide_button.Text = "Paslėpti";
            this.hide_button.UseVisualStyleBackColor = true;
            this.hide_button.Click += new System.EventHandler(this.hide_button_Click);
            // 
            // type_textbox
            // 
            this.type_textbox.Location = new System.Drawing.Point(853, 133);
            this.type_textbox.Name = "type_textbox";
            this.type_textbox.Size = new System.Drawing.Size(100, 20);
            this.type_textbox.TabIndex = 6;
            // 
            // ID_textbox
            // 
            this.ID_textbox.Location = new System.Drawing.Point(853, 57);
            this.ID_textbox.Name = "ID_textbox";
            this.ID_textbox.Size = new System.Drawing.Size(100, 20);
            this.ID_textbox.TabIndex = 7;
            // 
            // product_grid
            // 
            this.product_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.category,
            this.price,
            this.description});
            this.product_grid.Location = new System.Drawing.Point(-1, 28);
            this.product_grid.Name = "product_grid";
            this.product_grid.Size = new System.Drawing.Size(446, 199);
            this.product_grid.TabIndex = 8;
            this.product_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_grid_CellClick);
            this.product_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_grid_CellContentClick);
            this.product_grid.SelectionChanged += new System.EventHandler(this.product_grid_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // category
            // 
            this.category.HeaderText = "category";
            this.category.Name = "category";
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.Name = "price";
            // 
            // description
            // 
            this.description.HeaderText = "description";
            this.description.Name = "description";
            this.description.Visible = false;
            // 
            // product_description_textbox
            // 
            this.product_description_textbox.Location = new System.Drawing.Point(160, 259);
            this.product_description_textbox.Name = "product_description_textbox";
            this.product_description_textbox.Size = new System.Drawing.Size(193, 198);
            this.product_description_textbox.TabIndex = 9;
            this.product_description_textbox.Text = "";
            // 
            // product_name_textbox
            // 
            this.product_name_textbox.Location = new System.Drawing.Point(54, 233);
            this.product_name_textbox.Name = "product_name_textbox";
            this.product_name_textbox.Size = new System.Drawing.Size(100, 20);
            this.product_name_textbox.TabIndex = 10;
            // 
            // product_price_textbox
            // 
            this.product_price_textbox.Location = new System.Drawing.Point(54, 289);
            this.product_price_textbox.Name = "product_price_textbox";
            this.product_price_textbox.Size = new System.Drawing.Size(100, 20);
            this.product_price_textbox.TabIndex = 12;
            // 
            // product_confirm
            // 
            this.product_confirm.Location = new System.Drawing.Point(67, 311);
            this.product_confirm.Name = "product_confirm";
            this.product_confirm.Size = new System.Drawing.Size(75, 23);
            this.product_confirm.TabIndex = 14;
            this.product_confirm.Text = "Įrašyti";
            this.product_confirm.UseVisualStyleBackColor = true;
            this.product_confirm.Click += new System.EventHandler(this.product_confirm_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(67, 337);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 15;
            this.update_button.Text = "Atnaujinti";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(67, 366);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 16;
            this.delete_button.Text = "Trinti";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Prekė";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kategorija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(807, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Vartotojai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Pav";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Kategorija";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Kaina";
            // 
            // category_id_textobx
            // 
            this.category_id_textobx.Location = new System.Drawing.Point(529, 31);
            this.category_id_textobx.Name = "category_id_textobx";
            this.category_id_textobx.Size = new System.Drawing.Size(100, 20);
            this.category_id_textobx.TabIndex = 23;
            // 
            // category_name_textbox
            // 
            this.category_name_textbox.Location = new System.Drawing.Point(529, 57);
            this.category_name_textbox.Name = "category_name_textbox";
            this.category_name_textbox.Size = new System.Drawing.Size(100, 20);
            this.category_name_textbox.TabIndex = 24;
            // 
            // confirm_category
            // 
            this.confirm_category.Location = new System.Drawing.Point(505, 81);
            this.confirm_category.Name = "confirm_category";
            this.confirm_category.Size = new System.Drawing.Size(75, 23);
            this.confirm_category.TabIndex = 25;
            this.confirm_category.Text = "Įrašyti";
            this.confirm_category.UseVisualStyleBackColor = true;
            this.confirm_category.Click += new System.EventHandler(this.confirm_category_Click);
            // 
            // update_category
            // 
            this.update_category.Location = new System.Drawing.Point(586, 81);
            this.update_category.Name = "update_category";
            this.update_category.Size = new System.Drawing.Size(75, 23);
            this.update_category.TabIndex = 26;
            this.update_category.Text = "Atnaujinti";
            this.update_category.UseVisualStyleBackColor = true;
            this.update_category.Click += new System.EventHandler(this.update_category_Click);
            // 
            // product_category_comb
            // 
            this.product_category_comb.FormattingEnabled = true;
            this.product_category_comb.Location = new System.Drawing.Point(54, 262);
            this.product_category_comb.Name = "product_category_comb";
            this.product_category_comb.Size = new System.Drawing.Size(100, 21);
            this.product_category_comb.TabIndex = 27;
            this.product_category_comb.SelectedIndexChanged += new System.EventHandler(this.product_category_comb_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(497, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(497, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Pav";
            // 
            // to_main_form
            // 
            this.to_main_form.Location = new System.Drawing.Point(877, 590);
            this.to_main_form.Name = "to_main_form";
            this.to_main_form.Size = new System.Drawing.Size(75, 23);
            this.to_main_form.TabIndex = 30;
            this.to_main_form.Text = "Į pagrindinį";
            this.to_main_form.UseVisualStyleBackColor = true;
            this.to_main_form.Click += new System.EventHandler(this.to_main_form_Click);
            // 
            // product_comment_datagrid
            // 
            this.product_comment_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_comment_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iden,
            this.author,
            this.message});
            this.product_comment_datagrid.Location = new System.Drawing.Point(401, 260);
            this.product_comment_datagrid.Name = "product_comment_datagrid";
            this.product_comment_datagrid.Size = new System.Drawing.Size(469, 129);
            this.product_comment_datagrid.TabIndex = 31;
            this.product_comment_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_comment_datagrid_CellContentClick);
            this.product_comment_datagrid.SelectionChanged += new System.EventHandler(this.product_comment_datagrid_SelectionChanged);
            // 
            // iden
            // 
            this.iden.HeaderText = "ID";
            this.iden.Name = "iden";
            // 
            // author
            // 
            this.author.HeaderText = "Author";
            this.author.Name = "author";
            // 
            // message
            // 
            this.message.HeaderText = "Message";
            this.message.Name = "message";
            this.message.Width = 350;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(587, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Komentarai";
            // 
            // delete_comment_button
            // 
            this.delete_comment_button.Location = new System.Drawing.Point(876, 316);
            this.delete_comment_button.Name = "delete_comment_button";
            this.delete_comment_button.Size = new System.Drawing.Size(75, 41);
            this.delete_comment_button.TabIndex = 33;
            this.delete_comment_button.Text = "Trinti komentarą";
            this.delete_comment_button.UseVisualStyleBackColor = true;
            this.delete_comment_button.Click += new System.EventHandler(this.delete_comment_button_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(583, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Atsiliepimai";
            // 
            // review_datagrid
            // 
            this.review_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.review_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identifikatorius,
            this.autorius,
            this.atsiliepimas});
            this.review_datagrid.Location = new System.Drawing.Point(401, 408);
            this.review_datagrid.Name = "review_datagrid";
            this.review_datagrid.Size = new System.Drawing.Size(469, 150);
            this.review_datagrid.TabIndex = 35;
            this.review_datagrid.SelectionChanged += new System.EventHandler(this.review_datagrid_SelectionChanged);
            // 
            // identifikatorius
            // 
            this.identifikatorius.HeaderText = "ID";
            this.identifikatorius.Name = "identifikatorius";
            // 
            // autorius
            // 
            this.autorius.HeaderText = "Author";
            this.autorius.Name = "autorius";
            // 
            // atsiliepimas
            // 
            this.atsiliepimas.HeaderText = "Review";
            this.atsiliepimas.Name = "atsiliepimas";
            this.atsiliepimas.Width = 350;
            // 
            // delete_review_button
            // 
            this.delete_review_button.Location = new System.Drawing.Point(878, 466);
            this.delete_review_button.Name = "delete_review_button";
            this.delete_review_button.Size = new System.Drawing.Size(75, 41);
            this.delete_review_button.TabIndex = 36;
            this.delete_review_button.Text = "Trinti atsiliepimą";
            this.delete_review_button.UseVisualStyleBackColor = true;
            this.delete_review_button.Click += new System.EventHandler(this.delete_review_button_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(793, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(793, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Username";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(793, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Password";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(793, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Type";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(232, 244);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Apibudinimas";
            // 
            // Admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 625);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.delete_review_button);
            this.Controls.Add(this.review_datagrid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.delete_comment_button);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.product_comment_datagrid);
            this.Controls.Add(this.to_main_form);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.product_category_comb);
            this.Controls.Add(this.update_category);
            this.Controls.Add(this.confirm_category);
            this.Controls.Add(this.category_name_textbox);
            this.Controls.Add(this.category_id_textobx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.product_confirm);
            this.Controls.Add(this.product_price_textbox);
            this.Controls.Add(this.product_name_textbox);
            this.Controls.Add(this.product_description_textbox);
            this.Controls.Add(this.product_grid);
            this.Controls.Add(this.ID_textbox);
            this.Controls.Add(this.type_textbox);
            this.Controls.Add(this.hide_button);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.confirm_worker_button);
            this.Controls.Add(this.button1);
            this.Name = "Admin_form";
            this.Text = "Admin_form";
            this.Load += new System.EventHandler(this.Admin_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_comment_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.review_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button confirm_worker_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button hide_button;
        private System.Windows.Forms.TextBox type_textbox;
        private System.Windows.Forms.TextBox ID_textbox;
        private System.Windows.Forms.DataGridView product_grid;
        private System.Windows.Forms.RichTextBox product_description_textbox;
        private System.Windows.Forms.TextBox product_name_textbox;
        private System.Windows.Forms.TextBox product_price_textbox;
        private System.Windows.Forms.Button product_confirm;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.TextBox category_id_textobx;
        private System.Windows.Forms.TextBox category_name_textbox;
        private System.Windows.Forms.Button confirm_category;
        private System.Windows.Forms.Button update_category;
        private System.Windows.Forms.ComboBox product_category_comb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button to_main_form;
        private System.Windows.Forms.DataGridView product_comment_datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn iden;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn message;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button delete_comment_button;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView review_datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifikatorius;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorius;
        private System.Windows.Forms.DataGridViewTextBoxColumn atsiliepimas;
        private System.Windows.Forms.Button delete_review_button;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}