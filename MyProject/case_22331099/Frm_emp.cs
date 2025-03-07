using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace case_22331099
{
    public partial class Frm_emp : Form
    {
        public Frm_emp()
        {
            InitializeComponent();
        }

        private void lv_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Customer.SelectedItems.Count > 0)
            {//如果有选中项
                ListViewItem myitem = lv_Customer.SelectedItems[0]; //获取选中的第一行（一次只能选一行）
                emp_no = myitem.SubItems[0].Text; //将选中行第 1 列的值赋值全局变量，客户编号
                txt_FirstName.Text = myitem.SubItems[1].Text; //第 2 列，姓名
                txt_LastName.Text = myitem.SubItems[2].Text; //单位
                rbtn_Sex1.Checked = myitem.SubItems[3].Text == "男" ? true : false; //性别
                rbtn_Sex2.Checked = myitem.SubItems[3].Text == "女" ? true : false; //性别
                if (DateTime.TryParseExact(myitem.SubItems[4].Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime dateValue1))
                {
                    // 将 DateTime 对象赋值给 DateTimePicker 的 Value 属性
                    dateTimePicker_hire_date.Value = dateValue1;
                }
                if (DateTime.TryParseExact(myitem.SubItems[5].Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime dateValue2))
                {
                    // 将 DateTime 对象赋值给 DateTimePicker 的 Value 属性
                    dateTimePicker_birthday.Value = dateValue2;
                }

                txt_Address.Text = myitem.SubItems[6].Text; //电话
                txt_Telephone.Text = myitem.SubItems[7].Text; //地址
                lbl_Status.Text = "修改"; //当前状态
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //清空各控件
        protected void ClearTextBox()
        {
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            txt_Telephone.Text = "";
            txt_Address.Text = "";
            rbtn_Sex1.Checked = true;
            DateTime desiredDate = new DateTime(2000, 1, 1);
            dateTimePicker_hire_date.Value = desiredDate;
            dateTimePicker_birthday.Value = desiredDate;
            lbl_Status.Text = "添加";
            emp_no = "";
        }

        //加载客户信息
        protected void DataBind_Customer()
        {
            MySqlConnection conn = new MySqlConnection("server = localhost;database = DB_22331099; uid=root;pwd=123456;port = 3306");
            conn.Open();
            string str = "select * from emp_info";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_Customer.Items.Clear(); //先清空列表视图控件中现有行
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["emp_no"].ToString());// 创建一个ListViewItem 项，并为第 1 列赋值，客户编号
                myitem.SubItems.Add(dr["first_name"].ToString()); //第 2 列，姓名
                myitem.SubItems.Add(dr["last_name"].ToString()); //第 3 列，单位
                myitem.SubItems.Add(dr["gender"].ToString()); //第 4 列，性别
                myitem.SubItems.Add(dr["hire_date"].ToString()); //第 5 列，年龄
                myitem.SubItems.Add(dr["birthday"].ToString()); //第 6 列，电话
                myitem.SubItems.Add(dr["address"].ToString()); //第 7 列，地址
                myitem.SubItems.Add(dr["telephone"].ToString()); //第 7 列，地址
                lv_Customer.Items.Add(myitem); //将新建项添加到 ListView 控件中
            }

        }

        string emp_no = "";

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string firstname = txt_FirstName.Text.Trim(); //名
            string lastname = txt_LastName.Text.Trim(); //姓
            string sex = rbtn_Sex1.Checked == true ? "男" : "女"; //性别
            string hire_date = dateTimePicker_hire_date.Value.ToString("yyyy-MM-dd");
            string birthday = dateTimePicker_birthday.Value.ToString("yyyy-MM-dd");

            //if (hire_date == "2000-01-01")
            //{
            //    hire_date = null;
            //}
            //if (birthday == "2000-01-01")
            //{
            //    birthday = null;
            //}

            string telephone = txt_Telephone.Text.Trim(); //电话
            string address = txt_Address.Text.Trim(); //地址
            if (firstname == ""|| lastname == "") //姓名为空
            {
                lbl_Note.Text = "姓名不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_FirstName.Focus();
            }
            else if (lbl_Status.Text == "添加") //如果是“添加”状态
            {
                //SqlConnection conn = new SqlConnection("Data Source=localhost; database=DB_22331099; Integrated Security = SSPI");
                MySqlConnection conn = new MySqlConnection("server = localhost;database = DB_22331099; uid=root;pwd=123456;port = 3306");

                conn.Open();
                //string str = string.Format("insert into Customer_Info values(0,'{0}','{1}','{2}','{3}','{4}','{5}')",name,company,sex,age,telephone,address);
                string str = string.Format("insert into emp_Info values(DEFAULT,'{0}','{1}','{2}','{3}','{4}','{5}','{6}')", firstname,lastname, sex, hire_date, birthday, address,telephone);


                MySqlCommand cmd = new MySqlCommand(str, conn);

                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，员工信息添加成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox(); //调用函数，清空各控件
                    DataBind_Customer(); //重新加载客户信息

                }
                else
                {
                    lbl_Note.Text = "对不起，员工信息添加失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
            else//修改操作
            {
                MySqlConnection conn = new MySqlConnection("server = localhost;database = DB_22331099; uid=root;pwd=123456;port = 3306");
                conn.Open();
                string str = string.Format("update emp_Info set first_name='{0}',last_name='{1}',gender='{2}',hire_date='{3}',birthday='{4}',address='{5}',telephone='{6}' where emp_no={7}",firstname,lastname, sex, hire_date, birthday, address, telephone, emp_no);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，员工信息修改成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox(); //调用函数，清空各控件
                    DataBind_Customer(); //重新加载客户信息

                }
                else
                {
                    lbl_Note.Text = "对不起，员工信息修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }

            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox(); //调用函数，清空各控件
            lbl_Note.Text = "";
        }

        private void Frm_emp_Load(object sender, EventArgs e)
        {
            DataBind_Customer(); //加载客户信息
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (emp_no == "")//如果没有选中要删除的客户信息
            {
                MessageBox.Show("请先选择要删除的客户信息");
            }
            else
            {
                //弹出删除确认提示框
                DialogResult result = MessageBox.Show("确定要删除选中的员工信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)//如果确定删除
                {
                    MySqlConnection conn = new MySqlConnection("server = localhost;database = DB_22331099; uid=root;pwd=123456;port = 3306");
                    conn.Open();
                    string str = string.Format("delete from emp_info where emp_no ={0}", emp_no);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，员工信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox(); //调用函数，清空各控件
                        DataBind_Customer(); //重新加载客户信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，员工信息删除失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }


                }
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Main frm = new Frm_Main();
            frm.Show();
        }
    }
}
