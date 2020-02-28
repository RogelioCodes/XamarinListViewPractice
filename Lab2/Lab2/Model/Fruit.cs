using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Model
{
    public class Fruit
    {
        public string FruitName { get; set; }
        public string Topic { get; set; }
        public string ShortDescription { get; set; }
        public string ImageURL { get; set; }
        public string ImageURL2 { get; set; }
        public string ButtonName { get; set; }

        public List<Fruit> GetFruits()
        {
            List<Fruit> fruits = new List<Fruit>()
            {
                    

            };
            return fruits;
        }
    }
}
