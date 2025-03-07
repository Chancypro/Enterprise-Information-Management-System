
namespace case_22331099
{
    partial class Frm_ed
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
            this.lbl_Note = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_Customer = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Del = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_Ed_leavedate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Ed_entrydate = new System.Windows.Forms.DateTimePicker();
            this.nudown_Ed_Status = new System.Windows.Forms.NumericUpDown();
            this.nudown_dept_no = new System.Windows.Forms.NumericUpDown();
            this.nudown_emp_no = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudown_Ed_Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudown_dept_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudown_emp_no)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Location = new System.Drawing.Point(253, 339);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(26, 18);
            this.lbl_Note.TabIndex = 11;
            this.lbl_Note.Text = "  ";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(358, 48);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(44, 18);
            this.lbl_Status.TabIndex = 10;
            this.lbl_Status.Text = "添加";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_Customer);
            this.groupBox2.Controls.Add(this.btn_Del);
            this.groupBox2.Location = new System.Drawing.Point(100, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 282);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "员工部门隶属信息列表";
            // 
            // lv_Customer
            // 
            this.lv_Customer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_Customer.FullRowSelect = true;
            this.lv_Customer.GridLines = true;
            this.lv_Customer.HideSelection = false;
            this.lv_Customer.Location = new System.Drawing.Point(42, 65);
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
            this.columnHeader2.Text = "工号";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "部门编号";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "加入日期";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "离开日期";
            this.columnHeader5.Width = 108;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "当前状态";
            this.columnHeader6.Width = 105;
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(137, 22);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 37);
            this.btn_Del.TabIndex = 0;
            this.btn_Del.Text = "删除";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_Ed_leavedate);
            this.groupBox1.Controls.Add(this.dateTimePicker_Ed_entrydate);
            this.groupBox1.Controls.Add(this.nudown_Ed_Status);
            this.groupBox1.Controls.Add(this.nudown_dept_no);
            this.groupBox1.Controls.Add(this.nudown_emp_no);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(100, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 267);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑员工部门隶属信息 状态：";
            // 
            // dateTimePicker_Ed_leavedate
            // 
            this.dateTimePicker_Ed_leavedate.Location = new System.Drawing.Point(137, 210);
            this.dateTimePicker_Ed_leavedate.Name = "dateTimePicker_Ed_leavedate";
            this.dateTimePicker_Ed_leavedate.Size = new System.Drawing.Size(200, 28);
            this.dateTimePicker_Ed_leavedate.TabIndex = 25;
            this.dateTimePicker_Ed_leavedate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker_Ed_entrydate
            // 
            this.dateTimePicker_Ed_entrydate.Location = new System.Drawing.Point(137, 164);
            this.dateTimePicker_Ed_entrydate.Name = "dateTimePicker_Ed_entrydate";
            this.dateTimePicker_Ed_entrydate.Size = new System.Drawing.Size(200, 28);
            this.dateTimePicker_Ed_entrydate.TabIndex = 24;
            this.dateTimePicker_Ed_entrydate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // nudown_Ed_Status
            // 
            this.nudown_Ed_Status.Location = new System.Drawing.Point(585, 47);
            this.nudown_Ed_Status.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudown_Ed_Status.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudown_Ed_Status.Name = "nudown_Ed_Status";
            this.nudown_Ed_Status.Size = new System.Drawing.Size(120, 28);
            this.nudown_Ed_Status.TabIndex = 23;
            this.nudown_Ed_Status.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudown_dept_no
            // 
            this.nudown_dept_no.Location = new System.Drawing.Point(156, 81);
            this.nudown_dept_no.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudown_dept_no.Name = "nudown_dept_no";
            this.nudown_dept_no.Size = new System.Drawing.Size(120, 28);
            this.nudown_dept_no.TabIndex = 22;
            // 
            // nudown_emp_no
            // 
            this.nudown_emp_no.Location = new System.Drawing.Point(156, 37);
            this.nudown_emp_no.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudown_emp_no.Name = "nudown_emp_no";
            this.nudown_emp_no.Size = new System.Drawing.Size(120, 28);
            this.nudown_emp_no.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "离开日期";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "加入日期";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "部门编号";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(668, 186);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 42);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(434, 186);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 42);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "当前状态";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "工号";
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(27, 24);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 39);
            this.btn_return.TabIndex = 16;
            this.btn_return.Text = "返回";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // Frm_ed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 672);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_ed";
            this.Text = "员工部门隶属信息管理页";
            this.Load += new System.EventHandler(this.Frm_ed_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudown_Ed_Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudown_dept_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudown_emp_no)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lv_Customer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudown_dept_no;
        private System.Windows.Forms.NumericUpDown nudown_emp_no;
        private System.Windows.Forms.NumericUpDown nudown_Ed_Status;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Ed_leavedate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Ed_entrydate;
        private System.Windows.Forms.Button btn_return;
    }
}