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

namespace WpfPruebas
{
    /// <summary>
    /// Lógica de interacción para FEventos.xaml
    /// </summary>
    public partial class FEventos : Window
    {
        NombrePersona persona = new NombrePersona { Nombre ="Lucia", Edad= 22};
        public FEventos()
        {
            InitializeComponent();
            this.DataContext = persona;
        }

        private void evtSaludar(object sender, RoutedEventArgs e) {
            MessageBox.Show("Hola" + persona.Nombre, "Saludo",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }


    }

    
}
