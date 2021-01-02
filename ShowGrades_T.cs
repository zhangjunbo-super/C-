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
    public partial class ShowGrades_T : Form
    {
        DBHelper dBHelper;
        String userId;
        String connetStr = "server=127.0.0.1;port=3306; user=root;password=zhangjunbo;database=test7";
        public ShowGrades_T(String userId)
        {
            InitializeComponent();
            dBHelper = new DBHelper(connetStr);
            this.userId = userId;
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

        private void ShowGrades_T_Load(object sender, EventArgs e)
        {

        }

        private void combo_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            String course = combo_course.SelectedItem.ToString();
            String sql = "select students.s_id,s_name,grade from students,stu_grades,course where students.s_id=stu_grades.s_id and course.c_id=stu_grades.c_id and course.c_name='" + course + "'";
            Console.WriteLine(sql);
            DataTable dt = dBHelper.Select(sql);
            dt.Columns[0].ColumnName = "学号";
            dt.Columns[1].ColumnName = "姓名";
            dt.Columns[2].ColumnName = "成绩";
            dataGridView1.DataSource = dt;
            
        }
    }
}
