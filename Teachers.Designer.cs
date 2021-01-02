namespace test7
{
    partial class Teachers
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("个人信息");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("成绩录入");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("查看成绩");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("退出登陆");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("教师", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.panel_top = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel_mid = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel_top.Size = new System.Drawing.Size(962, 56);
            this.panel_top.TabIndex = 1;
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
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("隶书", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.Location = new System.Drawing.Point(0, 56);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点1";
            treeNode1.Text = "个人信息";
            treeNode2.Name = "节点2";
            treeNode2.Text = "成绩录入";
            treeNode3.Name = "节点3";
            treeNode3.Text = "查看成绩";
            treeNode4.Name = "节点4";
            treeNode4.Text = "退出登陆";
            treeNode5.Name = "节点0";
            treeNode5.Text = "教师";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(148, 580);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel_mid
            // 
            this.panel_mid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_mid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_mid.Controls.Add(this.label1);
            this.panel_mid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mid.Location = new System.Drawing.Point(148, 56);
            this.panel_mid.Name = "panel_mid";
            this.panel_mid.Size = new System.Drawing.Size(814, 580);
            this.panel_mid.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "教务管理系统";
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 636);
            this.Controls.Add(this.panel_mid);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel_top);
            this.IsMdiContainer = true;
            this.Name = "Teachers";
            this.Text = "teachers";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_mid.ResumeLayout(false);
            this.panel_mid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel_mid;
        private System.Windows.Forms.Label label1;
    }
}