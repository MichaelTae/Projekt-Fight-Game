using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Fight_Game.Observer
{
    class SubscriberWeapon : IObserver
    {
        public void Update(Subject subject)
        {
            if ((subject as Subject).State == 1)
            {

                //Om person är subscriber uppdatera Combobox med vapen Artifactspear från builder, Vet ej hur koppla ihop dock. 

            }

        }



    }
}
