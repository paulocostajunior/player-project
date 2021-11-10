using PlayerWebApplication.Interfaces;
using PlayerWebApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerWebApplication.Models 
{
    public class Player
    {
        public int Shoot (GoalReporter goalReporter)
        {
            goalReporter.Notify("The player shoots the ball");

            return new Random().Next(0, 100);
        }
    }
}
