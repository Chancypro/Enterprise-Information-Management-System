
namespace case_22331099
{
    partial class Frm_SignUp
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
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_RePassword = new System.Windows.Forms.TextBox();
            this.rbtn_Sex1 = new System.Windows.Forms.RadioButton();
            this.rbtn_Sex2 = new System.Windows.Forms.RadioButton();
            this.nudown_Age = new System.Windows.Forms.NumericUpDown();
            this.btn_Register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudown_Age)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(213, 56);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(100, 28);
            this.txt_UserName.TabIndex = 0;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(213, 128);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(100, 28);
            this.txt_Password.TabIndex = 1;
            // 
            // txt_RePassword
            // 
            this.txt_RePassword.Location = new System.Drawing.Point(213, 212);
            this.txt_RePassword.Name = "txt_RePassword";
            this.txt_RePassword.PasswordChar = '*';
            this.txt_RePassword.Size = new System.Drawing.Size(100, 28);
            this.txt_RePassword.TabIndex = 2;
            // 
            // rbtn_Sex1
            // 
            this.rbtn_Sex1.AutoSize = true;
            this.rbtn_Sex1.Location = new System.Drawing.Point(213, 304);
            this.rbtn_Sex1.Name = "rbtn_Sex1";
            this.rbtn_Sex1.Size = new System.Drawing.Size(51, 22);
            this.rbtn_Sex1.TabIndex = 4;
            this.rbtn_Sex1.TabStop = true;
            this.rbtn_Sex1.Text = "男";
            this.rbtn_Sex1.UseVisualStyleBackColor = true;
            // 
            // rbtn_Sex2
            // 
            this.rbtn_Sex2.AutoSize = true;
            this.rbtn_Sex2.Location = new System.Drawing.Point(342, 304);
            this.rbtn_Sex2.Name = "rbtn_Sex2";
            this.rbtn_Sex2.Size = new System.Drawing.Size(51, 22);
            this.rbtn_Sex2.TabIndex = 5;
            this.rbtn_Sex2.TabStop = true;
            this.rbtn_Sex2.Text = "女";
            this.rbtn_Sex2.UseVisualStyleBackColor = true;
            // 
            // nudown_Age
            // 
            this.nudown_Age.Location = new System.Drawing.Point(213, 365);
            this.nudown_Age.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudown_Age.Name = "nudown_Age";
            this.nudown_Age.Size = new System.Drawing.Size(120, 28);
            this.nudown_Age.TabIndex = 6;
            this.nudown_Age.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(213, 444);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(87, 37);
            this.btn_Register.TabIndex = 7;
            this.btn_Register.Text = "注册";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "确认密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "性别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "年龄";
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(35, 23);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 39);
            this.btn_return.TabIndex = 13;
            this.btn_return.Text = "返回";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // Frm_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 587);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.nudown_Age);
            this.Controls.Add(this.rbtn_Sex2);
            this.Controls.Add(this.rbtn_Sex1);
            this.Controls.Add(this.txt_RePassword);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Name = "Frm_SignUp";
            this.Text = "用户注册页";
            ((System.ComponentModel.ISupportInitialize)(this.nudown_Age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_RePassword;
        private System.Windows.Forms.RadioButton rbtn_Sex1;
        private System.Windows.Forms.RadioButton rbtn_Sex2;
        private System.Windows.Forms.NumericUpDown nudown_Age;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_return;
    }
}