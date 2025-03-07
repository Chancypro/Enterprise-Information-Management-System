
namespace case_22331099
{
    partial class Frm_query
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_Customer = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_Sex3 = new System.Windows.Forms.RadioButton();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Telephone = new System.Windows.Forms.TextBox();
            this.rbtn_Sex2 = new System.Windows.Forms.RadioButton();
            this.rbtn_Sex1 = new System.Windows.Forms.RadioButton();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_Customer);
            this.groupBox2.Location = new System.Drawing.Point(98, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 263);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "员工信息列表";
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
            this.columnHeader7,
            this.columnHeader8});
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
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "工号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "名";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "姓";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "性别";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "入职日期";
            this.columnHeader5.Width = 108;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "出生日期";
            this.columnHeader6.Width = 105;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "地址";
            this.columnHeader7.Width = 89;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "联系电话";
            this.columnHeader8.Width = 215;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_Sex3);
            this.groupBox1.Controls.Add(this.txt_LastName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_find);
            this.groupBox1.Controls.Add(this.txt_Address);
            this.groupBox1.Controls.Add(this.txt_Telephone);
            this.groupBox1.Controls.Add(this.rbtn_Sex2);
            this.groupBox1.Controls.Add(this.rbtn_Sex1);
            this.groupBox1.Controls.Add(this.txt_FirstName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(98, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 267);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询员工信息";
            // 
            // rbtn_Sex3
            // 
            this.rbtn_Sex3.AutoSize = true;
            this.rbtn_Sex3.Location = new System.Drawing.Point(263, 122);
            this.rbtn_Sex3.Name = "rbtn_Sex3";
            this.rbtn_Sex3.Size = new System.Drawing.Size(69, 22);
            this.rbtn_Sex3.TabIndex = 21;
            this.rbtn_Sex3.TabStop = true;
            this.rbtn_Sex3.Text = "全部";
            this.rbtn_Sex3.UseVisualStyleBackColor = true;
            this.rbtn_Sex3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(137, 83);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(100, 28);
            this.txt_LastName.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "姓";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(630, 186);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 42);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "清空";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(434, 186);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 42);
            this.btn_find.TabIndex = 13;
            this.btn_find.Text = "查询";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(145, 162);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(100, 28);
            this.txt_Address.TabIndex = 12;
            // 
            // txt_Telephone
            // 
            this.txt_Telephone.Location = new System.Drawing.Point(145, 200);
            this.txt_Telephone.Name = "txt_Telephone";
            this.txt_Telephone.Size = new System.Drawing.Size(100, 28);
            this.txt_Telephone.TabIndex = 11;
            // 
            // rbtn_Sex2
            // 
            this.rbtn_Sex2.AutoSize = true;
            this.rbtn_Sex2.Location = new System.Drawing.Point(194, 122);
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
            this.rbtn_Sex1.Location = new System.Drawing.Point(137, 124);
            this.rbtn_Sex1.Name = "rbtn_Sex1";
            this.rbtn_Sex1.Size = new System.Drawing.Size(51, 22);
            this.rbtn_Sex1.TabIndex = 8;
            this.rbtn_Sex1.TabStop = true;
            this.rbtn_Sex1.Text = "男";
            this.rbtn_Sex1.UseVisualStyleBackColor = true;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(137, 39);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(100, 28);
            this.txt_FirstName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "电话";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 126);
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
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "名";
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(26, 28);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 39);
            this.btn_return.TabIndex = 17;
            this.btn_return.Text = "返回";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // Frm_query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 680);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_query";
            this.Text = "员工信息查询页";
            this.Load += new System.EventHandler(this.Frm_query_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lv_Customer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Telephone;
        private System.Windows.Forms.RadioButton rbtn_Sex2;
        private System.Windows.Forms.RadioButton rbtn_Sex1;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn_Sex3;
        private System.Windows.Forms.Button btn_return;
    }
}