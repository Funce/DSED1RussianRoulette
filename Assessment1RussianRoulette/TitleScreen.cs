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
    public partial class TitleScreen : UserControl
    {
        private Form1 ParentForm1;

        public int credits
        {
            get { return Convert.ToInt16(lblCredits.Text); }
            set { lblCredits.Text = value.ToString(); }
        }

        public TitleScreen()
        {
            InitializeComponent();
        }

        public void SetParent(Form1 Parent)
        {
            ParentForm1 = Parent;
        }

        //Event Handling will contain a bunch of variables.
        private void btnPlay_Click(object sender, EventArgs e)
        {
            ParentForm1.MainHandler.Begin();
        }
    }
}
