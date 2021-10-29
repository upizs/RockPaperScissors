
using Microsoft.AspNetCore.Mvc.RazorPages;
using RockPaperScissors.Classes;
using RockPaperScissors.Models;

namespace RockPaperScissors.Pages
{
    public class GameFinishedModel : PageModel
    {
        public StatisticsViewModel GameStatistics { get; set; }
        public void OnGet()
        {
            GameStatistics = new StatisticsViewModel
            {
                ComputerScore = Statistics.ComputerScore,
                PlayerScore = Statistics.PlayerScore,
                MostUsedMove = Statistics.ReturnTopMove(),
                Turns = Statistics.Turns,
                Winner = Statistics.ReturnWinner()
            };
        }
    }
}
