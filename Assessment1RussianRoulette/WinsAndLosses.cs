using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1RussianRoulette
{
    public class WinLossTracker
    {
        protected Form1 ParentForm1;

        protected int wins
        {
            get { return ParentForm1.mainScreen1.wins; }
            set { ParentForm1.mainScreen1.wins = value; }
        }

        protected int losses
        {
            get { return ParentForm1.mainScreen1.losses; }
            set { ParentForm1.mainScreen1.losses = value; }
        }
        public WinLossTracker(Form1 Parent)
        {
            ParentForm1 = Parent;
        }

        public void win()
        {
            wins++;
        }

        public void lose()
        {
            losses++;
        }
    }
}