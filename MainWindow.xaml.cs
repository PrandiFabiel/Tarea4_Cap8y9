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
using Capitulo8y9.UI.Capitulo8;
using Capitulo8y9.UI.Capitulo9;

namespace Capitulo8y9
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

        private void Ejercicio3MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio3Cap8 ejercicio3Cap8 = new Ejercicio3Cap8();
            ejercicio3Cap8.Show(); 
        }

        private void Ejercicio5MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5Cap8 ejercicio5Cap8 = new Ejercicio5Cap8();
            ejercicio5Cap8.Show(); 
        }

        private void Ejercicio1Cap9MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio1Cap9 ejercicio1Cap9 = new Ejercicio1Cap9();
            ejercicio1Cap9.Show(); 
        }

        private void Ejercicio3Cap9MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio3Cap9 ejercicio3Cap9 = new Ejercicio3Cap9();
            ejercicio3Cap9.Show(); 
        }

        private void Ejercicio4Cap9MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio4Cap9 ejercicio4Cap9 = new Ejercicio4Cap9();
            ejercicio4Cap9.Show(); 
        }
    }
}
