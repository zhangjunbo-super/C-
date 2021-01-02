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
    public partial class ShowGrades_S : Form
    {
        String userId;
        String connetStr = "server=127.0.0.1;port=3306; user=root;password=zhangjunbo;database=test7";
        DBHelper dBHelpe;
        public ShowGrades_S(String userId)
        {
            InitializeComponent();
            this.userId = userId;
            dBHelpe = new DBHelper(connetStr);

            DataTable dt = dBHelpe.Select("select students.s_id,s_name,c_name,grade from course,students,stu_grades where stu_grades.s_id=students.s_id and stu_grades.c_id=course.c_id and students.s_id='" + userId + "'");
            DataRowCollection drc1 = dt.Rows;
            dt.Columns[0].ColumnName = "学号";
            dt.Columns[1].ColumnName = "姓名";
            dt.Columns[2].ColumnName = "课程";
            dt.Columns[3].ColumnName = "成绩";
            
            if (drc1.Count == 0)
            {
                MessageBox.Show("无成绩记录");
            }
            else
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowGrades_Load(object sender, EventArgs e)
        {

        }
    }
}
