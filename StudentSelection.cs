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
    public partial class StudentSelection : Form
    {
        String connetStr = "server=127.0.0.1;port=3306; user=root;password=zhangjunbo;database=test7";
        String s_id;
        String c_id;
        DBHelper dBHelper;

        public StudentSelection()
        {
            InitializeComponent();
            dBHelper = new DBHelper(connetStr);

            //查询学生
            list_stu.Items.Clear();
            DataTable dt = dBHelper.Select("select s_name from students");
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
                    list_stu.Items.Add(drow[0]);
                }
            }
            //查询课程
            list_course.Items.Clear();
            DataTable dt1 = dBHelper.Select("select c_name from course where c_id in(select c_id from tea_cou)");
            DataRowCollection drc1 = dt1.Rows;
            DataRow drow1;
            if (drc1.Count == 0)
            {
                MessageBox.Show("您查询的信息不存在");
            }
            else
            {
                for (int i = 0; i < drc1.Count; i++)
                {
                    drow1 = drc1[i];
                    list_course.Items.Add(drow1[0]);
                }
            }
        }

        private void StudentSelection_Load(object sender, EventArgs e)
        {

        }

        private void butt_sure_Click(object sender, EventArgs e)
        {
            String name = list_stu.SelectedItem.ToString();
            String couse = list_course.SelectedItem.ToString();
            String sql = "insert into stu_grades values('"+s_id+"','"+c_id+"',null,null)";
            if (dBHelper.Insert(sql) != 0)
            {
                MessageBox.Show("选课成功");
            }
            else
            {
                MessageBox.Show(name+"同学已经选修了"+couse);
            }
        }

        private void butt_del_Click(object sender, EventArgs e)
        {
            String name = list_stu.SelectedItem.ToString();
            String couse = list_course.SelectedItem.ToString();
            String sql = "delete  from stu_grades where s_id='"+s_id+"' and c_id='"+c_id+"'";
            if (dBHelper.Delete(sql) != 0)
            {
                MessageBox.Show("退课成功");
            }
            else
            {
                MessageBox.Show(name + "同学没有选修" + couse);
            }
        }

        private void list_stu_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = list_stu.SelectedItem.ToString();
            DataTable dt = dBHelper.Select("select s_id from students where s_name='" + name + "'");
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
                    s_id = drow[0].ToString();
                }
            }
        }

        private void list_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            String course = list_course.SelectedItem.ToString();
            DataTable dt = dBHelper.Select("select c_id from course where c_name='" + course + "'");
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
                    c_id = drow[0].ToString();
                }
            }
        }
    }
}
