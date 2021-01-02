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
    public partial class Admins : Form
    {
        String userId;
        String pass;
        String role;
        public Admins(String userId,String pass,String role)
        {
            InitializeComponent();
            this.userId = userId;
            this.pass = pass;
            this.role = role;
            label2.Text = "用户：" + userId + "欢迎！";
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (treeView1.SelectedNode.Text)
            {
                case "注册与修改":
                    panel_mid.Controls.Clear();
                    Register register = new Register();
                    register.MdiParent = this;//设置父子关系
                    register.Parent = panel_mid;//设置子窗体的容器
                    register.FormBorderStyle = FormBorderStyle.None;
                    register.Dock = DockStyle.Fill;
                    register.Show();//显示子窗体
                    break;
                case "学生选课":
                    panel_mid.Controls.Clear();
                    StudentSelection studentSelection = new StudentSelection();
                    studentSelection.MdiParent = this;
                    studentSelection.Parent = panel_mid;
                    studentSelection.FormBorderStyle = FormBorderStyle.None;
                    studentSelection.Dock = DockStyle.Fill;
                    studentSelection.Show();
                    break;
                case "教师授课":
                    panel_mid.Controls.Clear();
                    TeacherSelection teacherSelection = new TeacherSelection();
                    teacherSelection.MdiParent = this;
                    teacherSelection.Parent = panel_mid;
                    teacherSelection.FormBorderStyle = FormBorderStyle.None;
                    teacherSelection.Dock = DockStyle.Fill;
                    teacherSelection.Show();
                    break;
                case "添加课程":
                    panel_mid.Controls.Clear();
                    AddCourse addCourse = new AddCourse();
                    addCourse.MdiParent = this;
                    addCourse.Parent = panel_mid;
                    addCourse.FormBorderStyle = FormBorderStyle.None;
                    addCourse.Dock = DockStyle.Fill;
                    addCourse.Show();
                    break;
                case "删除课程":
                    panel_mid.Controls.Clear();
                    DeleteCourse delCourse = new DeleteCourse();
                    delCourse.MdiParent = this;
                    delCourse.Parent = panel_mid;
                    delCourse.FormBorderStyle = FormBorderStyle.None;
                    delCourse.Dock = DockStyle.Fill;
                    delCourse.Show();
                    break;
                case "退出登陆":
                    DialogResult dr = MessageBox.Show("确定退出当前账户嘛？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        new Login().Show();
                        this.Hide();
                    }
                    break;
            }
        }
    }
}
