using RestSharp;
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

namespace WPFHarryPotter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<HarryPotter> listaPersonajes;

        int cont = 0;
        public MainWindow()
        {
            InitializeComponent();

            var client = new RestClient("https://hp-api.onrender.com");
            var request = new RestRequest("/api/characters/staff", Method.Get);
            listaPersonajes = client.Execute<List<HarryPotter>>(request).Data;
            List<string> nombres = new List<string>();
            foreach (var item in listaPersonajes)
            {
                nombres.Add(item.name);
                
            }
            nombres.Sort();
            foreach (var item in nombres) {
                comboBox.Items.Add(item);
            }



        }
        private void siguiente(object sender, RoutedEventArgs e)
        {
                cont++;
            try
            {
                textoNombre.Text = listaPersonajes[cont].name;
                textoGenero.Text = listaPersonajes[cont].gender;
                textoCasa.Text = listaPersonajes[cont].house;
                textoCumple.Text = listaPersonajes[cont].dateOfBirth;
                textoPatronus.Text = listaPersonajes[cont].patronus;
            }
            catch (Exception ex) {
                MessageBox.Show("No hay mas personajes");
            }
               
            try
            {
                imagen.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(new Uri(listaPersonajes[cont].image));
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay imagen");

            }


        }
        private void anterior(object sender, RoutedEventArgs e) {
            
                cont--;
            try
            {
                textoNombre.Text = listaPersonajes[cont].name;
                textoGenero.Text = listaPersonajes[cont].gender;
                textoCasa.Text = listaPersonajes[cont].house;
                textoCumple.Text = listaPersonajes[cont].dateOfBirth;
                textoPatronus.Text = listaPersonajes[cont].patronus;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay menos personajes");
            }
            try
            {
                imagen.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(new Uri(listaPersonajes[cont].image));
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay imagen");

            }


        }
        private void buscar(object sender, RoutedEventArgs e) {
         

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < listaPersonajes.Count; i++) {
                if (listaPersonajes[i].name.Equals(comboBox.SelectedItem)) {
                    cont = i;
                    break;
                }

            }
            textoNombre.Text = listaPersonajes[cont].name;
            textoGenero.Text = listaPersonajes[cont].gender;
            textoCasa.Text = listaPersonajes[cont].house;
            textoCumple.Text = listaPersonajes[cont].dateOfBirth;
            textoPatronus.Text = listaPersonajes[cont].patronus;
            try
            {
                imagen.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(new Uri(listaPersonajes[cont].image));
            }
            catch (Exception ex) {
                MessageBox.Show("No hay imagen");
               
            }

        }


    }
    }

