using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsManagement
{
    public class ReservationFactory : ISubject
    {
        List<IObserver> observers = new List<IObserver>();
        int value;

        public void notifyObservers(ReservationType reserv)
        {
            foreach (IObserver obs in observers)
            {
                //obs.update(value);
            }
        }

        public void registerObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            this.observers.Remove(observer);

        }

        
    }
}

