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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ColoresSIUUUU
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRojo_Click(object sender, RoutedEventArgs e)
        {
            Red red = new Red();
            red.Show();
            this.Close();
        }

        private void btnVerde_Click(object sender, RoutedEventArgs e)
        {
            verde green = new verde();
            green.Show();
            this.Close();
        }

        private void btnAzul_Click(object sender, RoutedEventArgs e)
        {
            Azul blue = new Azul();
            blue.Show();
            this.Close();
        }
    }
}
