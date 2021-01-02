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
    public partial class TeacherSelection : Form
    {
        DBHelper dBHelper;
        String connetStr = "server=127.0.0.1;port=3306; user=root;password=zhangjunbo;database=test7";
        String t_id;
        String c_id;
        public TeacherSelection()
        {
            InitializeComponent();
            dBHelper = new DBHelper(connetStr);
            //查询老师
            list_tea.Items.Clear();
            DataTable dt = dBHelper.Select("select t_name from teachers");
            DataRowCollection drc = dt.Rows;
            DataRow drow;
            if (drc.Count == 0)
            {
                MessageBox.Show("没有老师了");
                butt_sure.Enabled = false;
            }
            else
            {
                butt_sure.Enabled = true;
                for (int i = 0; i < drc.Count; i++)
                {
                    drow = drc[i];
                    list_tea.Items.Add(drow[0]);
                }
            }
            //查询无人上课的课程
            list_course.Items.Clear();
            DataTable dt1 = dBHelper.Select("select c_name from course where c_id not in(select c_id from tea_cou)");
            DataRowCollection drc1 = dt1.Rows;
            DataRow drow1;
            if (drc1.Count == 0)
            {
                butt_sure.Enabled = false;
                MessageBox.Show("所有课都有老师上了");
            }
            else
            {
                butt_sure.Enabled = true;
                for (int i = 0; i < drc1.Count; i++)
                {
                    drow1 = drc1[i];
                    list_course.Items.Add(drow1[0]);
                }
            }

        }

        private void TeacherSelection_Load(object sender, EventArgs e)
        {

        }

        private void list_tea_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = list_tea.SelectedItem.ToString();
            DataTable dt = dBHelper.Select("select t_id from teachers where t_name='" + name + "'");
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
                    t_id = drow[0].ToString();
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

        private void butt_sure_Click(object sender, EventArgs e)
        {
            String name = list_tea.SelectedItem.ToString();
            String course = list_course.SelectedItem.ToString();
            String sql = "insert into tea_cou values('"+t_id+"','"+c_id+"')";
            Console.WriteLine(sql);
            if (dBHelper.Insert(sql) != 0)
            {
                MessageBox.Show("授课成功");
            }
            else
            {
                MessageBox.Show("此课程已经有人教授");
            }
        }
    }
}
