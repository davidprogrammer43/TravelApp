using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TravelApp.Model;
 


namespace TravelApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistoryPage : ContentPage
    {
        public HistoryPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        
        {
            base.OnAppearing();
                {
                SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
                conn.CreateTable<Post>();
               var Posts= conn.Table<Post>().ToList();
                conn.Close();

            }

        }
    }
}