using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Gradinita
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        private DataGrid adminTable;
        public Admin()
        {
            InitializeComponent();
            adminTable = (DataGrid?)this.FindName("tableAdmin");
            adminTable.ItemsSource = LoadCollectionData();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private List<Child> LoadCollectionData()
        {
            List<Child> authors = new List<Child>();
            authors.Add(new Child()
            {
                ID = 1,
                Nume = "Andrei",
                Simbol = "buburuza",
                Total = 26,
                SarciniFacute = 7,
                Sarcina1 = "Efectuat",
                Sarcina2 = "Efectuat",
                Sarcina3 = "Efectuat",
                Sarcina4 = "Efectuat",
                Sarcina5 = "Gresit",
                Sarcina6 = "Efectuat",
                Sarcina7 = "Efectuat",
                Sarcina8 = "Efectuat",
                Sarcina9 = "Neefectuat",
                Sarcina10 = "Efectuat",
                TimpParcurs = new TimeSpan(0, 9, 11),
            });

            authors.Add(new Child()
            {
                ID = 2,
                Nume = "Andrei",
                Simbol = "buburuza",
                Total = 26,
                SarciniFacute = 7,
                Sarcina1 = "Efectuat",
                Sarcina2 = "Efectuat",
                Sarcina3 = "Efectuat",
                Sarcina4 = "Efectuat",
                Sarcina5 = "Efectuat",
                Sarcina6 = "Efectuat",
                Sarcina7 = "Efectuat",
                Sarcina8 = "Efectuat",
                Sarcina9 = "Efectuat",
                Sarcina10 = "Efectuat",
                TimpParcurs = new TimeSpan(0, 9, 11),
            });

            authors.Add(new Child()
            {
                ID = 3,
                Nume = "Andrei",
                Simbol = "buburuza",
                Total = 26,
                SarciniFacute = 7,
                Sarcina1 = "Efectuat",
                Sarcina2 = "Efectuat",
                Sarcina3 = "Efectuat",
                Sarcina4 = "Efectuat",
                Sarcina5 = "Efectuat",
                Sarcina6 = "Efectuat",
                Sarcina7 = "Efectuat",
                Sarcina8 = "Efectuat",
                Sarcina9 = "Efectuat",
                Sarcina10 = "Efectuat",
                TimpParcurs = new TimeSpan(0, 9, 11),
            });
            authors.Add(new Child()
            {
                ID = 4,
                Nume = "Andrei",
                Simbol = "buburuza",
                Total = 26,
                SarciniFacute = 7,
                Sarcina1 = "Efectuat",
                Sarcina2 = "Efectuat",
                Sarcina3 = "Efectuat",
                Sarcina4 = "Efectuat",
                Sarcina5 = "Efectuat",
                Sarcina6 = "Efectuat",
                Sarcina7 = "Efectuat",
                Sarcina8 = "Efectuat",
                Sarcina9 = "Efectuat",
                Sarcina10 = "Efectuat",
                TimpParcurs = new TimeSpan(0, 9, 11),
            });
            authors.Add(new Child()
            {
                ID = 5,
                Nume = "Andrei",
                Simbol = "buburuza",
                Total = 26,
                SarciniFacute = 7,
                Sarcina1 = "Efectuat",
                Sarcina2 = "Efectuat",
                Sarcina3 = "Efectuat",
                Sarcina4 = "Efectuat",
                Sarcina5 = "Efectuat",
                Sarcina6 = "Efectuat",
                Sarcina7 = "Efectuat",
                Sarcina8 = "Efectuat",
                Sarcina9 = "Efectuat",
                Sarcina10 = "Efectuat",
                TimpParcurs = new TimeSpan(0, 9, 11),
            });
            authors.Add(new Child()
            {
                ID = 6,
                Nume = "Andrei",
                Simbol = "buburuza",
                Total = 26,
                SarciniFacute = 7,
                Sarcina1 = "Efectuat",
                Sarcina2 = "Efectuat",
                Sarcina3 = "Efectuat",
                Sarcina4 = "Efectuat",
                Sarcina5 = "Efectuat",
                Sarcina6 = "Efectuat",
                Sarcina7 = "Efectuat",
                Sarcina8 = "Efectuat",
                Sarcina9 = "Efectuat",
                Sarcina10 = "Efectuat",
                TimpParcurs = new TimeSpan(0, 9, 11),
            });
            authors.Add(new Child()
            {
                ID = 7,
                Nume = "Andrei",
                Simbol = "buburuza",
                Total = 26,
                SarciniFacute = 7,
                Sarcina1 = "Efectuat",
                Sarcina2 = "Efectuat",
                Sarcina3 = "Efectuat",
                Sarcina4 = "Efectuat",
                Sarcina5 = "Efectuat",
                Sarcina6 = "Efectuat",
                Sarcina7 = "Efectuat",
                Sarcina8 = "Efectuat",
                Sarcina9 = "Efectuat",
                Sarcina10 = "Efectuat",
                TimpParcurs = new TimeSpan(0, 9, 11),
            });
            authors.Add(new Child()
            {
                ID = 8,
                Nume = "Andrei",
                Simbol = "buburuza",
                Total = 26,
                SarciniFacute = 7,
                Sarcina1 = "Efectuat",
                Sarcina2 = "Efectuat",
                Sarcina3 = "Efectuat",
                Sarcina4 = "Efectuat",
                Sarcina5 = "Efectuat",
                Sarcina6 = "Efectuat",
                Sarcina7 = "Efectuat",
                Sarcina8 = "Efectuat",
                Sarcina9 = "Efectuat",
                Sarcina10 = "Efectuat",
                TimpParcurs = new TimeSpan(0, 9, 11),
            });
            authors.Add(new Child()
            {
                ID = 9,
                Nume = "Andrei",
                Simbol = "buburuza",
                Total = 26,
                SarciniFacute = 7,
                Sarcina1 = "Efectuat",
                Sarcina2 = "Efectuat",
                Sarcina3 = "Efectuat",
                Sarcina4 = "Efectuat",
                Sarcina5 = "Efectuat",
                Sarcina6 = "Efectuat",
                Sarcina7 = "Efectuat",
                Sarcina8 = "Efectuat",
                Sarcina9 = "Efectuat",
                Sarcina10 = "Efectuat",
                TimpParcurs = new TimeSpan(0, 9, 11),
            });
            authors.Add(new Child()
            {
                ID = 10,
                Nume = "Andrei",
                Simbol = "buburuza",
                Total = 26,
                SarciniFacute = 7,
                Sarcina1 = "Efectuat",
                Sarcina2 = "Efectuat",
                Sarcina3 = "Efectuat",
                Sarcina4 = "Efectuat",
                Sarcina5 = "Efectuat",
                Sarcina6 = "Efectuat",
                Sarcina7 = "Efectuat",
                Sarcina8 = "Efectuat",
                Sarcina9 = "Efectuat",
                Sarcina10 = "Efectuat",
                TimpParcurs = new TimeSpan(0, 9, 11),
            });

            return authors;
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
