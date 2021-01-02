using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test7
{
    public partial class Register : Form
    {
        String role = "student";
        DBHelper dBHelper;
        String connetStr = "server=127.0.0.1;port=3306; user=root;password=zhangjunbo;database=test7";
        Boolean flag = false;
        public Register()
        {
            InitializeComponent();
            dBHelper = new DBHelper(connetStr);
        }

        private void butt_register_Click(object sender, EventArgs e)
        {
            String user_id = text_UserID.Text;
            String pass = text_Password.Text;
            String name = text_name.Text;
            int r1;
            int r2;
            DataTable dt= dBHelper.Select("select u_id from users");
            DataRowCollection drc = dt.Rows;
            DataRow drow;
            if (drc.Count == 0)
            {
                MessageBox.Show("您查询的信息不存在");
            }
            else
            {
                for (int i = 0; i < drc.Count; i++)
                {
                    drow = drc[i];
                    if (user_id.Equals(drow[0]))
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }


            if (flag)
            {
                MessageBox.Show("用户已存在");
            }
            else
            {
                r1 = dBHelper.Insert("insert into users values ('" + user_id + "','" + name + "','" + pass + "','" + role + "')");
                if (role.Equals("student"))
                {
                    r2 = dBHelper.Insert("insert into students values('" + user_id + "','" + name + "',null,null,null)");
                }
                else if (role.Equals("teacher"))
                {
                    r2 = dBHelper.Insert("insert into teachers values('" + user_id + "','" + name + "',null,null,null)");
                }
                if (r1 != 0)
                {
                    MessageBox.Show("注册成功");
                    text_UserID.Clear();
                    text_name.Clear();
                    text_Password.Clear();
                }
            }
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            role = "student";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            role = "teacher";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            role = "admin";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                text_Password.PasswordChar = '\0';//显示明文
            }
            else
            {
                text_Password.PasswordChar = '*';
            }
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user_id = text_UserID.Text;
            String pass = text_Password.Text;
            String sql = "update users set u_pass='"+pass+"' where u_id='"+user_id+"'";
            if (dBHelper.Update(sql) != 0)
            {
                MessageBox.Show("密码修改成功");
            }
        }
    }
}
