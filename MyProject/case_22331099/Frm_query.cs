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
    public partial class Frm_query : Form
    {
        public Frm_query()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            string firstname = txt_FirstName.Text.Trim(); //名
            string lastname = txt_LastName.Text.Trim(); //姓
            string sex = "";
            if (rbtn_Sex1.Checked == true)
            {
                sex = "男";
            }
            else if(rbtn_Sex2.Checked==true)
            {
                sex = "女";
            }
            string telephone = txt_Telephone.Text.Trim(); //电话
            string address = txt_Address.Text.Trim(); //地址

            MySqlConnection conn = new MySqlConnection("server = localhost;database = DB_22331099; uid=root;pwd=123456;port = 3306");
            conn.Open();
            string str = string.Format("select * from emp_info where first_name like '%{0}%' and last_name like '%{1}%' and gender like '%{2}%' and address like '%{3}%' and telephone like '%{4}%'", firstname, lastname, sex, address, telephone);
            //string str = string.Format("select * from emp_info where first_name like '%%' and last_name like '%%'");

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

        private void Frm_query_Load(object sender, EventArgs e)
        {
            DataBind_Customer();
        }

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
        protected void ClearTextBox()
        {
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            txt_Telephone.Text = "";
            txt_Address.Text = "";
            rbtn_Sex3.Checked = true;
            DateTime desiredDate = new DateTime(2000, 1, 1);
        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Main frm = new Frm_Main();
            frm.Show();
        }
    }
}
