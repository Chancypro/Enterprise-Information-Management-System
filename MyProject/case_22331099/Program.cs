using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace case_22331099
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new Frm_Login());
            //Application.Run(new Frm_SignUp());
            //Application.Run(new Frm_emp());
            //Application.Run(new Frm_dept());
            //Application.Run(new Frm_ed());
            //Application.Run(new Frm_query());
        }
    }
}
