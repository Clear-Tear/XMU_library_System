namespace MyLibrary
{
    partial class FormUser
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
            this.btn_pwd = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_lend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text_author = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_press = new System.Windows.Forms.TextBox();
            this.text_bookname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_isbn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.btn_pwd.TabIndex = 46;
            this.btn_pwd.Text = "修改密码";
            this.btn_pwd.UseVisualStyleBackColor = false;
            this.btn_pwd.Click += new System.EventHandler(this.btn_pwd_Click_1);
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
            this.btn_return.TabIndex = 29;
            this.btn_return.Text = "还书";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click_1);
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
            this.btn_lend.TabIndex = 28;
            this.btn_lend.Text = "借书";
            this.btn_lend.UseVisualStyleBackColor = false;
            this.btn_lend.Click += new System.EventHandler(this.btn_lend_Click_1);
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
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
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
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图书查询";
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
            this.dataGridView1.TabIndex = 32;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyLibrary.Properties.Resources.formuser;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1467, 909);
            this.Controls.Add(this.btn_pwd);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_lend);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormUser";
            this.Text = "用户界面";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_pwd;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_lend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_author;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_press;
        private System.Windows.Forms.TextBox text_bookname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_isbn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}