using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
                Intrebari = "detalii",
            });

            authors.Add(new Child()
            {
                ID = 2,
                Nume = "Andrei",
                Simbol = "buburuza",
                Total = 26,
                SarciniFacute = 7,
                Intrebari = "detalii",
            });

            authors.Add(new Child()
            {
                ID = 3,
                Nume = "Andrei",
                Simbol = "buburuza",
                Total = 26,
                SarciniFacute = 7,
                Intrebari = "detalii",
            });
            authors.Add(new Child()
            {
                ID = 4,
                Nume = "Andrei",
                Simbol = "buburuza",
                Total = 26,
                SarciniFacute = 7,
                Intrebari = "detalii",
            });
            authors.Add(new Child()
            {
                ID = 5,
                Nume = "Andrei",
                Simbol = "buburuza",
                Total = 26,
                SarciniFacute = 7,
                Intrebari = "detalii",
            });
            authors.Add(new Child()
            {
                ID = 6,
                Nume = "Andrei",
                Simbol = "buburuza",
                Total = 26,
                SarciniFacute = 7,
                Intrebari = "detalii",
            });
            authors.Add(new Child()
            {
                ID = 7,
                Nume = "Andrei",
                Simbol = "buburuza",
                Total = 26,
                SarciniFacute = 7,
                Intrebari = "detalii",
            });
            authors.Add(new Child()
            {
                ID = 8,
                Nume = "Andrei",
                Simbol = "buburuza",
                Total = 26,
                SarciniFacute = 7,
                Intrebari = "detalii",
            });
            authors.Add(new Child()
            {
                ID = 9,
                Nume = "Andrei",
                Simbol = "buburuza",
                Total = 26,
                SarciniFacute = 7,
                Intrebari = "detalii",
            });
            authors.Add(new Child()
            {
                ID = 10,
                Nume = "Andrei",
                Simbol = "buburuza",
                Total = 26,
                SarciniFacute = 7,
                Intrebari = "detalii",
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
