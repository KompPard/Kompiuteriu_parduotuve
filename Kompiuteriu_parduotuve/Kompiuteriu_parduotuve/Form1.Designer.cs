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
            ((System.ComponentModel.ISupportInitialize)(this.products_Datagrid)).BeginInit();
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
            this.products_Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products_Datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.category,
            this.price,
            this.description});
            this.products_Datagrid.Location = new System.Drawing.Point(12, 2);
            this.products_Datagrid.Name = "products_Datagrid";
            this.products_Datagrid.Size = new System.Drawing.Size(343, 238);
            this.products_Datagrid.TabIndex = 1;
            this.products_Datagrid.SelectionChanged += new System.EventHandler(this.products_Datagrid_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.Visible = false;
            // 
            // products_description
            // 
            this.products_description.Location = new System.Drawing.Point(351, 2);
            this.products_description.Name = "products_description";
            this.products_description.Size = new System.Drawing.Size(175, 238);
            this.products_description.TabIndex = 2;
            this.products_description.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 473);
            this.Controls.Add(this.products_description);
            this.Controls.Add(this.products_Datagrid);
            this.Controls.Add(this.Login_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.products_Datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.DataGridView products_Datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.RichTextBox products_description;
    }
}

