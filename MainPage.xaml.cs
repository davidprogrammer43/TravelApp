using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using SQLite;
using Xamarin.Forms;
using Windows.Storage;


namespace TravelApp.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            string dbName = "Travel.db3";
            //   string folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            //     string fullPath = Path.Combine(folderPath, dbName);
            var fullPath = Path.Combine(ApplicationData.Current.LocalFolder.Path, dbName);
            //  var fullPath = "C:\\users\\David\\Documents\\travel_db.sqlite";
            LoadApplication(new TravelApp.App(fullPath));
        }
    }
}
