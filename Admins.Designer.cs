namespace test7
{
    partial class Admins
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("注册与修改");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("学生选课");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("教师授课");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("添加课程");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("删除课程");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("退出登陆");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("管理员", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_mid = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            this.panel_mid.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("隶书", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.Location = new System.Drawing.Point(0, 56);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点2";
            treeNode1.Text = "注册与修改";
            treeNode2.Name = "节点3";
            treeNode2.Text = "学生选课";
            treeNode3.Name = "节点4";
            treeNode3.Text = "教师授课";
            treeNode4.Name = "节点5";
            treeNode4.Text = "添加课程";
            treeNode5.Name = "节点1";
            treeNode5.Text = "删除课程";
            treeNode6.Name = "节点0";
            treeNode6.Text = "退出登陆";
            treeNode7.Name = "节点0";
            treeNode7.Text = "管理员";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(158, 601);
            this.treeView1.TabIndex = 6;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_top.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_top.Controls.Add(this.label2);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(997, 56);
            this.panel_top.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("隶书", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "用户：";
            // 
            // panel_mid
            // 
            this.panel_mid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_mid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_mid.Controls.Add(this.label1);
            this.panel_mid.Location = new System.Drawing.Point(155, 56);
            this.panel_mid.Name = "panel_mid";
            this.panel_mid.Size = new System.Drawing.Size(842, 601);
            this.panel_mid.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "教务管理系统";
            // 
            // Admins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 657);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_mid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "Admins";
            this.Text = "Admins";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_mid.ResumeLayout(false);
            this.panel_mid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_mid;
        private System.Windows.Forms.Label label1;
    }
}