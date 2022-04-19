namespace Project_2
{
    partial class Form_student
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.dataGridView_ages = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_course = new System.Windows.Forms.TextBox();
            this.button_max = new System.Windows.Forms.Button();
            this.button_min = new System.Windows.Forms.Button();
            this.button_avg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ages)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Student Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(606, 76);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(216, 76);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(293, 20);
            this.textBox_name.TabIndex = 3;
            // 
            // dataGridView_ages
            // 
            this.dataGridView_ages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ages.Location = new System.Drawing.Point(151, 120);
            this.dataGridView_ages.Name = "dataGridView_ages";
            this.dataGridView_ages.Size = new System.Drawing.Size(462, 150);
            this.dataGridView_ages.TabIndex = 4;
            this.dataGridView_ages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ages_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Course Indormation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Course Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 7;
            // 
            // textBox_course
            // 
            this.textBox_course.Location = new System.Drawing.Point(216, 344);
            this.textBox_course.Name = "textBox_course";
            this.textBox_course.Size = new System.Drawing.Size(397, 20);
            this.textBox_course.TabIndex = 8;
            // 
            // button_max
            // 
            this.button_max.Location = new System.Drawing.Point(151, 400);
            this.button_max.Name = "button_max";
            this.button_max.Size = new System.Drawing.Size(75, 23);
            this.button_max.TabIndex = 9;
            this.button_max.Text = "MAX";
            this.button_max.UseVisualStyleBackColor = true;
            // 
            // button_min
            // 
            this.button_min.Location = new System.Drawing.Point(316, 400);
            this.button_min.Name = "button_min";
            this.button_min.Size = new System.Drawing.Size(75, 23);
            this.button_min.TabIndex = 10;
            this.button_min.Text = "MIN";
            this.button_min.UseVisualStyleBackColor = true;
            // 
            // button_avg
            // 
            this.button_avg.Location = new System.Drawing.Point(491, 400);
            this.button_avg.Name = "button_avg";
            this.button_avg.Size = new System.Drawing.Size(75, 23);
            this.button_avg.TabIndex = 11;
            this.button_avg.Text = "AVG";
            this.button_avg.UseVisualStyleBackColor = true;
            // 
            // Form_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_avg);
            this.Controls.Add(this.button_min);
            this.Controls.Add(this.button_max);
            this.Controls.Add(this.textBox_course);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_ages);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_student";
            this.Text = "Form_student";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.DataGridView dataGridView_ages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_course;
        private System.Windows.Forms.Button button_max;
        private System.Windows.Forms.Button button_min;
        private System.Windows.Forms.Button button_avg;
    }
}