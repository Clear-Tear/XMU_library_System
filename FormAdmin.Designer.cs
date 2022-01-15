﻿namespace MyLibrary
{
    partial class FormAdmin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.text_author = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_press = new System.Windows.Forms.TextBox();
            this.text_bookname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_isbn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_lend = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_userop = new System.Windows.Forms.Button();
            this.btn_outtime = new System.Windows.Forms.Button();
            this.btn_lendstatus = new System.Windows.Forms.Button();
            this.btn_pwd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(101, 338);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 261);
            this.dataGridView1.TabIndex = 13;
            // 
            // text_author
            // 
            this.text_author.Location = new System.Drawing.Point(543, 65);
            this.text_author.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_author.Name = "text_author";
            this.text_author.Size = new System.Drawing.Size(185, 27);
            this.text_author.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "作者";
            // 
            // text_press
            // 
            this.text_press.Location = new System.Drawing.Point(543, 28);
            this.text_press.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_press.Name = "text_press";
            this.text_press.Size = new System.Drawing.Size(185, 27);
            this.text_press.TabIndex = 9;
            // 
            // text_bookname
            // 
            this.text_bookname.Location = new System.Drawing.Point(227, 66);
            this.text_bookname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_bookname.Name = "text_bookname";
            this.text_bookname.Size = new System.Drawing.Size(185, 27);
            this.text_bookname.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "书名";
            // 
            // text_isbn
            // 
            this.text_isbn.Location = new System.Drawing.Point(227, 30);
            this.text_isbn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_isbn.Name = "text_isbn";
            this.text_isbn.Size = new System.Drawing.Size(185, 27);
            this.text_isbn.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ISBN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.text_author);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.text_press);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.text_bookname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.text_isbn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox1.Location = new System.Drawing.Point(101, 218);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1071, 106);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图书查询";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "出版社";
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_search.Location = new System.Drawing.Point(791, 25);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(121, 69);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.Transparent;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_return.Location = new System.Drawing.Point(1200, 385);
            this.btn_return.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(157, 44);
            this.btn_return.TabIndex = 11;
            this.btn_return.Text = "还书";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_lend
            // 
            this.btn_lend.BackColor = System.Drawing.Color.Transparent;
            this.btn_lend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lend.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_lend.Location = new System.Drawing.Point(1200, 336);
            this.btn_lend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_lend.Name = "btn_lend";
            this.btn_lend.Size = new System.Drawing.Size(157, 44);
            this.btn_lend.TabIndex = 10;
            this.btn_lend.Text = "借书";
            this.btn_lend.UseVisualStyleBackColor = false;
            this.btn_lend.Click += new System.EventHandler(this.btn_lend_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_add.Location = new System.Drawing.Point(1200, 459);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(157, 44);
            this.btn_add.TabIndex = 17;
            this.btn_add.Text = "添加图书";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_edit.Location = new System.Drawing.Point(1200, 506);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(157, 44);
            this.btn_edit.TabIndex = 18;
            this.btn_edit.Text = "修改信息";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.Transparent;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_del.ForeColor = System.Drawing.Color.Red;
            this.btn_del.Location = new System.Drawing.Point(1200, 555);
            this.btn_del.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(157, 44);
            this.btn_del.TabIndex = 19;
            this.btn_del.Text = "删除该书";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_userop
            // 
            this.btn_userop.BackColor = System.Drawing.Color.Transparent;
            this.btn_userop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_userop.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_userop.Location = new System.Drawing.Point(1027, 799);
            this.btn_userop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_userop.Name = "btn_userop";
            this.btn_userop.Size = new System.Drawing.Size(163, 56);
            this.btn_userop.TabIndex = 20;
            this.btn_userop.Text = "用户管理";
            this.btn_userop.UseVisualStyleBackColor = false;
            this.btn_userop.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_outtime
            // 
            this.btn_outtime.BackColor = System.Drawing.Color.Transparent;
            this.btn_outtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_outtime.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_outtime.Location = new System.Drawing.Point(1200, 735);
            this.btn_outtime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_outtime.Name = "btn_outtime";
            this.btn_outtime.Size = new System.Drawing.Size(173, 54);
            this.btn_outtime.TabIndex = 22;
            this.btn_outtime.Text = "超期图书查询";
            this.btn_outtime.UseVisualStyleBackColor = false;
            this.btn_outtime.Click += new System.EventHandler(this.btn_outtime_Click);
            // 
            // btn_lendstatus
            // 
            this.btn_lendstatus.BackColor = System.Drawing.Color.Transparent;
            this.btn_lendstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lendstatus.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_lendstatus.Location = new System.Drawing.Point(1200, 799);
            this.btn_lendstatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_lendstatus.Name = "btn_lendstatus";
            this.btn_lendstatus.Size = new System.Drawing.Size(173, 56);
            this.btn_lendstatus.TabIndex = 23;
            this.btn_lendstatus.Text = "在借情况查询";
            this.btn_lendstatus.UseVisualStyleBackColor = false;
            this.btn_lendstatus.Click += new System.EventHandler(this.btn_lendstatus_Click);
            // 
            // btn_pwd
            // 
            this.btn_pwd.BackColor = System.Drawing.Color.Transparent;
            this.btn_pwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pwd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_pwd.Location = new System.Drawing.Point(1027, 735);
            this.btn_pwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_pwd.Name = "btn_pwd";
            this.btn_pwd.Size = new System.Drawing.Size(163, 54);
            this.btn_pwd.TabIndex = 24;
            this.btn_pwd.Text = "修改密码";
            this.btn_pwd.UseVisualStyleBackColor = false;
            this.btn_pwd.Click += new System.EventHandler(this.btn_pwd_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyLibrary.Properties.Resources.formadmin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1467, 909);
            this.Controls.Add(this.btn_pwd);
            this.Controls.Add(this.btn_lendstatus);
            this.Controls.Add(this.btn_outtime);
            this.Controls.Add(this.btn_userop);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_lend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAdmin";
            this.Text = "管理员界面";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox text_author;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_press;
        private System.Windows.Forms.TextBox text_bookname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_isbn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_lend;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_userop;
        private System.Windows.Forms.Button btn_outtime;
        private System.Windows.Forms.Button btn_lendstatus;
        private System.Windows.Forms.Button btn_pwd;
    }
}