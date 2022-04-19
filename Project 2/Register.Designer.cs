
namespace Project_2
{
    partial class Register
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
            this.p = new System.Windows.Forms.TextBox();
            this.f = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.TextBox();
            this.iid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // p
            // 
            this.p.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p.Location = new System.Drawing.Point(151, 90);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(100, 22);
            this.p.TabIndex = 7;
            this.p.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // f
            // 
            this.f.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f.Location = new System.Drawing.Point(151, 50);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(100, 22);
            this.f.TabIndex = 6;
            this.f.TextChanged += new System.EventHandler(this.textBox_username_TextChanged);
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(89, 90);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(58, 16);
            this.pass.TabIndex = 5;
            this.pass.Text = "Password";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(87, 50);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(64, 16);
            this.fname.TabIndex = 4;
            this.fname.Text = "First Name";
            this.fname.Click += new System.EventHandler(this.label_username_Click);
            // 
            // d
            // 
            this.d.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d.Location = new System.Drawing.Point(151, 173);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(100, 22);
            this.d.TabIndex = 11;
            // 
            // iid
            // 
            this.iid.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iid.Location = new System.Drawing.Point(151, 133);
            this.iid.Name = "iid";
            this.iid.Size = new System.Drawing.Size(100, 22);
            this.iid.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Deparment";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(107, 133);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(26, 16);
            this.id.TabIndex = 8;
            this.id.Text = "i_id";
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(151, 241);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(86, 29);
            this.button.TabIndex = 12;
            this.button.Text = "Enter";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(295, 23);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(75, 23);
            this.button_return.TabIndex = 13;
            this.button_return.Text = "Return";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 321);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.button);
            this.Controls.Add(this.d);
            this.Controls.Add(this.iid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.p);
            this.Controls.Add(this.f);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.fname);
            this.Name = "Register";
            this.Text = "Registar";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox p;
        private System.Windows.Forms.TextBox f;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.TextBox d;
        private System.Windows.Forms.TextBox iid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button_return;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}