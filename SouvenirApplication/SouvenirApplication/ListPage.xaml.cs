using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SouvenirApplication.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SouvenirApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var slist = (SouvenirShopList)BindingContext;
            await App.Database.SaveSouvenirShopListAsync(slist);
            await Navigation.PopAsync();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var slist = (SouvenirShopList)BindingContext;
            await App.Database.DeleteSouvenirShopListAsync(slist);
            await Navigation.PopAsync();
        }

    }
}