using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechTimer
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
            bool result;
            var mutex = new System.Threading.Mutex(true, "SpeechTimer-123", out result);
            if (!result)
            {
                MessageBox.Show("程序已经运行");
                return;
            }
            Application.Run(new SpeechTimer());
            GC.KeepAlive(mutex);
        }
    }
}
