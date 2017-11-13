using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuessingGame.Models
{
    public class GameModel
    {
        [Required]//must explicitly tell program that this property is required
        [MaxLength(25)]
        [Display(Name = "Player Name")]//changes what label will look like in View
        public string PlayerName { get; set; }//string is a reference type, so it can be null

        [Range(1, 10, ErrorMessage = "Guess must be between 1 and 10")]//specify error message
        public int Guess { get; set; }//int is a value type, therefore it can't be null and is required
    }
}