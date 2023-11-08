using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL_Player.Observer
{
    public class Publisher : IObservable
    {
        private readonly List<IObserver> observers = new List<IObserver>();
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void NotifyObservers(string trainingDetails)
        {
            foreach (var observer in observers)
            {
                observer.Update(trainingDetails);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void NewTraining(string coachName, string trainingDetails)
        {
            string details = $"Coach {coachName} posted a new training: {trainingDetails}";
            NotifyObservers(details);
        }
    }
}
