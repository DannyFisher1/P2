﻿
namespace Project_2
{
    partial class form_middle
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
            this.button2 = new System.Windows.Forms.Button();
            this.r = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(118, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update Class Information";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(118, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(268, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update Student Information";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // r
            // 
            this.r.BackColor = System.Drawing.Color.Gainsboro;
            this.r.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.r.Location = new System.Drawing.Point(413, 34);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(72, 32);
            this.r.TabIndex = 2;
            this.r.Text = "Logout";
            this.r.UseVisualStyleBackColor = false;
            this.r.Click += new System.EventHandler(this.r_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(153, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Function";
            // 
            // form_middle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(530, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.r);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "form_middle";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.middle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button r;
        private System.Windows.Forms.Label label1;
    }
}