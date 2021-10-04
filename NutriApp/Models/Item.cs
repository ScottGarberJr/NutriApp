using System;

namespace NutriApp.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Contributor { get; set; }
        //public string Setting { get; set; }
        //public byte[] Image { get; set; }
        //public string Description { get; set; }

        public double Size { get; set; }
        public double Calories { get; set; }
        //public double Protein { get; set; }
        //public double Fat { get; set; }
        //public double Carbs { get; set; }

        //public double Sodium { get; set; }
        //public double Sugar { get; set; }
        //public double Fiber { get; set; }

        public Item()
        {
                   
        }

    public bool Publish(int user, string setting, double size)
        {
            return true;
        }
    }
}

