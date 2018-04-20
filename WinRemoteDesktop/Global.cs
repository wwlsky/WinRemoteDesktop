using System.Windows.Forms;

namespace WinRemoteDesktop
{
    class Global
    {
        public static string dbFile = @"WinRemoteDesktop.db";

        public static void WinMessage(string msg)
        {
            MessageBox.Show(msg, "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
