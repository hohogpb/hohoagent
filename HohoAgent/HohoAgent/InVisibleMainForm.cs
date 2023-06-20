using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HohoAgent
{
    public partial class InVisibleMainForm : Form
    {
        public InVisibleMainForm()
        {
            InitializeComponent();
        }

        private static InVisibleMainForm instance = new InVisibleMainForm();

        public static InVisibleMainForm Instance
        {
            get { return instance; }
        }

        MainForm main_form = new MainForm();

        private void OnLoad(object sender, EventArgs e)
        {
            this.Hide();
            this.ShowInTaskbar = false;

            SetupNotifyIcon();

        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            HideNotifyIcon();
        }

        private void SetupNotifyIcon()
        {
            this.notifyIcon1.Text = "HohoAgent";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = Properties.Resources.agent2;
            this.notifyIcon1.Visible = true;
        }

        public void HideNotifyIcon()
        {
            this.notifyIcon1.Visible = false;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            main_form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msgbox_caption = "HohoAgent";
            string msgbox_text = "Are you sure to quit ?";
            MessageBoxButtons msgbox_btns = MessageBoxButtons.OKCancel;
            MessageBoxIcon msgbox_icon = MessageBoxIcon.Question;

            if (MessageBox.Show(msgbox_text, msgbox_caption, msgbox_btns, msgbox_icon) == DialogResult.OK) {
                this.Close();
            }
        }  

    }
}
