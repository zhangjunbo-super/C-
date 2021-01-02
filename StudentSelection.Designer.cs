namespace test7
{
    partial class StudentSelection
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.list_stu = new System.Windows.Forms.ListBox();
            this.list_course = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butt_sure = new System.Windows.Forms.Button();
            this.butt_del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("隶书", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 56);
            this.label3.TabIndex = 16;
            this.label3.Text = "学 生 选 课";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "学生：";
            // 
            // list_stu
            // 
            this.list_stu.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.list_stu.FormattingEnabled = true;
            this.list_stu.ItemHeight = 21;
            this.list_stu.Location = new System.Drawing.Point(53, 153);
            this.list_stu.Name = "list_stu";
            this.list_stu.Size = new System.Drawing.Size(130, 214);
            this.list_stu.TabIndex = 18;
            this.list_stu.SelectedIndexChanged += new System.EventHandler(this.list_stu_SelectedIndexChanged);
            // 
            // list_course
            // 
            this.list_course.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.list_course.FormattingEnabled = true;
            this.list_course.ItemHeight = 21;
            this.list_course.Location = new System.Drawing.Point(275, 153);
            this.list_course.Name = "list_course";
            this.list_course.Size = new System.Drawing.Size(169, 214);
            this.list_course.TabIndex = 19;
            this.list_course.SelectedIndexChanged += new System.EventHandler(this.list_course_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(271, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "课程：";
            // 
            // butt_sure
            // 
            this.butt_sure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt_sure.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butt_sure.ForeColor = System.Drawing.Color.White;
            this.butt_sure.Location = new System.Drawing.Point(83, 418);
            this.butt_sure.Name = "butt_sure";
            this.butt_sure.Size = new System.Drawing.Size(115, 37);
            this.butt_sure.TabIndex = 21;
            this.butt_sure.Text = "确认选课";
            this.butt_sure.UseVisualStyleBackColor = true;
            this.butt_sure.Click += new System.EventHandler(this.butt_sure_Click);
            // 
            // butt_del
            // 
            this.butt_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt_del.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butt_del.ForeColor = System.Drawing.Color.White;
            this.butt_del.Location = new System.Drawing.Point(254, 418);
            this.butt_del.Name = "butt_del";
            this.butt_del.Size = new System.Drawing.Size(115, 37);
            this.butt_del.TabIndex = 22;
            this.butt_del.Text = "删除选课";
            this.butt_del.UseVisualStyleBackColor = true;
            this.butt_del.Click += new System.EventHandler(this.butt_del_Click);
            // 
            // StudentSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 562);
            this.Controls.Add(this.butt_del);
            this.Controls.Add(this.butt_sure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_course);
            this.Controls.Add(this.list_stu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "StudentSelection";
            this.Text = "StudentSelection";
            this.Load += new System.EventHandler(this.StudentSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_stu;
        private System.Windows.Forms.ListBox list_course;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butt_sure;
        private System.Windows.Forms.Button butt_del;
    }
}