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
            this.confirm_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.hide_button = new System.Windows.Forms.Button();
            this.type_textbox = new System.Windows.Forms.TextBox();
            this.ID_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kurti nauja vartotoja";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirm_button
            // 
            this.confirm_button.Location = new System.Drawing.Point(654, 172);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(75, 23);
            this.confirm_button.TabIndex = 1;
            this.confirm_button.Text = "Atlikti";
            this.confirm_button.UseVisualStyleBackColor = true;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(467, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Redaguoti vartotoją";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(616, 65);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(100, 20);
            this.username_textbox.TabIndex = 3;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(616, 91);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(100, 20);
            this.password_textbox.TabIndex = 4;
            // 
            // hide_button
            // 
            this.hide_button.Location = new System.Drawing.Point(573, 172);
            this.hide_button.Name = "hide_button";
            this.hide_button.Size = new System.Drawing.Size(75, 23);
            this.hide_button.TabIndex = 5;
            this.hide_button.Text = "Paslėpti";
            this.hide_button.UseVisualStyleBackColor = true;
            this.hide_button.Click += new System.EventHandler(this.hide_button_Click);
            // 
            // type_textbox
            // 
            this.type_textbox.Location = new System.Drawing.Point(616, 117);
            this.type_textbox.Name = "type_textbox";
            this.type_textbox.Size = new System.Drawing.Size(100, 20);
            this.type_textbox.TabIndex = 6;
            // 
            // ID_textbox
            // 
            this.ID_textbox.Location = new System.Drawing.Point(616, 41);
            this.ID_textbox.Name = "ID_textbox";
            this.ID_textbox.Size = new System.Drawing.Size(100, 20);
            this.ID_textbox.TabIndex = 7;
            // 
            // Admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 261);
            this.Controls.Add(this.ID_textbox);
            this.Controls.Add(this.type_textbox);
            this.Controls.Add(this.hide_button);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.button1);
            this.Name = "Admin_form";
            this.Text = "Admin_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button hide_button;
        private System.Windows.Forms.TextBox type_textbox;
        private System.Windows.Forms.TextBox ID_textbox;
    }
}