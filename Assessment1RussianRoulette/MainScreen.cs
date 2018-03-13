using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment1RussianRoulette
{
    public partial class MainScreen : UserControl
    {
        public int credits
        {
            get { return Convert.ToInt16(lblCredits.Text); }
            set { lblCredits.Text = value.ToString(); }
        }

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
    }
}
