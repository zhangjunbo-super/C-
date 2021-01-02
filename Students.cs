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
    public partial class Students : Form
    {
        String userId;
        String pass;
        String role;
        public Students(String userId, String pass, String role)
        {
            InitializeComponent();
            this.userId = userId;
            this.pass = pass;
            this.role = role;
            label2.Text = "用户：" + userId + "，欢迎！";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;//显示在屏幕中间

            //初始化加载数据

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (treeView1.SelectedNode.Text)
            {
                case "个人信息":
                    panel_mid.Controls.Clear();
                    ShowInformation information = new ShowInformation(userId,pass,role);
                    information.MdiParent = this;//设置父子关系
                    information.Parent = panel_mid;//设置子窗体的容器
                    information.FormBorderStyle = FormBorderStyle.None;
                    information.Dock = DockStyle.Fill;
                    information.Show();//显示子窗体
                    break;
                case "课程查询": 
                    panel_mid.Controls.Clear();
                    ShowCourse course = new ShowCourse(userId);
                    course.MdiParent = this;
                    course.Parent = panel_mid;
                    course.FormBorderStyle = FormBorderStyle.None;
                    course.Dock = DockStyle.Fill;
                    course.Show();
                    break;
                case "成绩查询":
                    panel_mid.Controls.Clear();
                    ShowGrades_S grade = new ShowGrades_S(userId);
                    grade.MdiParent = this;
                    grade.Parent = panel_mid;
                    grade.FormBorderStyle = FormBorderStyle.None;
                    grade.Dock = DockStyle.Fill;
                    grade.Show();
                    break;
                case "退出登录":
                    DialogResult dr=MessageBox.Show("确定退出当前账户嘛？","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
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
