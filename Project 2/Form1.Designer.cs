
namespace Project_2
{
    partial class Form_login
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
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.u = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.Create_link = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label_username.Location = new System.Drawing.Point(165, 136);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(32, 20);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "i_id";
            this.label_username.Click += new System.EventHandler(this.label_username_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label_password.Location = new System.Drawing.Point(125, 187);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(72, 20);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Password";
            // 
            // u
            // 
            this.u.BackColor = System.Drawing.Color.Gainsboro;
            this.u.Cursor = System.Windows.Forms.Cursors.Hand;
            this.u.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u.Location = new System.Drawing.Point(218, 136);
            this.u.Name = "u";
            this.u.Size = new System.Drawing.Size(100, 22);
            this.u.TabIndex = 2;
            this.u.TextChanged += new System.EventHandler(this.textBox_username_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_password.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(218, 187);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 22);
            this.textBox_password.TabIndex = 3;
            // 
            // button_login
            // 
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_login.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(212, 272);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 4;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // Create_link
            // 
            this.Create_link.AutoSize = true;
            this.Create_link.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_link.LinkColor = System.Drawing.Color.Blue;
            this.Create_link.Location = new System.Drawing.Point(209, 230);
            this.Create_link.Name = "Create_link";
            this.Create_link.Size = new System.Drawing.Size(92, 16);
            this.Create_link.TabIndex = 5;
            this.Create_link.TabStop = true;
            this.Create_link.Text = "Click to Register";
            this.Create_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Create_link_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Instructor Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(494, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Create_link);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.u);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Name = "Form_login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox u;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.LinkLabel Create_link;
        private System.Windows.Forms.Label label1;
    }
}

