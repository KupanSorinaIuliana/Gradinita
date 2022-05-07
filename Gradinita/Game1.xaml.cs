using System.Windows;
using System.Windows.Input;

namespace Gradinita
{
    /// <summary>
    /// Interaction logic for Game1.xaml
    /// </summary>
    public partial class Game1 : Window
    {
        public Game1()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Map map = new Map();
            map.Show();
            Close();
        }
    }
}
