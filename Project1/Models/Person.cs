using System;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Person
    {

        [Key] public uint IdNumber {get; set;}
        [Required] public string name {get; set;}
        [Required] public string lastName {get; set;}
        public int age {get; set;}
    }
}