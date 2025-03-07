using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace case_22331099
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_emp frm = new Frm_emp();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_dept frm = new Frm_dept();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ed frm = new Frm_ed();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_query frm = new Frm_query();
            frm.Show();
        }
    }
}
