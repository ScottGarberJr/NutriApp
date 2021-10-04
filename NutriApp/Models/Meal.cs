using System;
using System.Collections.Generic;

namespace NutriApp.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public string User { get; set; }
        public DateTime? Time { get; set; }
        public Dictionary<int, double> Ingredients { get; set; }
        public bool isWeighed;


        public Meal()
        {
        }
    }
}
