using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Lab2.Model;
using Lab2.View;
namespace Lab2.ViewModel

{
    public class FruitViewModel
    {
        public ObservableCollection<Fruit> Fruits { get; set; }
        //public List<Fruit> Fruits { get; set; }//get/set methods(obviously)
        
        public FruitViewModel()//constructor
        {
            Fruits = new ObservableCollection<Fruit>();
            {
                Fruits.Add(new Fruit
                {
                    FruitName = "Banana",
                    Topic = "Nutrition",
                    ImageURL = "banana.png",
                    ImageURL2 = "banana2.png",
                    ShortDescription = "A banana is an edible fruit – botanically a berry – produced by several kinds of large herbaceous flowering plants in the genus Musa. " +
                        "In some countries, bananas used for cooking may be called plantains, distinguishing them from dessert bananas." //pulled from google
                }
                );
                Fruits.Add(new Fruit
                {
                    FruitName = "Pineapple",
                    Topic = "Nutritional facts:",
                    ImageURL = "aa.png",
                    ImageURL2 ="pp.png",
                    ShortDescription = "The pineapple is a tropical plant with an edible fruit, also called a pineapple, and the most economically significant plant in the family Bromeliaceae. The pineapple is indigenous to South America, where it has been cultivated for many centuries.",
                   //pulled from google(just the description)
                });
                Fruits.Add(new Fruit
                {
                    FruitName = "Orange",
                    Topic = "Nutritional facts:",
                    ImageURL = "orange.png",
                    ImageURL2 = "orange2.png",
                    ShortDescription = "The orange is the fruit of the citrus species Citrus × sinensis in the family Rutaceae, native to China. It is also called sweet orange, to distinguish it from the related Citrus × aurantium, referred to as bitter orange. The sweet orange reproduces asexually; varieties of sweet orange arise through mutations.",
                    //pulled from google(just the description)
                });
                Fruits.Add(new Fruit
                {
                    FruitName = "Mango",
                    Topic = "Nutritional facts:",
                    ImageURL = "mango.png",
                    ImageURL2 = "mango2.png",
                    ShortDescription = "A mango is a juicy stone fruit produced from numerous species of tropical trees belonging to the flowering plant genus Mangifera, cultivated mostly for their edible fruit. Most of these species are found in nature as wild mangoes. The genus belongs to the cashew family Anacardiaceae. ",
                    //pulled from google(just the description)
                });
            };
            //Fruits = new Fruit().GetFruits();
        }
    }
}
