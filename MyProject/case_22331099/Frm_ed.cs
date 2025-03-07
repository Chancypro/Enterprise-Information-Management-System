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
    public partial class Frm_ed : Form
    {
        public Frm_ed()
        {
            InitializeComponent();
        }

        private void lv_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Customer.SelectedItems.Count > 0)
            {//如果有选中项
                ListViewItem myitem = lv_Customer.SelectedItems[0]; //获取选中的第一行（一次只能选一行）
                ed_id = myitem.SubItems[0].Text; //将选中行第 1 列的值赋值全局变量，客户编号

                nudown_emp_no.Value = decimal.Parse(myitem.SubItems[1].Text);
                nudown_dept_no.Value = decimal.Parse(myitem.SubItems[2].Text);
                if (DateTime.TryParseExact(myitem.SubItems[3].Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime dateValue1))
                {
                    // 将 DateTime 对象赋值给 DateTimePicker 的 Value 属性
                    dateTimePicker_Ed_entrydate.Value = dateValue1;
                }
                if (DateTime.TryParseExact(myitem.SubItems[4].Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime dateValue2))
                {
                    // 将 DateTime 对象赋值给 DateTimePicker 的 Value 属性
                    dateTimePicker_Ed_leavedate.Value = dateValue2;
                }
                nudown_Ed_Status.Value = decimal.Parse(myitem.SubItems[5].Text);
                lbl_Status.Text = "修改"; //当前状态
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string emp_no = nudown_emp_no.Value.ToString();
            string dept_no = nudown_dept_no.Value.ToString();
            string Ed_Status = nudown_Ed_Status.Value.ToString();
            string Ed_entrydate = dateTimePicker_Ed_entrydate.Value.ToString("yyyy-MM-dd");
            string Ed_leavedate = dateTimePicker_Ed_leavedate.Value.ToString("yyyy-MM-dd");

            if (Ed_leavedate == "2000-01-01")
            {
                Ed_leavedate = null;
            }
            //if (birthday == "2000-01-01")
            //{
            //    birthday = null;
            //}

            if (emp_no == "0" || dept_no == "0") 
            {
                lbl_Note.Text = "请选择要添加的工号和部门编号！";
                lbl_Note.ForeColor = Color.Red;
                nudown_emp_no.Focus();
            }
            else if (lbl_Status.Text == "添加") //如果是“添加”状态
            {
                //SqlConnection conn = new SqlConnection("Data Source=localhost; database=DB_22331099; Integrated Security = SSPI");
                MySqlConnection conn = new MySqlConnection("server = localhost;database = DB_22331099; uid=root;pwd=123456;port = 3306");

                conn.Open();
                //string str = string.Format("insert into Customer_Info values(0,'{0}','{1}','{2}','{3}','{4}','{5}')",name,company,sex,age,telephone,address);
                string str = string.Format("insert into ed_info values(DEFAULT,'{0}','{1}','{2}','{3}','{4}')", emp_no, dept_no, Ed_entrydate,Ed_leavedate,Ed_Status);


                MySqlCommand cmd = new MySqlCommand(str, conn);

                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，隶属关系信息添加成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox(); //调用函数，清空各控件
                    DataBind_Customer(); //重新加载客户信息

                }
                else
                {
                    lbl_Note.Text = "对不起，隶属关系信息添加失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
            else//修改操作
            {
                MySqlConnection conn = new MySqlConnection("server = localhost;database = DB_22331099; uid=root;pwd=123456;port = 3306");
                conn.Open();
                string str = string.Format("update ed_info set emp_no='{0}',dept_no='{1}',Ed_entrydate='{2}',Ed_leavedate='{3}',Ed_Status='{4}' where ed_id={5}", emp_no, dept_no, Ed_entrydate, Ed_leavedate, Ed_Status, ed_id);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，隶属关系信息修改成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox(); //调用函数，清空各控件
                    DataBind_Customer(); //重新加载客户信息

                }
                else
                {
                    lbl_Note.Text = "对不起，隶属关系信息修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }

            }
        }

        string ed_id = "";

        protected void ClearTextBox()
        {

            lbl_Status.Text = "添加";
            ed_id = "";

            nudown_emp_no.Value = 0;
            nudown_dept_no.Value = 0;
            nudown_Ed_Status.Value = 1;
            DateTime desiredDate = new DateTime(2000, 1, 1);
            dateTimePicker_Ed_entrydate.Value = desiredDate;
            dateTimePicker_Ed_leavedate.Value = desiredDate;
        }

        protected void DataBind_Customer()
        {
            MySqlConnection conn = new MySqlConnection("server = localhost;database = DB_22331099; uid=root;pwd=123456;port = 3306");
            conn.Open();
            string str = "select * from ed_info";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_Customer.Items.Clear(); //先清空列表视图控件中现有行
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["ed_id"].ToString());// 创建一个ListViewItem 项，并为第 1 列赋值，客户编号
                myitem.SubItems.Add(dr["emp_no"].ToString()); //第 2 列，姓名
                myitem.SubItems.Add(dr["dept_no"].ToString()); //第 3 列，单位
                myitem.SubItems.Add(dr["Ed_entrydate"].ToString()); //第 4 列，性别
                myitem.SubItems.Add(dr["Ed_leavedate"].ToString()); //第 5 列，年龄
                myitem.SubItems.Add(dr["Ed_Status"].ToString()); //第 6 列，电话
                lv_Customer.Items.Add(myitem); //将新建项添加到 ListView 控件中
            }

        }

        private void Frm_ed_Load(object sender, EventArgs e)
        {
            DataBind_Customer();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (ed_id == "")//如果没有选中要删除的客户信息
            {
                MessageBox.Show("请先选择要删除的信息");
            }
            else
            {
                //弹出删除确认提示框
                DialogResult result = MessageBox.Show("确定要删除选中的隶属关系信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)//如果确定删除
                {
                    MySqlConnection conn = new MySqlConnection("server = localhost;database = DB_22331099; uid=root;pwd=123456;port = 3306");
                    conn.Open();
                    string str = string.Format("delete from ed_info where  ed_id={0}", ed_id);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，隶属关系信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox(); //调用函数，清空各控件
                        DataBind_Customer(); //重新加载客户信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，隶属关系信息删除失败！";
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
