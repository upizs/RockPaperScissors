using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RockPaperScissors.Classes;
using RockPaperScissors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissors.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public UserInputModel UserInput { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Game.StartGame();
                GameMaster.ScoreToWin = UserInput.ScoreToWin;
                return RedirectToPage("/PlayGame");
            }

            return Page();
        }

    }
}
