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
            this.product_description_textbox = new System.Windows.Forms.RichTextBox();
            this.product_name_textbox = new System.Windows.Forms.TextBox();
            this.product_category_textbox = new System.Windows.Forms.TextBox();
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_id_textobx = new System.Windows.Forms.TextBox();
            this.category_name_textbox = new System.Windows.Forms.TextBox();
            this.confirm_category = new System.Windows.Forms.Button();
            this.update_category = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.product_grid)).BeginInit();
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
            // product_description_textbox
            // 
            this.product_description_textbox.Location = new System.Drawing.Point(160, 233);
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
            // product_category_textbox
            // 
            this.product_category_textbox.Location = new System.Drawing.Point(54, 292);
            this.product_category_textbox.Name = "product_category_textbox";
            this.product_category_textbox.Size = new System.Drawing.Size(100, 20);
            this.product_category_textbox.TabIndex = 11;
            // 
            // product_price_textbox
            // 
            this.product_price_textbox.Location = new System.Drawing.Point(55, 318);
            this.product_price_textbox.Name = "product_price_textbox";
            this.product_price_textbox.Size = new System.Drawing.Size(100, 20);
            this.product_price_textbox.TabIndex = 12;
            // 
            // product_confirm
            // 
            this.product_confirm.Location = new System.Drawing.Point(68, 340);
            this.product_confirm.Name = "product_confirm";
            this.product_confirm.Size = new System.Drawing.Size(75, 23);
            this.product_confirm.TabIndex = 14;
            this.product_confirm.Text = "Įrašyti";
            this.product_confirm.UseVisualStyleBackColor = true;
            this.product_confirm.Click += new System.EventHandler(this.product_confirm_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(68, 366);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 15;
            this.update_button.Text = "Atnaujinti";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(68, 395);
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
            this.label6.Location = new System.Drawing.Point(0, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Kaina";
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(54, 262);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 27;
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
            // Admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 442);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
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
            this.Controls.Add(this.product_category_textbox);
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
        private System.Windows.Forms.TextBox product_category_textbox;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}