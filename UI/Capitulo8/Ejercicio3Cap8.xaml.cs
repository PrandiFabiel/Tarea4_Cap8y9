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

namespace Capitulo8y9.UI.Capitulo8
{
    /// <summary>
    /// Interaction logic for Ejercicio3Cap8.xaml
    /// </summary>
    public partial class Ejercicio3Cap8 : Window
    {
        public Ejercicio3Cap8()
        {
            InitializeComponent();
            MostrarHoraFecha(); 
        }

        public void MostrarHoraFecha()
        {
            FechaHora.Content += DateTime.Now.ToString();
        }
    }
}
