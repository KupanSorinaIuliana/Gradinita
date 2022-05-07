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
    }
}
