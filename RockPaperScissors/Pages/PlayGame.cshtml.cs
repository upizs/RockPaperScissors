using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RockPaperScissors.Classes;

namespace RockPaperScissors.Pages
{
    
    public class PlayGameModel : PageModel
    {
        public IEnumerable<Move> Moves { get; set; } = GameMaster.Moves;
        public string WhoScoreMessage { get; set; }
        public string Score { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPostMove(Move playerMove)
        {
            Game.Player.Move = playerMove;
            Game.PlayTurn();
            WhoScoreMessage = Game.WhoScores;

            if (Game.EndGame())
            {
                return RedirectToPage("/GameFinished");
            }

            Score = Statistics.ShowScore();
            return Page();
        }
    }
}
