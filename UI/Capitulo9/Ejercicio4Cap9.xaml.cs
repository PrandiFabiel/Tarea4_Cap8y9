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

namespace Capitulo8y9.UI.Capitulo9
{
    /// <summary>
    /// Interaction logic for Ejercicio4Cap9.xaml
    /// </summary>
    public partial class Ejercicio4Cap9 : Window
    {
        public Ejercicio4Cap9()
        {
            InitializeComponent();
        }

        enum Neumatico { Verano, Invierno, Allseasons, Asimétricos, Direccionales, Antipinchazos, Tweel };

        private void MostrarButton_Click(object sender, RoutedEventArgs e)
        {
            Neumatico neumatico;

            neumatico = Neumatico.Direccionales;
            TipoTextBox.Text = neumatico.ToString();
        }
    }
}
