using System;
using System.Windows.Forms;

namespace CarRental
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ������� ������� �����
            LoginForm loginForm = new LoginForm();

            // ��������� ���� ���������
            Application.Run(loginForm);

            // ����� ����� �����������, ���������� �����������
        }
    }
}