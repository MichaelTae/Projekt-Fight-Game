using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Fight_Game.Observer
{
    public class SubscriberAlarm
    {
        List<ISubscriberWatcher<SubscriberAlarm>> watchers = new();

        public void AddWatcher(ISubscriberWatcher<SubscriberAlarm> subscriberWatcher)
        {
            watchers.Add(subscriberWatcher);

            public void Notify()
            {
                foreach(var w in watchers)
                {
                    w.Alert(this);
                }
            }
        }

    }
}
