﻿
namespace case_22331099
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Telephone = new System.Windows.Forms.TextBox();
            this.nudown_Age = new System.Windows.Forms.NumericUpDown();
            this.rbtn_Sex2 = new System.Windows.Forms.RadioButton();
            this.rbtn_Sex1 = new System.Windows.Forms.RadioButton();
            this.txt_Company = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_Customer = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Del = new System.Windows.Forms.Button();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudown_Age)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.txt_Address);
            this.groupBox1.Controls.Add(this.txt_Telephone);
            this.groupBox1.Controls.Add(this.nudown_Age);
            this.groupBox1.Controls.Add(this.rbtn_Sex2);
            this.groupBox1.Controls.Add(this.rbtn_Sex1);
            this.groupBox1.Controls.Add(this.txt_Company);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(114, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑客户信息 状态：";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(476, 181);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 42);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(137, 181);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 42);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(476, 126);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(100, 28);
            this.txt_Address.TabIndex = 12;
            // 
            // txt_Telephone
            // 
            this.txt_Telephone.Location = new System.Drawing.Point(137, 126);
            this.txt_Telephone.Name = "txt_Telephone";
            this.txt_Telephone.Size = new System.Drawing.Size(100, 28);
            this.txt_Telephone.TabIndex = 11;
            // 
            // nudown_Age
            // 
            this.nudown_Age.Location = new System.Drawing.Point(476, 85);
            this.nudown_Age.Name = "nudown_Age";
            this.nudown_Age.Size = new System.Drawing.Size(120, 28);
            this.nudown_Age.TabIndex = 10;
            // 
            // rbtn_Sex2
            // 
            this.rbtn_Sex2.AutoSize = true;
            this.rbtn_Sex2.Location = new System.Drawing.Point(195, 84);
            this.rbtn_Sex2.Name = "rbtn_Sex2";
            this.rbtn_Sex2.Size = new System.Drawing.Size(51, 22);
            this.rbtn_Sex2.TabIndex = 9;
            this.rbtn_Sex2.TabStop = true;
            this.rbtn_Sex2.Text = "女";
            this.rbtn_Sex2.UseVisualStyleBackColor = true;
            // 
            // rbtn_Sex1
            // 
            this.rbtn_Sex1.AutoSize = true;
            this.rbtn_Sex1.Location = new System.Drawing.Point(137, 85);
            this.rbtn_Sex1.Name = "rbtn_Sex1";
            this.rbtn_Sex1.Size = new System.Drawing.Size(51, 22);
            this.rbtn_Sex1.TabIndex = 8;
            this.rbtn_Sex1.TabStop = true;
            this.rbtn_Sex1.Text = "男";
            this.rbtn_Sex1.UseVisualStyleBackColor = true;
            // 
            // txt_Company
            // 
            this.txt_Company.Location = new System.Drawing.Point(476, 38);
            this.txt_Company.Name = "txt_Company";
            this.txt_Company.Size = new System.Drawing.Size(100, 28);
            this.txt_Company.TabIndex = 7;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(137, 39);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 28);
            this.txt_Name.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "地址";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "年龄";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "单位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "电话";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "性别";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_Customer);
            this.groupBox2.Controls.Add(this.btn_Del);
            this.groupBox2.Location = new System.Drawing.Point(114, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 263);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "客户信息列表";
            // 
            // lv_Customer
            // 
            this.lv_Customer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lv_Customer.FullRowSelect = true;
            this.lv_Customer.GridLines = true;
            this.lv_Customer.HideSelection = false;
            this.lv_Customer.Location = new System.Drawing.Point(62, 56);
            this.lv_Customer.MultiSelect = false;
            this.lv_Customer.Name = "lv_Customer";
            this.lv_Customer.Size = new System.Drawing.Size(643, 186);
            this.lv_Customer.TabIndex = 1;
            this.lv_Customer.UseCompatibleStateImageBehavior = false;
            this.lv_Customer.View = System.Windows.Forms.View.Details;
            this.lv_Customer.SelectedIndexChanged += new System.EventHandler(this.lv_Customer_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓名";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "单位";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "性别";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "年龄";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "电话";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "地址";
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(137, 13);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 37);
            this.btn_Del.TabIndex = 0;
            this.btn_Del.Text = "删除";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(309, 13);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(44, 18);
            this.lbl_Status.TabIndex = 2;
            this.lbl_Status.Text = "添加";
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Location = new System.Drawing.Point(267, 306);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(26, 18);
            this.lbl_Note.TabIndex = 3;
            this.lbl_Note.Text = "  ";
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(33, 22);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 39);
            this.btn_return.TabIndex = 16;
            this.btn_return.Text = "返回";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 620);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "客户信息管理页";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudown_Age)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Telephone;
        private System.Windows.Forms.NumericUpDown nudown_Age;
        private System.Windows.Forms.RadioButton rbtn_Sex2;
        private System.Windows.Forms.RadioButton rbtn_Sex1;
        private System.Windows.Forms.TextBox txt_Company;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lv_Customer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Button btn_return;
    }
}

