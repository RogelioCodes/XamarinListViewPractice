using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FruitsDetails : ContentPage
    {
        
        public FruitsDetails(string FruitName, string Topic, string ShortDescription, string ImageURL, string ImageURL2)
        {
            InitializeComponent();
            MyItemNameShow.Text = FruitName;
            MyDetailItemShow.Text = ShortDescription;
            MyImageCall.Source = ImageURL;
            MyImageCall2.Source = ImageURL2;


        }
    }
}