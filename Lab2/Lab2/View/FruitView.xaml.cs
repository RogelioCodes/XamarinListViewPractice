using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Lab2.ViewModel;
using Lab2.Model;
using Lab2.View;
namespace Lab2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FruitView : ContentPage
    {
        //FruitViewModel vm;
        int counter = -1; //used to only show onappearing once
        
        public FruitView()
        {
            InitializeComponent();
            //vm = new FruitViewModel();
            //listFruits.ItemsSource = vm.Fruits;
            //BindingContext = vm;
            BindingContext = new FruitViewModel(); //Binding context initialized.
        
    }

        protected override void OnAppearing() //displays prompt when page is opened
        {

            if (counter < 0)
            {
                DisplayAlert("Hey!", "This app displays a list of items! You can click on any of the items here to learn more about them.", "OK");
                counter++;
            }

                
        }
       
        public async void ItemTapped(object sender, ItemTappedEventArgs e) //New page is opened, info about fruit is passed to page
        {
            var mydetails = e.Item as Fruit;
            await Navigation.PushAsync(new FruitsDetails(mydetails.FruitName, mydetails.Topic, mydetails.ShortDescription, mydetails.ImageURL, mydetails.ImageURL2));
        }
        public void RefreshCommand(Object sender, EventArgs e)
        {
            
            DisplayAlert("Hey!", "You refreshed!", "OK");
            listFruits.IsRefreshing = false;
        }
    }
}