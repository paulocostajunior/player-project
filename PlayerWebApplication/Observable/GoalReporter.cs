using PlayerWebApplication.Interfaces;
using PlayerWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerWebApplication.Services
{
    public class GoalReporter : ISubject
    {
        readonly List<IObserver> _observers;

        public GoalReporter()
        {
            _observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Notify(string action)
        {
            foreach (var observer in _observers)
            {
                observer.Update(this, action);
            }
        }
    }
}
