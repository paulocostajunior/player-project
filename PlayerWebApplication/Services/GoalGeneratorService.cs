using PlayerWebApplication.Interfaces;
using PlayerWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerWebApplication.Services
{
    public class GoalGeneratorService : IGoalGeneratorService
    {
        public bool ComputeGoal(GoalReporter goalReporter, int playerShoot)
        {
            if (playerShoot < 50)
            {
                goalReporter.Notify("The palyer misses the goal");

                return false;
            }

            goalReporter.Notify("The palyer scores a goal");

            return true;
        }
    }
}
