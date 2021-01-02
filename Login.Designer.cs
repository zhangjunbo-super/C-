namespace test7
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.butt_login = new System.Windows.Forms.Button();
            this.butt_close = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(165, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(165, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "密  码：";
            // 
            // UserID
            // 
            this.UserID.BackColor = System.Drawing.Color.White;
            this.UserID.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserID.ForeColor = System.Drawing.Color.Black;
            this.UserID.Location = new System.Drawing.Point(289, 166);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(150, 31);
            this.UserID.TabIndex = 2;
            this.UserID.Text = "admin";
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.White;
            this.Password.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Password.ForeColor = System.Drawing.Color.Black;
            this.Password.Location = new System.Drawing.Point(289, 236);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(150, 31);
            this.Password.TabIndex = 3;
            this.Password.Text = "admin";
            // 
            // butt_login
            // 
            this.butt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt_login.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butt_login.ForeColor = System.Drawing.Color.White;
            this.butt_login.Location = new System.Drawing.Point(187, 324);
            this.butt_login.Name = "butt_login";
            this.butt_login.Size = new System.Drawing.Size(84, 37);
            this.butt_login.TabIndex = 4;
            this.butt_login.Text = "登录";
            this.butt_login.UseVisualStyleBackColor = true;
            this.butt_login.Click += new System.EventHandler(this.butt_login_Click);
            // 
            // butt_close
            // 
            this.butt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt_close.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butt_close.ForeColor = System.Drawing.Color.White;
            this.butt_close.Location = new System.Drawing.Point(373, 324);
            this.butt_close.Name = "butt_close";
            this.butt_close.Size = new System.Drawing.Size(84, 37);
            this.butt_close.TabIndex = 5;
            this.butt_close.Text = "关闭";
            this.butt_close.UseVisualStyleBackColor = true;
            this.butt_close.Click += new System.EventHandler(this.butt_close_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(460, 239);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 25);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "显示密码";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("隶书", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(72, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(528, 56);
            this.label3.TabIndex = 7;
            this.label3.Text = " 信 息 管 理 系 统";
            // 
            // Login
            // 
            this.AcceptButton = this.butt_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(670, 419);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.butt_close);
            this.Controls.Add(this.butt_login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.Text = "成绩管理系统";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserID;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button butt_login;
        private System.Windows.Forms.Button butt_close;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
    }
}

