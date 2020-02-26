using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BethanysPieShopMobile.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PieOverview : ContentPage
    {
        public List<string> Pies { get; set; }                    // #1
        //public ObservableCollection<string> Pies { get; set; }  // #2

        public PieOverview()
        {
            InitializeComponent();

            Pies = new List<string>                           // #1
            //Pies = new ObservableCollection<string>          // #2
            {
                "Apple Pie", "Strawberry Cheese", "Strawberry Pie", "Rhubarb Pie", "Blueberry Cheese", "Cheese Cake", "Cherry Pie", "Christmas Apple Pie", "Cranberry Pie", "Peach Pie", "Pumpkin Pie"
            };

            PiesListView.ItemsSource = Pies;
        }

        private void AddPieButton_Clicked(object sender, EventArgs e)
        {
            Pies.Add("Pumpkin Pie");
        }
    }
}