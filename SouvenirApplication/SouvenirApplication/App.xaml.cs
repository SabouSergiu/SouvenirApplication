using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SouvenirApplication.Data;
using System.IO;

namespace SouvenirApplication
{
    public partial class App : Application
    {
        static SouvenirShoppingListDatabase database;
        public static SouvenirShoppingListDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                   SouvenirShoppingListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SouvenirShoppingList.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListEntryPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
