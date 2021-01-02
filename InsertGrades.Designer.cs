namespace test7
{
    partial class InsertGrades
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
            this.label2 = new System.Windows.Forms.Label();
            this.combo_course = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.list_student = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_grade = new System.Windows.Forms.TextBox();
            this.butt_save = new System.Windows.Forms.Button();
            this.butt_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("隶书", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(127, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 56);
            this.label2.TabIndex = 5;
            this.label2.Text = "成绩录入";
            // 
            // combo_course
            // 
            this.combo_course.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combo_course.FormattingEnabled = true;
            this.combo_course.Location = new System.Drawing.Point(137, 113);
            this.combo_course.Name = "combo_course";
            this.combo_course.Size = new System.Drawing.Size(275, 29);
            this.combo_course.TabIndex = 8;
            this.combo_course.Text = "请选择课程";
            this.combo_course.SelectedIndexChanged += new System.EventHandler(this.combo_course_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "课程：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "课程学生：";
            // 
            // list_student
            // 
            this.list_student.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.list_student.FormattingEnabled = true;
            this.list_student.ItemHeight = 21;
            this.list_student.Location = new System.Drawing.Point(62, 196);
            this.list_student.Name = "list_student";
            this.list_student.Size = new System.Drawing.Size(135, 193);
            this.list_student.TabIndex = 11;
            this.list_student.SelectedIndexChanged += new System.EventHandler(this.list_student_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(224, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "录入成绩：";
            // 
            // text_grade
            // 
            this.text_grade.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_grade.Location = new System.Drawing.Point(228, 196);
            this.text_grade.Name = "text_grade";
            this.text_grade.Size = new System.Drawing.Size(184, 31);
            this.text_grade.TabIndex = 13;
            // 
            // butt_save
            // 
            this.butt_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt_save.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butt_save.ForeColor = System.Drawing.Color.White;
            this.butt_save.Location = new System.Drawing.Point(228, 352);
            this.butt_save.Name = "butt_save";
            this.butt_save.Size = new System.Drawing.Size(84, 37);
            this.butt_save.TabIndex = 14;
            this.butt_save.Text = "保存";
            this.butt_save.UseVisualStyleBackColor = true;
            this.butt_save.Click += new System.EventHandler(this.butt_save_Click);
            // 
            // butt_submit
            // 
            this.butt_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt_submit.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butt_submit.ForeColor = System.Drawing.Color.White;
            this.butt_submit.Location = new System.Drawing.Point(328, 352);
            this.butt_submit.Name = "butt_submit";
            this.butt_submit.Size = new System.Drawing.Size(84, 37);
            this.butt_submit.TabIndex = 15;
            this.butt_submit.Text = "提交";
            this.butt_submit.UseVisualStyleBackColor = true;
            this.butt_submit.Click += new System.EventHandler(this.butt_submit_Click);
            // 
            // InsertGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(555, 595);
            this.Controls.Add(this.butt_submit);
            this.Controls.Add(this.butt_save);
            this.Controls.Add(this.text_grade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.list_student);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_course);
            this.Controls.Add(this.label2);
            this.Name = "InsertGrades";
            this.Text = "InsertGrades";
            this.Load += new System.EventHandler(this.InsertGrades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_course;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox list_student;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_grade;
        private System.Windows.Forms.Button butt_save;
        private System.Windows.Forms.Button butt_submit;
    }
}