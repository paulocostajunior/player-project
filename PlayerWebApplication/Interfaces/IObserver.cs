using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerWebApplication.Interfaces
{
    public interface IObserver
    {
        void Update(ISubject s, string action);
    }
}
