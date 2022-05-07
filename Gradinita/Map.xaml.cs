using System.Windows;
using System.Windows.Input;

namespace Gradinita
{
    /// <summary>
    /// Interaction logic for Map.xaml
    /// </summary>
    public partial class Map : Window
    {
        public Map()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Game1 game1 = new Game1();
            game1.Show();
            Close();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Game2 game2 = new Game2();
            game2.Show();
            Close();
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Image_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            Game3 game3 = new Game3();
            game3.Show();
            Close();
        }

        private void Image_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            Game4 game4 = new Game4();
            game4.Show();
            Close();
        }
    }
}
