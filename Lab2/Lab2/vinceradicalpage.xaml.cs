using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Windows.Input;

namespace Lab2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class vinceradicalpage : ContentPage
    {
        public vinceradicalpage()
        {
            InitializeComponent();
        }

        //public ICommand RefreshCommand => new Command(async () => await RefreshItemsAsync());
    }
}