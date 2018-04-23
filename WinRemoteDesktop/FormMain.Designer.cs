namespace WinRemoteDesktop
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddData = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAbout = new System.Windows.Forms.ToolStripButton();
            this.tsbFullScreen = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsItemLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.betterListView1 = new ComponentOwl.BetterListView.BetterListView();
            this.chServerIp = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
            this.chUserName = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
            this.chPassword = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
            this.chRemark = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsMenuConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuDel = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsMenuNotifyShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMenuNotifyExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betterListView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbConnect,
            this.toolStripSeparator1,
            this.tsbAddData,
            this.toolStripSeparator2,
            this.tsbEdit,
            this.tsbDel,
            this.toolStripSeparator3,
            this.tsbAbout,
            this.tsbFullScreen});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(464, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbConnect
            // 
            this.tsbConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbConnect.Enabled = false;
            this.tsbConnect.Image = ((System.Drawing.Image)(resources.GetObject("tsbConnect.Image")));
            this.tsbConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConnect.Name = "tsbConnect";
            this.tsbConnect.Size = new System.Drawing.Size(23, 22);
            this.tsbConnect.Text = "连接";
            this.tsbConnect.Click += new System.EventHandler(this.tsbConnect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAddData
            // 
            this.tsbAddData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddData.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddData.Image")));
            this.tsbAddData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddData.Name = "tsbAddData";
            this.tsbAddData.Size = new System.Drawing.Size(23, 22);
            this.tsbAddData.Text = "添加";
            this.tsbAddData.Click += new System.EventHandler(this.tsbAddData_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdit.Enabled = false;
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(23, 22);
            this.tsbEdit.Text = "编辑";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDel
            // 
            this.tsbDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDel.Enabled = false;
            this.tsbDel.Image = ((System.Drawing.Image)(resources.GetObject("tsbDel.Image")));
            this.tsbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDel.Name = "tsbDel";
            this.tsbDel.Size = new System.Drawing.Size(23, 22);
            this.tsbDel.Text = "删除";
            this.tsbDel.Click += new System.EventHandler(this.tsbDel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAbout
            // 
            this.tsbAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsbAbout.Image")));
            this.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbout.Name = "tsbAbout";
            this.tsbAbout.Size = new System.Drawing.Size(23, 22);
            this.tsbAbout.Text = "关于";
            this.tsbAbout.Click += new System.EventHandler(this.tsbAbout_Click);
            // 
            // tsbFullScreen
            // 
            this.tsbFullScreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbFullScreen.ForeColor = System.Drawing.Color.OliveDrab;
            this.tsbFullScreen.Image = ((System.Drawing.Image)(resources.GetObject("tsbFullScreen.Image")));
            this.tsbFullScreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFullScreen.Name = "tsbFullScreen";
            this.tsbFullScreen.Size = new System.Drawing.Size(60, 22);
            this.tsbFullScreen.Text = "全屏模式";
            this.tsbFullScreen.Click += new System.EventHandler(this.tsbFullScreen_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMsg,
            this.tsItemLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 269);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(464, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsMsg
            // 
            this.tsMsg.Name = "tsMsg";
            this.tsMsg.Size = new System.Drawing.Size(402, 17);
            this.tsMsg.Spring = true;
            this.tsMsg.Text = "开发者：502832965@qq.com";
            this.tsMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsItemLabel
            // 
            this.tsItemLabel.Name = "tsItemLabel";
            this.tsItemLabel.Size = new System.Drawing.Size(47, 17);
            this.tsItemLabel.Text = "共 0 项";
            // 
            // betterListView1
            // 
            this.betterListView1.Columns.Add(this.chServerIp);
            this.betterListView1.Columns.Add(this.chUserName);
            this.betterListView1.Columns.Add(this.chPassword);
            this.betterListView1.Columns.Add(this.chRemark);
            this.betterListView1.ContextMenuStrip = this.contextMenuStrip1;
            this.betterListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.betterListView1.ImageList = this.imageList1;
            this.betterListView1.Location = new System.Drawing.Point(0, 25);
            this.betterListView1.Name = "betterListView1";
            this.betterListView1.Size = new System.Drawing.Size(464, 244);
            this.betterListView1.TabIndex = 6;
            this.betterListView1.SelectedItemsChanged += new ComponentOwl.BetterListView.BetterListViewSelectedItemsChangedEventHandler(this.betterListView1_SelectedItemsChanged);
            this.betterListView1.DoubleClick += new System.EventHandler(this.betterListView1_DoubleClick);
            // 
            // chServerIp
            // 
            this.chServerIp.Name = "chServerIp";
            this.chServerIp.Text = "服务器地址";
            this.chServerIp.Width = 160;
            // 
            // chUserName
            // 
            this.chUserName.Name = "chUserName";
            this.chUserName.Text = "用户名";
            // 
            // chPassword
            // 
            this.chPassword.Name = "chPassword";
            this.chPassword.Text = "密码";
            this.chPassword.Width = 0;
            // 
            // chRemark
            // 
            this.chRemark.Name = "chRemark";
            this.chRemark.Text = "备注";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuConnect,
            this.toolStripMenuItem1,
            this.tsMenuEdit,
            this.tsMenuDel});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 76);
            // 
            // tsMenuConnect
            // 
            this.tsMenuConnect.Enabled = false;
            this.tsMenuConnect.Image = ((System.Drawing.Image)(resources.GetObject("tsMenuConnect.Image")));
            this.tsMenuConnect.Name = "tsMenuConnect";
            this.tsMenuConnect.Size = new System.Drawing.Size(100, 22);
            this.tsMenuConnect.Text = "连接";
            this.tsMenuConnect.Click += new System.EventHandler(this.tsMenuConnect_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(97, 6);
            // 
            // tsMenuEdit
            // 
            this.tsMenuEdit.Enabled = false;
            this.tsMenuEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsMenuEdit.Image")));
            this.tsMenuEdit.Name = "tsMenuEdit";
            this.tsMenuEdit.Size = new System.Drawing.Size(100, 22);
            this.tsMenuEdit.Text = "编辑";
            this.tsMenuEdit.Click += new System.EventHandler(this.tsMenuEdit_Click);
            // 
            // tsMenuDel
            // 
            this.tsMenuDel.Enabled = false;
            this.tsMenuDel.Image = ((System.Drawing.Image)(resources.GetObject("tsMenuDel.Image")));
            this.tsMenuDel.Name = "tsMenuDel";
            this.tsMenuDel.Size = new System.Drawing.Size(100, 22);
            this.tsMenuDel.Text = "删除";
            this.tsMenuDel.Click += new System.EventHandler(this.tsMenuDel_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "eye-shown.png");
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip2;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuNotifyShow,
            this.toolStripMenuItem2,
            this.tsMenuNotifyExit});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(101, 54);
            // 
            // tsMenuNotifyShow
            // 
            this.tsMenuNotifyShow.Image = ((System.Drawing.Image)(resources.GetObject("tsMenuNotifyShow.Image")));
            this.tsMenuNotifyShow.Name = "tsMenuNotifyShow";
            this.tsMenuNotifyShow.Size = new System.Drawing.Size(100, 22);
            this.tsMenuNotifyShow.Text = "显示";
            this.tsMenuNotifyShow.Click += new System.EventHandler(this.tsMenuNotifyShow_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(97, 6);
            // 
            // tsMenuNotifyExit
            // 
            this.tsMenuNotifyExit.Name = "tsMenuNotifyExit";
            this.tsMenuNotifyExit.Size = new System.Drawing.Size(100, 22);
            this.tsMenuNotifyExit.Text = "退出";
            this.tsMenuNotifyExit.Click += new System.EventHandler(this.tsMenuNotifyExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 291);
            this.Controls.Add(this.betterListView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "简易远程桌面工具";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betterListView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbConnect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsItemLabel;
        private ComponentOwl.BetterListView.BetterListViewColumnHeader chServerIp;
        private ComponentOwl.BetterListView.BetterListViewColumnHeader chUserName;
        private ComponentOwl.BetterListView.BetterListViewColumnHeader chPassword;
        private ComponentOwl.BetterListView.BetterListViewColumnHeader chRemark;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuConnect;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem tsMenuDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDel;
        private System.Windows.Forms.ToolStripButton tsbAddData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private ComponentOwl.BetterListView.BetterListView betterListView1;
        private System.Windows.Forms.ToolStripButton tsbAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbFullScreen;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsMenuNotifyShow;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsMenuNotifyExit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripStatusLabel tsMsg;
    }
}

