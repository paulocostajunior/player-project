using PlayerWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerWebApplication.Interfaces
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Notify (string action);
    }
}
