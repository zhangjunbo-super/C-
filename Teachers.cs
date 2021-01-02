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
    public partial class Teachers : Form
    {
        String userId;
        String pass;
        String role;
        public Teachers(String userId,String pass,String role)
        {
            InitializeComponent();
            this.userId = userId;
            this.pass = pass;
            this.role = role;
            label2.Text = "用户：" + userId + ",欢迎!";
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (treeView1.SelectedNode.Text)
            {
                case "个人信息":
                    panel_mid.Controls.Clear();
                    ShowInformation information = new ShowInformation(userId, pass,role);
                    information.MdiParent = this;//设置父子关系
                    information.Parent = panel_mid;//设置子窗体的容器
                    information.FormBorderStyle = FormBorderStyle.None;
                    information.Dock = DockStyle.Fill;
                    information.Show();//显示子窗体
                    break;
                case "查看成绩":
                    panel_mid.Controls.Clear();
                    ShowGrades_T showGrades = new ShowGrades_T(userId);
                    showGrades.MdiParent = this;
                    showGrades.Parent = panel_mid;
                    showGrades.FormBorderStyle = FormBorderStyle.None;
                    showGrades.Dock = DockStyle.Fill;
                    showGrades.Show();
                    break;
                case "成绩录入":
                    panel_mid.Controls.Clear();
                    InsertGrades insertGrades = new InsertGrades(userId);
                    insertGrades.MdiParent = this;
                    insertGrades.Parent = panel_mid;
                    insertGrades.FormBorderStyle = FormBorderStyle.None;
                    insertGrades.Dock = DockStyle.Fill;
                    insertGrades.Show();
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

