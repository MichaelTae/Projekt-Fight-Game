using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Fight_Game.Observer
{
    public class Subject
    {
        public int State { get; set; } = -0;

        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(var observer in observers)
            {
                observer.Update(this);
            }
        }
    }
}
