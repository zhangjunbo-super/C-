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
    public partial class DeleteCourse : Form
    {
        DBHelper dBHelper;
        String connetStr = "server=127.0.0.1;port=3306; user=root;password=zhangjunbo;database=test7";
        String c_id;
        public DeleteCourse()
        {
            InitializeComponent();
            dBHelper = new DBHelper(connetStr);

            //查询课程
            list_course.Items.Clear();
            DataTable dt1 = dBHelper.Select("select c_name from course where c_id not in(select c_id from stu_grades union select c_id from tea_cou)");
            DataRowCollection drc1 = dt1.Rows;
            DataRow drow1;
            if (drc1.Count == 0)
            {
                MessageBox.Show("所有课程都有人在修");
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

        private void butt_del_Click(object sender, EventArgs e)
        {
            String sql = "delete from course where c_id='"+c_id+"'";
            if (dBHelper.Delete(sql) != 0)
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }
    }
}
