
namespace Project_2
{
    partial class form_update
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
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button_avg = new System.Windows.Forms.Button();
            this.button_min = new System.Windows.Forms.Button();
            this.button_max = new System.Windows.Forms.Button();
            this.sname = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sid = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.Button();
            this.avg = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(292, 60);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(101, 22);
            this.name.TabIndex = 5;
            this.name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student Name";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(117, 113);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(392, 47);
            this.dataGridView.TabIndex = 6;
            // 
            // button_avg
            // 
            this.button_avg.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.button_avg.Location = new System.Drawing.Point(408, 237);
            this.button_avg.Name = "button_avg";
            this.button_avg.Size = new System.Drawing.Size(101, 37);
            this.button_avg.TabIndex = 14;
            this.button_avg.Text = "Update";
            this.button_avg.UseVisualStyleBackColor = true;
            this.button_avg.Click += new System.EventHandler(this.button_avg_Click);
            // 
            // button_min
            // 
            this.button_min.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.button_min.Location = new System.Drawing.Point(259, 237);
            this.button_min.Name = "button_min";
            this.button_min.Size = new System.Drawing.Size(101, 37);
            this.button_min.TabIndex = 13;
            this.button_min.Text = "Delete";
            this.button_min.UseVisualStyleBackColor = true;
            this.button_min.Click += new System.EventHandler(this.button_min_Click);
            // 
            // button_max
            // 
            this.button_max.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.button_max.Location = new System.Drawing.Point(117, 237);
            this.button_max.Name = "button_max";
            this.button_max.Size = new System.Drawing.Size(101, 37);
            this.button_max.TabIndex = 12;
            this.button_max.Text = "Insert";
            this.button_max.UseVisualStyleBackColor = true;
            this.button_max.Click += new System.EventHandler(this.button_max_Click);
            // 
            // sname
            // 
            this.sname.Location = new System.Drawing.Point(259, 194);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(101, 20);
            this.sname.TabIndex = 15;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(117, 194);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(101, 20);
            this.id.TabIndex = 16;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(408, 194);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(101, 20);
            this.age.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label1.Location = new System.Drawing.Point(256, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label3.Location = new System.Drawing.Point(405, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Age";
            // 
            // sid
            // 
            this.sid.AutoSize = true;
            this.sid.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.sid.Location = new System.Drawing.Point(114, 174);
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(21, 17);
            this.sid.TabIndex = 20;
            this.sid.Text = "ID";
            this.sid.Click += new System.EventHandler(this.label4_Click);
            // 
            // max
            // 
            this.max.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.max.Location = new System.Drawing.Point(408, 311);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(101, 37);
            this.max.TabIndex = 23;
            this.max.Text = "MAX";
            this.max.UseVisualStyleBackColor = true;
            // 
            // avg
            // 
            this.avg.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.avg.Location = new System.Drawing.Point(259, 311);
            this.avg.Name = "avg";
            this.avg.Size = new System.Drawing.Size(101, 37);
            this.avg.TabIndex = 22;
            this.avg.Text = "AVG";
            this.avg.UseVisualStyleBackColor = true;
            this.avg.Click += new System.EventHandler(this.avg_Click);
            // 
            // min
            // 
            this.min.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.min.Location = new System.Drawing.Point(117, 311);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(101, 37);
            this.min.TabIndex = 21;
            this.min.Text = "MIN";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // form_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(618, 393);
            this.Controls.Add(this.max);
            this.Controls.Add(this.avg);
            this.Controls.Add(this.min);
            this.Controls.Add(this.sid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.age);
            this.Controls.Add(this.id);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.button_avg);
            this.Controls.Add(this.button_min);
            this.Controls.Add(this.button_max);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Name = "form_update";
            this.Text = "Form_class";
            this.Load += new System.EventHandler(this.form_update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button_avg;
        private System.Windows.Forms.Button button_min;
        private System.Windows.Forms.Button button_max;
        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sid;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Button avg;
        private System.Windows.Forms.Button min;
    }
}