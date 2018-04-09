using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Assessment1RussianRoulette
{
    public partial class MainScreen : UserControl
    {
        /// <summary>
        /// MainScreen handles all input and output via the FormHandler of the parentform.
        /// Make sure to also include a TitleScreen
        /// </summary>
        public int wins
        {
            get { return Convert.ToInt16(lblWins.Text); }
            set { lblWins.Text = value.ToString(); }
        }
        public int losses
        {
            get { return Convert.ToInt16(lblLosses.Text); }
            set { lblLosses.Text = value.ToString(); }
        }

        private Form1 ParentForm1;
        public MainScreen()
        {
            InitializeComponent();
        }

        public void SetParent(Form1 Parent)
        {
            ParentForm1 = Parent;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ParentForm1.MainHandler.Back();
        }

        private void btnPull_Click(object sender, EventArgs e)
        {
            ParentForm1.MainHandler.Pull();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            ParentForm1.MainHandler.Pass();
        }

        public void lbxLog_add(string message)
        {
            lbxLog.Items.Add(message);
            lbxLog.SelectedIndex = lbxLog.Items.Count - 1;
            lbxLog.ClearSelected();
        }

        public void readyPull()
        {
            btnPull.Enabled = true;
        }
        public void readyPass()
        {
            btnPass.Enabled = true;
        }
        public void unreadyPass()
        {
            btnPass.Enabled = false;
        }
        public void unreadyPull()
        {
            btnPull.Enabled = false;
        }

        public void resetOutput()
        {
            lbxLog.Items.Clear();
        }
    }
}
