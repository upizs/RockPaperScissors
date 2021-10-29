using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissors.Models
{
    public class UserInputModel
    {
        [Required(ErrorMessage = "You must provide the winning score to play the game")]
        [Display(Name = "What score wins the game?", Description = "You must provide number between 1 and 10")]
        //I set up max score to not ridiculus max
        [Range(1,10, ErrorMessage = "The winning score must be between {1} and {2}")]
        public int ScoreToWin { get; set; }
    }
}
