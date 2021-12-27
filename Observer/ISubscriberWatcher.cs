using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Fight_Game.Observer
{
    interface ISubscriberWatcher<T>
    {
        public void Alert(T value);
    }
}
