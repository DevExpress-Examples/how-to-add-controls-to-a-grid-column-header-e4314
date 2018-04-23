using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using DevExpress.Xpf.Grid;
using System.Collections;

namespace DxSample
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            gridControl1.ItemsSource = DataHelper.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            GridColumnData column = button.DataContext as GridColumnData;
            ((column.View as TableView).DataControl as GridControl).UngroupBy(column.Column as GridColumn);
        }
    }

    public static class DataHelper
    {
        public static ObservableCollection<DetailCityInfo> GetData()
        {
            ObservableCollection<DetailCityInfo> cities = new ObservableCollection<DetailCityInfo>() 
            {
                new DetailCityInfo("London", "UK", 1), new DetailCityInfo("Glasgow", "UK", 1), new DetailCityInfo("Edinburgh", "UK", 1), new DetailCityInfo("Aberdeen Dundee", "UK", 1),
                new DetailCityInfo("Washington", "USA", 2), new DetailCityInfo("Chicago", "USA", 2), new DetailCityInfo("Los Angeles", "USA", 2), new DetailCityInfo("New York", "USA", 2),  
                new DetailCityInfo("Hong Kong", "China", 3), new DetailCityInfo("Shanghai", "China", 3), new DetailCityInfo("Beijing", "China", 3), new DetailCityInfo("Tianjin", "China", 3) 
            };
            return cities;
        }
    }

    public class DetailCityInfo
    {
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public int ID { get; set; }

        public DetailCityInfo(string cityName, string countryName, int id)
        {
            CityName = cityName;
            CountryName = countryName;
            ID = id;
        }
    }
}
