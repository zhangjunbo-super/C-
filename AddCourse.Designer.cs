namespace test7
{
    partial class AddCourse
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
            this.label2 = new System.Windows.Forms.Label();
            this.course_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.course_name = new System.Windows.Forms.TextBox();
            this.butt_sure = new System.Windows.Forms.Button();
            this.course_place = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("隶书", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(98, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 56);
            this.label3.TabIndex = 17;
            this.label3.Text = "添 加 课 程";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(81, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "课程编号：";
            // 
            // course_id
            // 
            this.course_id.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.course_id.Location = new System.Drawing.Point(202, 125);
            this.course_id.Name = "course_id";
            this.course_id.Size = new System.Drawing.Size(193, 31);
            this.course_id.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "课程名称：";
            // 
            // course_name
            // 
            this.course_name.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.course_name.Location = new System.Drawing.Point(202, 183);
            this.course_name.Name = "course_name";
            this.course_name.Size = new System.Drawing.Size(193, 31);
            this.course_name.TabIndex = 30;
            // 
            // butt_sure
            // 
            this.butt_sure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt_sure.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butt_sure.ForeColor = System.Drawing.Color.White;
            this.butt_sure.Location = new System.Drawing.Point(192, 317);
            this.butt_sure.Name = "butt_sure";
            this.butt_sure.Size = new System.Drawing.Size(115, 37);
            this.butt_sure.TabIndex = 31;
            this.butt_sure.Text = "确认添加";
            this.butt_sure.UseVisualStyleBackColor = true;
            this.butt_sure.Click += new System.EventHandler(this.butt_sure_Click);
            // 
            // course_place
            // 
            this.course_place.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.course_place.Location = new System.Drawing.Point(202, 240);
            this.course_place.Name = "course_place";
            this.course_place.Size = new System.Drawing.Size(193, 31);
            this.course_place.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(81, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "上课地点：";
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(540, 542);
            this.Controls.Add(this.course_place);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butt_sure);
            this.Controls.Add(this.course_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.course_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "AddCourse";
            this.Text = "AddCourse";
            this.Load += new System.EventHandler(this.AddCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox course_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox course_name;
        private System.Windows.Forms.Button butt_sure;
        private System.Windows.Forms.TextBox course_place;
        private System.Windows.Forms.Label label4;
    }
}