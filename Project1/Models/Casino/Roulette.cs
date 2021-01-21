using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project1.Models.Casino
{
    public class Roulette
    {
        
        [Key] public int rouletteID {get;set;}
        public virtual ICollection<Bet> bets {get; set;}
    }

    public class Bet
    {
        [Key] public int betID {get;set;}
        [Required] public int betAmmount {get;set;}
        //TODO: Convertir esta entidad en su propia tabla por normalización.
        [Required] public int betType {get; set;}
        [Required] public virtual Result result {get;set;}
    }

    public class Result
    {
        [Key] public int resultID {get;set;}
        [Required] public int number {get;set;}
        [Required] public string color {get;set;}
    }
}