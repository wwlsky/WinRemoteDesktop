using System;
using System.Data;
using System.Windows.Forms;

namespace WinRemoteDesktop
{
    public partial class FormDesktop : Form
    {
        public string _Action;
        public string _ServerIp;

        public FormDesktop()
        {
            InitializeComponent();
        }

        #region 主窗体
        // 主窗体-加载
        private void FormRemote_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_Action) || string.IsNullOrWhiteSpace(_ServerIp)) return;

            string where = string.Format("c0='{0}'", _ServerIp);
            DataTable dt = new TXTClass().txtRead(Global.dbFile, '|', where);
            if (dt.Rows.Count > 0)
            {
                this.txtServerIp.Text = dt.Rows[0][0].ToString();
                this.txtUserName.Text = dt.Rows[0][1].ToString();
                this.txtPassword.Text = dt.Rows[0][2].ToString();
                this.txtRemark.Text = dt.Rows[0][3].ToString();
            }
        }
        #endregion

        #region 添加/编辑 数据
        // 保存数据
        private void btnSave_Click(object sender, EventArgs e)
        {
            string ServerIp = this.txtServerIp.Text.Trim();
            string UserName = this.txtUserName.Text.Trim();
            string Password = this.txtPassword.Text.Trim();
            string Remark = this.txtRemark.Text.Trim();

            if (string.IsNullOrWhiteSpace(ServerIp))
            {
                Global.WinMessage("请输入服务器IP地址!");
                return;
            }
            if (!Global.IsServerAddress(ServerIp))
            {
                Global.WinMessage("服务器IP地址格式不合法!");
                return;
            }
            if (string.IsNullOrWhiteSpace(UserName))
            {
                Global.WinMessage("请输入远程账号!");
                return;
            }

            string data = string.Format("{0}|{1}|{2}|{3}", ServerIp, UserName, Password, Remark);

            if (_Action == "EDIT")
            {
                string where = string.Format("c0='{0}'", _ServerIp);
                new TXTClass().txtModify(Global.dbFile, '|', data, where);
            }
            else
            {
                new TXTClass().txtWrite(Global.dbFile, data);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        // 取消 添加/编辑
        private void txtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
