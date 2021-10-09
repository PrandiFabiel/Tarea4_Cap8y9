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
    /// Interaction logic for Ejercicio1Cap9.xaml
    /// </summary>
    public partial class Ejercicio1Cap9 : Window
    {
        public Ejercicio1Cap9()
        {
            InitializeComponent();
        }

        public struct Producto
        {
            public int IdProducto;
            public string Nombre;
            public int CantidadProducto;
            public double PrecioProducto;
        }

        Producto producto = new Producto();

        private void GuardarYMostrarButton_Click(object sender, RoutedEventArgs e)
        {
            producto.IdProducto = int.Parse(IdProductoTextBox.Text);
            producto.Nombre = NombreProductoTextBox.Text;
            producto.CantidadProducto = int.Parse(CantidadProductoTextBox.Text);
            producto.PrecioProducto = double.Parse(PrecioProductoTextBox.Text);

            Limpiar();
            Mostrar();
        }

        public void Limpiar()
        {
            IdProductoTextBox.Text = "";
            NombreProductoTextBox.Text = "";
            CantidadProductoTextBox.Text = "";
            PrecioProductoTextBox.Text = "";
        }

        public void Mostrar()
        {
            ViewTextBlock.Text = $"Id Producto:\n{producto.IdProducto}\nNombre Producto:\n{producto.Nombre}\n" +
                $"Cantidad Producto:\n{producto.CantidadProducto}\nPrecio producto:\n{producto.PrecioProducto}";
        }

    }
}
