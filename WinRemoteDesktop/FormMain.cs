using AxMSTSCLib;
using ComponentOwl.BetterListView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WinRemoteDesktop
{
    public partial class FormMain : Form
    {
        private AxMsRdpClient7NotSafeForScripting axMsRdpc = null;
        private bool isFullScreen = false;
        private List<string> axMsRdpcArray = null;

        public FormMain()
        {
            InitializeComponent();
            axMsRdpcArray = new List<string>();
        }

        /// <summary>
        /// 创建远程桌面连接
        /// </summary>
        /// <param name="args">参数数组 new string[] { ServerIp, UserName, Password }</param>
        private void CreateAxMsRdpClient(string[] args)
        {
            string[] ServerIps = args[0].Split(':');

            Form axMsRdpcForm = new Form();
            axMsRdpcForm.ShowIcon = false;
            //axMsRdpcForm.StartPosition = FormStartPosition.Manual;
            axMsRdpcForm.Name = string.Format("Form_{0}", ServerIps[0].Replace(".", ""));
            axMsRdpcForm.Text = string.Format("{0} ({1})", args[3], ServerIps[0]);
            axMsRdpcForm.Size = new Size(1024, 768);
            axMsRdpcForm.FormClosed += new FormClosedEventHandler(this.axMsRdpcForm_Closed);

            Rectangle ScreenArea = Screen.PrimaryScreen.Bounds;
            // 给axMsRdpc取个名字
            string _axMsRdpcName = string.Format("axMsRdpc_{0}", ServerIps[0].Replace(".", ""));
            if (axMsRdpcArray.Contains(_axMsRdpcName))
            {
                Global.WinMessage("此远程已经连接，请勿重复连接！"); return;
            }
            else
            {
                axMsRdpc = new AxMsRdpClient7NotSafeForScripting();
            }
            // 添加到当前缓存
            axMsRdpcArray.Add(_axMsRdpcName);

            ((System.ComponentModel.ISupportInitialize)(axMsRdpc)).BeginInit();
            axMsRdpc.Dock = DockStyle.Fill;
            axMsRdpc.Enabled = true;

            // 绑定连接与释放事件
            axMsRdpc.OnConnecting += new EventHandler(this.axMsRdpc_OnConnecting);
            axMsRdpc.OnDisconnected += new IMsTscAxEvents_OnDisconnectedEventHandler(this.axMsRdpc_OnDisconnected);

            axMsRdpcForm.Controls.Add(axMsRdpc);
            axMsRdpcForm.Show();
            ((System.ComponentModel.ISupportInitialize)(axMsRdpc)).EndInit();

            // RDP名字
            axMsRdpc.Name = _axMsRdpcName;
            // 服务器地址
            axMsRdpc.Server = ServerIps[0];
            // 远程登录账号
            axMsRdpc.UserName = args[1];
            // 远程端口号
            axMsRdpc.AdvancedSettings7.RDPPort = ServerIps.Length == 1 ? 3389 : Convert.ToInt32(ServerIps[1]);
            // 自动控制屏幕显示尺寸
            //axMsRdpc.AdvancedSettings9.SmartSizing = true;
            // 启用CredSSP身份验证（有些服务器连接没有反应，需要开启这个）
            axMsRdpc.AdvancedSettings7.EnableCredSspSupport = true;
            // 远程登录密码
            axMsRdpc.AdvancedSettings7.ClearTextPassword = args[2];
            // 颜色位数 8,16,24,32
            axMsRdpc.ColorDepth = 32;
            // 开启全屏 true|flase
            axMsRdpc.FullScreen = this.isFullScreen;
            // 设置远程桌面宽度为显示器宽度
            axMsRdpc.DesktopWidth = ScreenArea.Width;
            // 设置远程桌面宽度为显示器高度
            axMsRdpc.DesktopHeight = ScreenArea.Height;
            // 远程连接
            axMsRdpc.Connect();
        }

        private void AxMsRdpc_OnConnected(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 启动选中列表行的数据进行远程服务器连接
        /// </summary>
        private void SelectListViewRunRdpc()
        {
            if (this.betterListView1.SelectedItems.Count == 0) return;

            for (int i = 0; i < this.betterListView1.SelectedItems.Count; i++)
            {
                CreateAxMsRdpClient(new string[] {
                    this.betterListView1.SelectedItems[i].SubItems[0].Text,
                    this.betterListView1.SelectedItems[i].SubItems[1].Text,
                    this.betterListView1.SelectedItems[i].SubItems[2].Text,
                    this.betterListView1.SelectedItems[i].SubItems[3].Text
                });
            }            
        }

        /// <summary>
        /// 编辑数据
        /// </summary>
        private void EditListViewDataSource()
        {
            if (this.betterListView1.SelectedItems.Count == 0) return;

            string serverIp = this.betterListView1.SelectedItems[0].SubItems[0].Text;
            FormDesktop frm = new FormDesktop();
            frm._Action = "EDIT";
            frm._ServerIp = serverIp;
            frm.ShowDialog();
        }

        /// <summary>
        /// 根据服务器IP删除数据
        /// </summary>
        private void DeleteListViewDataSource()
        {
            if (this.betterListView1.SelectedItems.Count == 0) return;

            DialogResult result = MessageBox.Show("已选中 1 项数据，是否确认删除？", "删除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string serverIp = this.betterListView1.SelectedItems[0].SubItems[0].Text;
                string where = string.Format("c0='{0}'", serverIp);
                new TXTClass().txtDelete(Global.dbFile, '|', where);
                // 重新绑定数据源
                BindsListViewDataSource();
            }
        }

        /// <summary>
        /// 绑定数据源
        /// </summary>
        public void BindsListViewDataSource()
        {
            this.betterListView1.Items.Clear();
            DataTable dt = new TXTClass().txtRead(Global.dbFile, '|');
            foreach (DataRow row in dt.Rows)
            {
                BetterListViewItem item = new BetterListViewItem(new string[] {
                    row[0].ToString(),
                    row[1].ToString(),
                    row[2].ToString(),
                    row[3].ToString()
                });
                item.ImageIndex = 0;

                this.betterListView1.Items.Add(item);
            }
            this.tsItemLabel.Text = string.Format("共 {0} 项", dt.Rows.Count);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            BindsListViewDataSource();
        }

        private void tsbConnect_Click(object sender, EventArgs e)
        {
            SelectListViewRunRdpc();
        }

        private void betterListView1_DoubleClick(object sender, EventArgs e)
        {
            SelectListViewRunRdpc();
        }

        private void tsMenuConnect_Click(object sender, EventArgs e)
        {
            SelectListViewRunRdpc();
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            BindsListViewDataSource();
        }

        private void betterListView1_SelectedItemsChanged(object sender, BetterListViewSelectedItemsChangedEventArgs eventArgs)
        {
            if (this.betterListView1.SelectedItems.Count == 0)
            {
                this.tsbConnect.Enabled = false;
                this.tsbEdit.Enabled = false;
                this.tsbDel.Enabled = false;
                this.tsMenuConnect.Enabled = false;
                this.tsMenuEdit.Enabled = false;
                this.tsMenuDel.Enabled = false;
            }
            else
            {
                this.tsbConnect.Enabled = true;
                this.tsbEdit.Enabled = true;
                this.tsbDel.Enabled = true;
                this.tsMenuConnect.Enabled = true;
                this.tsMenuEdit.Enabled = true;
                this.tsMenuDel.Enabled = true;
            }
        }

        private void tsbAddData_Click(object sender, EventArgs e)
        {
            FormDesktop frm = new FormDesktop();
            frm.ShowDialog();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            EditListViewDataSource();
        }

        private void tsMenuEdit_Click(object sender, EventArgs e)
        {
            EditListViewDataSource();
        }

        private void tsbDel_Click(object sender, EventArgs e)
        {
            DeleteListViewDataSource();
        }

        private void tsMenuDel_Click(object sender, EventArgs e)
        {
            DeleteListViewDataSource();
        }

        private void tsbAbout_Click(object sender, EventArgs e)
        {
            FormAbout frm = new FormAbout();
            frm.ShowDialog();
        }

        private void tsbFullScreen_Click(object sender, EventArgs e)
        {
            this.isFullScreen = !this.isFullScreen;
            if (this.isFullScreen)
            {
                this.tsbFullScreen.Text = "取消全屏";
                this.tsbFullScreen.ForeColor = Color.Gray;
            }
            else
            {
                this.tsbFullScreen.Text = "全屏模式";
                this.tsbFullScreen.ForeColor = Color.OliveDrab;
            }
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            // 隐藏任务栏图标
            this.ShowInTaskbar = false;
        }

        private void tsMenuNotifyShow_Click(object sender, EventArgs e)
        {
            // 还原窗口
            WindowState = FormWindowState.Normal;
            // 显示任务栏图标
            this.ShowInTaskbar = true;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.tsMenuNotifyShow_Click(sender, e);
        }

        private void tsMenuNotifyExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        private void axMsRdpc_OnConnecting(object sender, EventArgs e)
        {
            axMsRdpc.ConnectingText = axMsRdpc.GetStatusText(Convert.ToUInt32(axMsRdpc.Connected));
        }

        private void axMsRdpc_OnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
        {
            axMsRdpc.DisconnectedText = "连接已断开！";
        }

        private void axMsRdpcForm_Closed(object sender, FormClosedEventArgs e)
        {
            Form frm = (Form)sender;
            //MessageBox.Show(frm.Controls[0].GetType().ToString());
            foreach (Control ctrl in frm.Controls)
            {
                //MessageBox.Show((ctrl as AxMSTSCLib.AxMsRdpClient7NotSafeForScripting).Connected.ToString());
                if (ctrl.GetType().ToString() == "AxMSTSCLib.AxMsRdpClient7NotSafeForScripting")
                {
                    // 释放缓存
                    if (axMsRdpcArray.Contains(ctrl.Name)) axMsRdpcArray.Remove(ctrl.Name);
                    // 断开连接
                    if ((ctrl as AxMsRdpClient7NotSafeForScripting).Connected != 0)
                    {
                        (ctrl as AxMsRdpClient7NotSafeForScripting).Disconnect();
                    }
                }
            }
        }
    }
}
