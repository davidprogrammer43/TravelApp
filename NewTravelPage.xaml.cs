using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApp.Model;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTravelPage : ContentPage
    {
        public NewTravelPage()
        {
            InitializeComponent();
        }
        private void ToolbarItemSave_Clicked(Object Sender, EventArgs e)
        {
            Post post = new Post()
            {
                Experience = ExperienceEntry.Text                
            };

            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
                 
            conn.CreateTable<Post>();
           int rows = conn.Insert(post);
            conn.Close();

            if( rows > 0)  
                   DisplayAlert("Success", "Experience Added to Database", "Ok");
                else
                DisplayAlert("Failure", "No record added", "Ok");
                



        }
    }
}