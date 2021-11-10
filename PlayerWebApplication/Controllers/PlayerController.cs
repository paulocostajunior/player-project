using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlayerWebApplication.Interfaces;
using PlayerWebApplication.Models;
using PlayerWebApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
        private readonly IGoalGeneratorService _goalGeneratorService;

        public PlayerController(IGoalGeneratorService goalGenerator)
        {
            _goalGeneratorService = goalGenerator;
        }

        [HttpGet("goal")]
        public IActionResult GetGoal()
        {
            var player = new Player();

            var coach = new Coach();

            var goalReporter = new GoalReporter();
            goalReporter.Attach(coach);

            var playerShoot = player.Shoot(goalReporter);           

            _goalGeneratorService.ComputeGoal(goalReporter, playerShoot);

            return new OkObjectResult(coach.GoalNotifications);
        }
    }
}
