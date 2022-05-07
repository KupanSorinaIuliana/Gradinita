using System.Windows;

namespace Gradinita
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Admin subWindow = new Admin();
            subWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Admin subWindow = new Admin();
            subWindow.Show();
            Close();
        }

        private void Image_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Map map = new Map();
            map.Show();
            Close();
        }
    }
}
