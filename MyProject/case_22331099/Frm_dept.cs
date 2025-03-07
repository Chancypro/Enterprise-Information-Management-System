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
    public partial class Frm_dept : Form
    {
        public Frm_dept()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string dept_name = txt_dept_name.Text.Trim(); //姓名
            string dept_peoplecount = nudown_dept_peoplecount.Value.ToString(); //年龄
            if (dept_name == "") //姓名为空
            {
                lbl_Note.Text = "部门名称不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_dept_name.Focus();
            }
            else if (lbl_Status.Text == "添加") //如果是“添加”状态
            {
                //SqlConnection conn = new SqlConnection("Data Source=localhost; database=DB_22331099; Integrated Security = SSPI");
                MySqlConnection conn = new MySqlConnection("server = localhost;database = DB_22331099; uid=root;pwd=123456;port = 3306");

                conn.Open();
                //string str = string.Format("insert into Customer_Info values(0,'{0}','{1}','{2}','{3}','{4}','{5}')",name,company,sex,age,telephone,address);
                string str = string.Format("insert into dept_info values(DEFAULT,'{0}','{1}')", dept_name, dept_peoplecount);


                MySqlCommand cmd = new MySqlCommand(str, conn);

                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，部门信息添加成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox(); //调用函数，清空各控件
                    DataBind_Customer(); //重新加载客户信息

                }
                else
                {
                    lbl_Note.Text = "对不起，部门信息添加失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
            else//修改操作
            {
                MySqlConnection conn = new MySqlConnection("server = localhost;database = DB_22331099; uid=root;pwd=123456;port = 3306");
                conn.Open();
                string str = string.Format("update dept_info set dept_name='{0}',dept_peoplecount='{1}' where dept_no={2}", dept_name, dept_peoplecount,dept_no);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，部门信息修改成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox(); //调用函数，清空各控件
                    DataBind_Customer(); //重新加载客户信息

                }
                else
                {
                    lbl_Note.Text = "对不起，部门信息修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }

            }
        }

        string dept_no = "";

        protected void ClearTextBox()
        {
            txt_dept_name.Text = "";
            nudown_dept_peoplecount.Value = 0;
            lbl_Status.Text = "添加";
            dept_no = "";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox(); //调用函数，清空各控件
            lbl_Note.Text = "";
        }

        protected void DataBind_Customer()
        {
            MySqlConnection conn = new MySqlConnection("server = localhost;database = DB_22331099; uid=root;pwd=123456;port = 3306");
            conn.Open();
            string str = "select * from dept_info";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_Customer.Items.Clear(); //先清空列表视图控件中现有行
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["dept_no"].ToString());// 创建一个ListViewItem 项，并为第 1 列赋值，客户编号
                myitem.SubItems.Add(dr["dept_name"].ToString()); //第 2 列，姓名
                myitem.SubItems.Add(dr["dept_peoplecount"].ToString()); //第 3 列，单位
                lv_Customer.Items.Add(myitem); //将新建项添加到 ListView 控件中
            }

        }

        private void Frm_dept_Load(object sender, EventArgs e)
        {
            DataBind_Customer();
        }

        private void lv_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Customer.SelectedItems.Count > 0)
            {//如果有选中项
                ListViewItem myitem = lv_Customer.SelectedItems[0]; //获取选中的第一行（一次只能选一行）
                dept_no = myitem.SubItems[0].Text; //将选中行第 1 列的值赋值全局变量，客户编号
                txt_dept_name.Text = myitem.SubItems[1].Text; //第 2 列，姓名
                nudown_dept_peoplecount.Value = decimal.Parse(myitem.SubItems[2].Text); //年龄
                lbl_Status.Text = "修改"; //当前状态
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (dept_no == "")//如果没有选中要删除的客户信息
            {
                MessageBox.Show("请先选择要删除的部门信息");
            }
            else
            {
                //弹出删除确认提示框
                DialogResult result = MessageBox.Show("确定要删除选中的部门信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)//如果确定删除
                {
                    MySqlConnection conn = new MySqlConnection("server = localhost;database = DB_22331099; uid=root;pwd=123456;port = 3306");
                    conn.Open();
                    string str = string.Format("delete from dept_info where dept_no ={0}", dept_no);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，部门信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox(); //调用函数，清空各控件
                        DataBind_Customer(); //重新加载客户信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，部门信息删除失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }


                }
            }
        }

        private void lv_Customer_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lv_Customer.SelectedItems.Count > 0)
            {//如果有选中项
                ListViewItem myitem = lv_Customer.SelectedItems[0]; //获取选中的第一行（一次只能选一行）
                dept_no = myitem.SubItems[0].Text; //将选中行第 1 列的值赋值全局变量，客户编号
                txt_dept_name.Text = myitem.SubItems[1].Text; //第 2 列，姓名
                nudown_dept_peoplecount.Value = decimal.Parse(myitem.SubItems[2].Text); //年龄
                lbl_Status.Text = "修改"; //当前状态
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
