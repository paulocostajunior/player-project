using PlayerWebApplication.Models;
using PlayerWebApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerWebApplication.Interfaces
{
    public interface IGoalGeneratorService
    {
        public bool ComputeGoal(GoalReporter goalReporter, int playerShoot);
    }
}
