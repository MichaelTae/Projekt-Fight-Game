using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Fight_Game.Observer
{
    class Subscriber : IObserver
    {
        public void Update(Subject subject)
        {
            if ((subject as Subject).State == 1)
            {
               MessageBox.Show("You are a subscriber");
            }

            else
            {
                MessageBox.Show("You are not a subscriber");

            }

            //Change lbl_AccountInfo.text = Subscriber.

        }
    }
}
