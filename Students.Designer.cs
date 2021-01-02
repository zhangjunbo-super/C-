namespace test7
{
    partial class Students
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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("个人信息");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("课程查询");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("成绩查询");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("退出登录");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("学生", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            this.panel_top = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_mid = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel_top.SuspendLayout();
            this.panel_mid.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_top.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_top.Controls.Add(this.label2);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1024, 56);
            this.panel_top.TabIndex = 0;
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
            this.panel_mid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_mid.Controls.Add(this.label1);
            this.panel_mid.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_mid.Location = new System.Drawing.Point(153, 56);
            this.panel_mid.Name = "panel_mid";
            this.panel_mid.Padding = new System.Windows.Forms.Padding(50);
            this.panel_mid.Size = new System.Drawing.Size(871, 698);
            this.panel_mid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(137, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "教务管理系统";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("隶书", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.Location = new System.Drawing.Point(0, 56);
            this.treeView1.Name = "treeView1";
            treeNode6.Name = "节点1";
            treeNode6.Text = "个人信息";
            treeNode7.Name = "节点2";
            treeNode7.Text = "课程查询";
            treeNode8.Name = "节点3";
            treeNode8.Text = "成绩查询";
            treeNode9.Name = "节点4";
            treeNode9.Text = "退出登录";
            treeNode10.Name = "节点0";
            treeNode10.Text = "学生";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(154, 698);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1024, 754);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel_mid);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "Students";
            this.Text = "Students";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_mid.ResumeLayout(false);
            this.panel_mid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_mid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
    }
}