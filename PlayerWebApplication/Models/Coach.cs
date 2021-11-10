using PlayerWebApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerWebApplication.Models
{
    public class Coach : IObserver
    {
        public string GoalNotifications { get; set; }

        public void Update(ISubject subject, string action)
        {
            GoalNotifications += action + "\n";
        }
    }
}
