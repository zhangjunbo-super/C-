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
    public partial class InsertGrades : Form
    {
        DBHelper dBHelper;
        String userId;
        String connetStr = "server=127.0.0.1;port=3306; user=root;password=zhangjunbo;database=test7";
        String tag;
        String c_id;
        String s_id;
        public InsertGrades(String userId)
        {
            InitializeComponent();
            this.userId = userId;
            dBHelper = new DBHelper(connetStr);
            //动态加载教师的课程
            combo_course.Items.Clear();
            DataTable dt = dBHelper.Select("select c_name from course where c_id in(select c_id from tea_cou where t_id='" + userId + "')");
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
                    combo_course.Items.Add(drow[0]);
                }
            }
        }

        private void InsertGrades_Load(object sender, EventArgs e)
        {

        }

        private void combo_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_student.Items.Clear();
            String course = combo_course.SelectedItem.ToString();
            String sql = "select s_name from students where s_id in(select s_id from stu_grades where c_id in(select c_id from course where c_name='"+course+"' and c_id in(select c_id from tea_cou where t_id='"+userId+"')))";

            DataTable dt = dBHelper.Select(sql);
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
                    list_student.Items.Add(drow[0]);
                }
            }

        }

        private void list_student_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = list_student.SelectedItem.ToString();
            String course = combo_course.SelectedItem.ToString();
            String sql = "select grade,tag,c_id,s_id from stu_grades where s_id in(select s_id from students where s_name='"+name+"') and c_id in(select c_id from course where c_name='"+course+"') ";
            Console.WriteLine(sql);
            DataTable dt = dBHelper.Select(sql);
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
                    text_grade.Text = drow[0].ToString();
                    tag = drow[1].ToString();
                    c_id = drow[2].ToString();
                    s_id = drow[3].ToString();
                }
            }
            if (tag.Equals("1")) 
            {
                text_grade.Enabled = false;
                butt_save.Enabled = false;
                butt_submit.Enabled = false;
            }
            else
            {
                text_grade.Enabled = true;
                butt_save.Enabled = true;
                butt_submit.Enabled = true;
            }

        }

        private void butt_save_Click(object sender, EventArgs e)
        {
            int grade = 0;
            if (!text_grade.Text.Equals(""))
            {
                 grade= Int32.Parse(text_grade.Text);
            }
            
            String sql = "update stu_grades set grade="+grade+" where s_id='"+s_id+"' and c_id='"+c_id+"' ";
            if (dBHelper.Update(sql) != 0)
            {
                MessageBox.Show("修改成功");
            }
        }

        private void butt_submit_Click(object sender, EventArgs e)
        {
            int grade = Int32.Parse(text_grade.Text);
            String sql = "update stu_grades set grade=" + grade + ",tag=1 where s_id='" + s_id + "' and c_id='" + c_id + "' ";
            if (dBHelper.Update(sql) != 0)
            {
                MessageBox.Show("修改成功");
            }
        }
    }
}
