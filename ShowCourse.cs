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
    public partial class ShowCourse : Form
    {
        String userId;
        String connetStr = "server=127.0.0.1;port=3306; user=root;password=zhangjunbo;database=test7";
        DBHelper dBHelpe;
        public ShowCourse(String userId)
        {
            InitializeComponent();
            this.userId = userId;
            dBHelpe = new DBHelper(connetStr);

            String sql = "select c_name,t_name,c_place from course,tea_cou,teachers where teachers.t_id=tea_cou.t_id and course.c_id=tea_cou.c_id and course.c_id in(select c_id from stu_grades where s_id='" + userId + "')";
            Console.WriteLine(sql);
            DataTable dt = dBHelpe.Select(sql);
            DataRowCollection drc = dt.Rows;
            dt.Columns[0].ColumnName = "课程";
            dt.Columns[1].ColumnName = "教师";
            dt.Columns[2].ColumnName = "教室";
            if (drc.Count == 0)
            {
                MessageBox.Show("无课程记录");
            }
            else
            {
                dataGridView1.DataSource = dt;
            }

        }

        private void ShowCourse_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
