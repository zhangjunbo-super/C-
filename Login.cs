using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace test7
{
    public partial class Login : Form
    {
        String connetStr = "server=127.0.0.1;port=3306; user=root;password=zhangjunbo;database=test7";
        DBHelper dBHelpe;
        public Login()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;//显示在屏幕中间
            dBHelpe = new DBHelper(connetStr);
        }

        private void butt_login_Click(object sender, EventArgs e)
        {
            String userId = UserID.Text;
            String pass = Password.Text;
            DataTable dt = dBHelpe.Select("select * from users where u_id='" + userId + "'");
            DataRowCollection drc = dt.Rows;//行数
            DataRow drow;
            if (drc.Count == 0)
            {
                MessageBox.Show("您输入的用户名不存在");
            }
            else
            {
                for (int i = 0; i < drc.Count; i++)
                {
                    drow = drc[i];
                    String truePass = (String)drow[2];
                    String role = (String)drow[3];
                    Console.WriteLine(truePass+role);
                    if (pass.Equals(truePass))
                    {
                        switch (role)
                        {
                            case "admin":
                                new Admins(userId,truePass,role).Show();
                                this.Hide();
                                break;
                            case "teacher":
                                new Teachers(userId,truePass,role).Show();
                                this.Hide();
                                break;
                            case "student":
                                new Students(userId,truePass,role).Show();
                                this.Hide();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("密码错误");
                    }
                }
            }
            
        }

        private void butt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Password.PasswordChar = '\0';//显示明文
            }
            else
            {
                Password.PasswordChar = '*';
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
