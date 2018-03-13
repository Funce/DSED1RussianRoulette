using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment1RussianRoulette
{
    public partial class Form1 : Form
    {
        public FormHandler MainHandler;
        public WinLossTracker WinsAndLosses;
        public Form1()
        {
            //Allows access to the forms elements.
            InitializeComponent();
            WinsAndLosses = new WinLossTracker(this);
            MainHandler = new FormHandler(this);
            titleScreen1.SetParent(this);
            mainScreen1.SetParent(this);
        }
    }
}
