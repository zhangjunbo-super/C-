namespace test7
{
    partial class DeleteCourse
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
            this.butt_del = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.list_course = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("隶书", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 56);
            this.label3.TabIndex = 18;
            this.label3.Text = "删 除 课 程";
            // 
            // butt_del
            // 
            this.butt_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt_del.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butt_del.ForeColor = System.Drawing.Color.White;
            this.butt_del.Location = new System.Drawing.Point(142, 350);
            this.butt_del.Name = "butt_del";
            this.butt_del.Size = new System.Drawing.Size(115, 37);
            this.butt_del.TabIndex = 38;
            this.butt_del.Text = "确认删除";
            this.butt_del.UseVisualStyleBackColor = true;
            this.butt_del.Click += new System.EventHandler(this.butt_del_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(106, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "课程：";
            // 
            // list_course
            // 
            this.list_course.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.list_course.FormattingEnabled = true;
            this.list_course.ItemHeight = 21;
            this.list_course.Location = new System.Drawing.Point(175, 136);
            this.list_course.Name = "list_course";
            this.list_course.Size = new System.Drawing.Size(146, 172);
            this.list_course.TabIndex = 41;
            this.list_course.SelectedIndexChanged += new System.EventHandler(this.list_course_SelectedIndexChanged);
            // 
            // DeleteCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(403, 476);
            this.Controls.Add(this.list_course);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butt_del);
            this.Controls.Add(this.label3);
            this.Name = "DeleteCourse";
            this.Text = "DeleteCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butt_del;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox list_course;
    }
}