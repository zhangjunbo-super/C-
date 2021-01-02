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
    public partial class AddCourse : Form
    {
        DBHelper dBHelper;
        String connetStr = "server=127.0.0.1;port=3306; user=root;password=zhangjunbo;database=test7";
        public AddCourse()
        {
            InitializeComponent();
            dBHelper = new DBHelper(connetStr);
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {

        }

        private void butt_sure_Click(object sender, EventArgs e)
        {
            if(course_id.Text==String.Empty || course_name.Text == String.Empty)
            {
                MessageBox.Show("请输入课程编号和名称");
            }
            else
            {
                String id = course_id.Text;
                String name = course_name.Text;
                String place = course_place.Text;
                String sql = "insert into course values('"+id+"','"+name+"','"+place+"')";
                if (dBHelper.Insert(sql) != 0)
                {
                    MessageBox.Show("添加课程成功");
                }
                else
                {
                    MessageBox.Show("课程已存在");
                }
            }
        }
    }
}
