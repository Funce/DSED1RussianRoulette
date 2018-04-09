using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Assessment1RussianRoulette
{
    public class FormHandler
    {
        protected Form1 ParentForm1;
        protected int Counter;
        protected bool[] Death;

        public FormHandler(Form1 parent)
        {
            ParentForm1 = parent;
        }
        public void Begin(int chambers, int bullets)
        {
            ParentForm1.titleScreen1.Visible = false;
            ParentForm1.mainScreen1.Visible = true;
            Death = LoadNewGame(chambers, bullets);
            Output("Loading a " + chambers + "-shot revolver with " + bullets + " shot(s)");
            Counter = 0;
            //Blip a ready sound.
            Output("You have the gun");
            Output("You may Pull the trigger");
            Output("The Gun has been pulled " + (Counter) + " times");
            ReadyPull();
        }

        public void Back()
        {
            ParentForm1.titleScreen1.Visible = true;
            ParentForm1.mainScreen1.Visible = false;
        }

        protected void Win()
        {
            ParentForm1.WinsAndLosses.win();
        }

        protected void Lose()
        {
            ParentForm1.WinsAndLosses.lose();
        }

        public void Pull()
        {
            UnreadyPull();
            UnreadyPass();
            Output("You pulled the Trigger!");
            if (Death[Counter])
            {
                //Play Bang sound
                //wait a bit
                //blip sadly
                Output("The revolver went off!");
                Output("You died...");
                Lose();
                DividePlayerBet();
            }
            else
            {
                //Play click sound
                //wait
                //blip happily
                Output("You survived!");
                Counter++;
                Output("You have the gun");
                Output("You may Pull the trigger, or Pass the gun to your opponent");
                Output("The Gun has been pulled " + (Counter) + " times");
                ReadyPull();
                ReadyPass();
            }
        }

        public void Pass()
        {
            UnreadyPass();
            UnreadyPull();
            //Play a swish sound
            Output("You passed the gun over");
            //Ready sound
            Output("Your opponent has the gun");
            Output("Your opponent pulled the trigger!");
            if (Death[Counter])
            {
                //Play Bang sound
                //wait a bit
                //blip sadly
                Output("The revolver went off!");
                Output("You won!");
                Win();
            }
            else
            {
                //Play click sound
                //wait
                //blip happily
                Output("Your opponent survived!");
                Counter++;
                //wait
                // ready sound
                Output("Your opponent has the gun");
                //Swish sound
                Output("Your opponent passed the gun over");
                ReadyPull();
                //Ready sound
                Output("You have the gun");
                Output("You may Pull the trigger");
                Output("The Gun has been pulled " + (Counter) + " times");
            }
        }

        private bool[] LoadNewGame(int chambers, int bullets)
        {
            Random rnd = new Random();
            bool[] deathNumbers = new bool[chambers - 1];
            ResetOutput();
            int deathCounter = 0;
            while (deathCounter != bullets)
            {
                int singularDeath = rnd.Next(0, chambers - 1);
                if (!deathNumbers[singularDeath])
                {
                    deathNumbers[singularDeath] = true;
                    deathCounter++;
                }
            }
            return deathNumbers;
        }

        protected void DividePlayerBet()
        {

        }

        protected void ReadyPull()
        {
            ParentForm1.mainScreen1.readyPull();
        }

        protected void ReadyPass()
        {
            ParentForm1.mainScreen1.readyPass();
        }
        protected void UnreadyPull()
        {
            ParentForm1.mainScreen1.unreadyPull();
        }

        protected void UnreadyPass()
        {
            ParentForm1.mainScreen1.unreadyPass();
        }

        protected void ResetOutput()
        {
            ParentForm1.mainScreen1.resetOutput();
        }
        protected void Output(string message)
        {
            ParentForm1.mainScreen1.lbxLog_add(message);
        }
    }
}
