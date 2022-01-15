using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MyLibrary
{
    public partial class FormAdmin : Form
    {
        string rtseats;

        string cardno;

        string acc;
        int auth;
        DateTime currentDate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));


        public FormAdmin(string account, int getauth)
        {
            InitializeComponent();
            acc = account;
            auth = getauth;
            string sql = "select user_cardno from userinfo where login_account='" + acc + "'";
            cardno = AdminBLL.SimpleQuery2(sql);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            string isbn = dataGridView1.Rows[a].Cells[0].Value.ToString().Trim();
            string sql = "delete from bookinfo where book_isbn='" + isbn + "'";
            if (ExecuteSql.Executesql(sql) > 0)
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormUserData formUserData = new FormUserData(auth);
            formUserData.Owner = this;
            formUserData.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string isbn = text_isbn.Text.Trim();
            string press = text_press.Text.Trim();
            string name = text_bookname.Text.Trim();
            string author = text_author.Text.Trim();

            string srct = "bookinfo";
            this.dataGridView1.DataSource = ExecuteQuery.Query("select book_isbn 'ISBN书号', book_bookname '书名', book_author '作者', book_press '出版社', book_totalamount '馆藏数量', book_availamount '可借数量' from bookinfo where book_isbn like '%" + isbn + "%' and book_press like '%" + press + "%' and book_bookname like '%" + name + "%' and book_author like '%" + author + "%'", srct).Tables["bookinfo"];


        }

        private void btn_lend_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            string isbn = dataGridView1.Rows[a].Cells[0].Value.ToString().Trim();
            string avail = dataGridView1.Rows[a].Cells[5].Value.ToString().Trim();
            if (avail == "0")
            {
                MessageBox.Show("已经借完，无法借阅！");
            }
            else
            {
                string sql = "select user_availnumber,user_lendnumber from userinfo where login_account='" + acc + "'";
                int canl = AdminBLL.SimpleQuery(sql);
                if (canl == -1)
                {
                    MessageBox.Show("无法查询到用户信息");
                }
                else if (canl == 0)
                {
                    MessageBox.Show("您已借满，请先还书！");
                }
                else
                {
                    sql = "select user_cardno from userinfo where login_account='" + acc + "'";
                    string cardno = AdminBLL.SimpleQuery2(sql);
                    if (cardno == "")
                    {
                        MessageBox.Show("无法查到借书证号");
                    }
                    else
                    {
                        sql = "insert into lendinfo(user_cardno, book_isbn, lendout, timelimit) values('" + cardno + "', '" + isbn + "', '" + currentDate.ToString("yyyy-MM-dd") + "', '" + currentDate.AddDays(30).ToString("yyyy-MM-dd") + "')";
                        int oprows = ExecuteSql.Executesql(sql);
                        if (oprows > 0)
                        {
                            MessageBox.Show("借书成功，借期30天，请在" + currentDate.AddDays(30).ToString("yyyy-MM-dd") + "前归还！");
                        }
                        else
                        {
                            MessageBox.Show("借书失败");
                        }
                    }
                }
            }
        }

        private void btn_pwd_Click(object sender, EventArgs e)
        {
            FormEditPwd formEditPwd = new FormEditPwd(acc);
            formEditPwd.Show();
            this.Close();
        }

        

        private void btn_return_Click(object sender, EventArgs e)
        {
            FormReturn formReturn = new FormReturn(acc);
            formReturn.Owner = this;
            formReturn.Show();
        }



        private void btn_add_Click(object sender, EventArgs e)
        {
            FormAddbook formAddbook = new FormAddbook();
            formAddbook.Owner = this;
            formAddbook.Show();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            // isbn, bookname,author, press, totalamount, availamount
            int a = dataGridView1.CurrentRow.Index;
            string[] s = new string[6];
            for (int i=0;i<6;i++)
            {
                s[i] = dataGridView1.Rows[a].Cells[i].Value.ToString().Trim();
            }

            FormEditBook formEditBook = new FormEditBook(s);
            formEditBook.Owner = this;
            formEditBook.Show();
        }

        private void btn_outtime_Click(object sender, EventArgs e)
        {
            FormOuttime formOuttime = new FormOuttime();
            formOuttime.Owner = this;
            formOuttime.Show();

        }

        private void btn_lendstatus_Click(object sender, EventArgs e)
        {
            FormLend formLend = new FormLend();
            formLend.Owner = this;
            formLend.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
