namespace test7
{
    partial class TeacherSelection
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
            this.butt_sure = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.list_course = new System.Windows.Forms.ListBox();
            this.list_tea = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("隶书", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(99, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 56);
            this.label3.TabIndex = 16;
            this.label3.Text = "教 师 授 课";
            // 
            // butt_sure
            // 
            this.butt_sure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt_sure.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butt_sure.ForeColor = System.Drawing.Color.White;
            this.butt_sure.Location = new System.Drawing.Point(198, 438);
            this.butt_sure.Name = "butt_sure";
            this.butt_sure.Size = new System.Drawing.Size(115, 37);
            this.butt_sure.TabIndex = 27;
            this.butt_sure.Text = "确认授课";
            this.butt_sure.UseVisualStyleBackColor = true;
            this.butt_sure.Click += new System.EventHandler(this.butt_sure_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(306, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "课程：";
            // 
            // list_course
            // 
            this.list_course.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.list_course.FormattingEnabled = true;
            this.list_course.ItemHeight = 21;
            this.list_course.Location = new System.Drawing.Point(310, 178);
            this.list_course.Name = "list_course";
            this.list_course.Size = new System.Drawing.Size(169, 214);
            this.list_course.TabIndex = 25;
            this.list_course.SelectedIndexChanged += new System.EventHandler(this.list_course_SelectedIndexChanged);
            // 
            // list_tea
            // 
            this.list_tea.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.list_tea.FormattingEnabled = true;
            this.list_tea.ItemHeight = 21;
            this.list_tea.Location = new System.Drawing.Point(88, 178);
            this.list_tea.Name = "list_tea";
            this.list_tea.Size = new System.Drawing.Size(130, 214);
            this.list_tea.TabIndex = 24;
            this.list_tea.SelectedIndexChanged += new System.EventHandler(this.list_tea_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "教师：";
            // 
            // TeacherSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(562, 625);
            this.Controls.Add(this.butt_sure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_course);
            this.Controls.Add(this.list_tea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "TeacherSelection";
            this.Text = "TeacherSelection";
            this.Load += new System.EventHandler(this.TeacherSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butt_sure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox list_course;
        private System.Windows.Forms.ListBox list_tea;
        private System.Windows.Forms.Label label1;
    }
}