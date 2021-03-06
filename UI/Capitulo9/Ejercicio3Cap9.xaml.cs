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
    /// Interaction logic for Ejercicio3Cap9.xaml
    /// </summary>
    public partial class Ejercicio3Cap9 : Window
    {
        public Ejercicio3Cap9()
        {
            InitializeComponent();
        }

        public struct Mascota
        {
            public string Nombre;
            public string Raza;
            public string ColorPelo;
            public int Edad;

            public Mascota(string _Nombre, string _Raza, string _ColorPelo, int _Edad)
            {
                Nombre = _Nombre;
                Raza = _Raza;
                ColorPelo = _ColorPelo;
                Edad = _Edad;
            }
            public override string ToString()
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendFormat($"Mascota\n\nNombre: {Nombre}\nRaza: {Raza}\nColor de pelo: {ColorPelo}\nEdad: {Edad}");
                return (stringBuilder.ToString());
            }
        }

        public struct Dueño
        {
            public string Nombre;
            public string Telefono;
            public int Edad;
            public string Direccion;
            public Mascota Perro;
        }

        Dueño dueño = new Dueño();

        private void GuardarYMostrarButton_Click(object sender, RoutedEventArgs e)
        {
            dueño.Nombre = NombreTextBox.Text;
            dueño.Telefono = TelefonoTextBox.Text;
            dueño.Edad = int.Parse(EdadTextBox.Text);
            dueño.Direccion = DireccionTextBox.Text;
            dueño.Perro = new Mascota(NombreMascotaTextBox.Text, RazaTextBox.Text,
            ColorPeloTextBox.Text, int.Parse(EdadMascotaTextBox.Text));

            Limpiar();
            Mostrar();
        }

        public void Limpiar()
        {
            NombreTextBox.Text = "";
            TelefonoTextBox.Text = "";
            EdadTextBox.Text = "";
            DireccionTextBox.Text = "";
            NombreMascotaTextBox.Text = "";
            RazaTextBox.Text = "";
            ColorPeloTextBox.Text = "";
            EdadMascotaTextBox.Text = "";
        }

        public void Mostrar()
        {
            ViewTextBlock.Text = $"Datos del dueño:\n\nNombre: {dueño.Nombre}\nTelefono: " +
                $"{dueño.Telefono}\nDireccion: {dueño.Direccion}\n\n{dueño.Perro.ToString()}";
        }
    }
}
