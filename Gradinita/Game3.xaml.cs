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
    /// Interaction logic for Game3.xaml
    /// </summary>
    public partial class Game3 : Window
    {
        public Game3()
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
