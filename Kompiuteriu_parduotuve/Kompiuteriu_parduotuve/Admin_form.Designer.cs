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
            this.product_category_textbox = new System.Windows.Forms.TextBox();
            this.product_price_textbox = new System.Windows.Forms.TextBox();
            this.product_confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.product_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(831, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kurti nauja vartotoja";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirm_worker_button
            // 
            this.confirm_worker_button.Location = new System.Drawing.Point(882, 172);
            this.confirm_worker_button.Name = "confirm_worker_button";
            this.confirm_worker_button.Size = new System.Drawing.Size(75, 23);
            this.confirm_worker_button.TabIndex = 1;
            this.confirm_worker_button.Text = "Atlikti";
            this.confirm_worker_button.UseVisualStyleBackColor = true;
            this.confirm_worker_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(695, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Redaguoti vartotoją";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(844, 65);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(100, 20);
            this.username_textbox.TabIndex = 3;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(844, 91);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(100, 20);
            this.password_textbox.TabIndex = 4;
            // 
            // hide_button
            // 
            this.hide_button.Location = new System.Drawing.Point(801, 172);
            this.hide_button.Name = "hide_button";
            this.hide_button.Size = new System.Drawing.Size(75, 23);
            this.hide_button.TabIndex = 5;
            this.hide_button.Text = "Paslėpti";
            this.hide_button.UseVisualStyleBackColor = true;
            this.hide_button.Click += new System.EventHandler(this.hide_button_Click);
            // 
            // type_textbox
            // 
            this.type_textbox.Location = new System.Drawing.Point(844, 117);
            this.type_textbox.Name = "type_textbox";
            this.type_textbox.Size = new System.Drawing.Size(100, 20);
            this.type_textbox.TabIndex = 6;
            // 
            // ID_textbox
            // 
            this.ID_textbox.Location = new System.Drawing.Point(844, 41);
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
            this.product_grid.Location = new System.Drawing.Point(1, 12);
            this.product_grid.Name = "product_grid";
            this.product_grid.Size = new System.Drawing.Size(446, 199);
            this.product_grid.TabIndex = 8;
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
            // 
            // product_description_textbox
            // 
            this.product_description_textbox.Location = new System.Drawing.Point(453, 146);
            this.product_description_textbox.Name = "product_description_textbox";
            this.product_description_textbox.Size = new System.Drawing.Size(193, 198);
            this.product_description_textbox.TabIndex = 9;
            this.product_description_textbox.Text = "";
            // 
            // product_name_textbox
            // 
            this.product_name_textbox.Location = new System.Drawing.Point(21, 217);
            this.product_name_textbox.Name = "product_name_textbox";
            this.product_name_textbox.Size = new System.Drawing.Size(100, 20);
            this.product_name_textbox.TabIndex = 10;
            // 
            // product_category_textbox
            // 
            this.product_category_textbox.Location = new System.Drawing.Point(21, 243);
            this.product_category_textbox.Name = "product_category_textbox";
            this.product_category_textbox.Size = new System.Drawing.Size(100, 20);
            this.product_category_textbox.TabIndex = 11;
            // 
            // product_price_textbox
            // 
            this.product_price_textbox.Location = new System.Drawing.Point(21, 269);
            this.product_price_textbox.Name = "product_price_textbox";
            this.product_price_textbox.Size = new System.Drawing.Size(100, 20);
            this.product_price_textbox.TabIndex = 12;
            // 
            // product_confirm
            // 
            this.product_confirm.Location = new System.Drawing.Point(34, 321);
            this.product_confirm.Name = "product_confirm";
            this.product_confirm.Size = new System.Drawing.Size(75, 23);
            this.product_confirm.TabIndex = 14;
            this.product_confirm.Text = "Atlikti";
            this.product_confirm.UseVisualStyleBackColor = true;
            this.product_confirm.Click += new System.EventHandler(this.product_confirm_Click);
            // 
            // Admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 350);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.RichTextBox product_description_textbox;
        private System.Windows.Forms.TextBox product_name_textbox;
        private System.Windows.Forms.TextBox product_category_textbox;
        private System.Windows.Forms.TextBox product_price_textbox;
        private System.Windows.Forms.Button product_confirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}