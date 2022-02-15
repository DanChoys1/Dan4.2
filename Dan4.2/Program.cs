using System;
using System.Windows.Forms;

namespace Program
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        ///  �������� ���� (NLog)
        ///  �������� ����������� (����� ����� ��������)
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
