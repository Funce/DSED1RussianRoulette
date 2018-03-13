using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Assessment1RussianRoulette
{
    public class FormHandler
    {
        private Form1 ParentForm1;

        public int credits
        {
            get { return ParentForm1.titleScreen1.credits; }
            set
            {
                ParentForm1.titleScreen1.credits = value;
                ParentForm1.mainScreen1.credits = value;
            }
        }

        public FormHandler(Form1 Parent)
        {
            ParentForm1 = Parent;
        }
        public void Begin()
        {
            ParentForm1.titleScreen1.Visible = false;
            ParentForm1.mainScreen1.Visible = true;
        }

        public void Back()
        {
            ParentForm1.titleScreen1.Visible = true;
            ParentForm1.mainScreen1.Visible = false;
        }

        public void reset_credits()
        {
            credits = 200;
        }
    }
}
