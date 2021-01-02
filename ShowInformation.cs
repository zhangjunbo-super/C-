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
    public partial class ShowInformation : Form
    {
        String userId;
        String role;
        String connetStr = "server=127.0.0.1;port=3306; user=root;password=zhangjunbo;database=test7";
        DBHelper dBHelpe;
        public ShowInformation(String userId,String pass,String role)
        {
            InitializeComponent();
            this.userId = userId;
            this.role = role;
            dBHelpe = new DBHelper(connetStr);
            //初始化
            text_id.Text = userId;
            text_pass.Text = pass;

            String sql = null;
            if (role.Equals("student"))
            {
                sql = "select * from students where s_id='" + userId + "'";
            }else if (role.Equals("teacher"))
            {
                sql = "select * from teachers where t_id='"+userId+"'";
            }
            DataTable dt = dBHelpe.Select(sql);
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
                   text_name.Text = (String)drow[1];
                    text_dept.Text = (String)drow[2];
                    combo_sex.Text = (String)drow[3];
                    text_inf.Text = (String)drow[4];
                }
            }

            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butt_update_Click(object sender, EventArgs e)
        {
            String name = text_name.Text;
            String dept = text_dept.Text;
            String sex = combo_sex.Text;
            String inf = text_inf.Text;
            String pass = text_pass.Text;
            String sql=null;
            if (role.Equals("student"))
            {
                sql = "update students set s_name='" + name + "',s_class='" + dept + "',s_sex='" + sex + "',s_inf='" + inf + "' where s_id='" + userId + "'";
            }else if (role.Equals("teacher"))
            {
                sql = "update teachers set t_name='" + name + "',t_dept='" + dept + "',t_sex='" + sex + "',t_inf='" + inf + "' where t_id='" + userId + "'";
            }
            String sql2 = "update users set u_pass='" + pass + "' where u_id='" + userId + "'";

            if (dBHelpe.Update(sql)!=0 && dBHelpe.Update(sql2) != 0)
            {
                MessageBox.Show("修改成功");
            }
        }

        private void ShowInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
