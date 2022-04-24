using IINTERCARRO.clases;
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
using System.Media;
using Microsoft.Win32;

namespace IINTERCARRO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Carro carrito;
        MediaPlayer Music = new MediaPlayer();
        string fileName;
        public MainWindow()
        {
            InitializeComponent();
            carrito = new Carro("Mazda",2006, "Negro", 150);
        }

        private void buttonEncender_Click(object sender, RoutedEventArgs e)
        {
            labelEncendido.Content = carrito.EncenderMotor();
            labelApagado.Content = "";

        }

        private void Acelerar__Click(object sender, RoutedEventArgs e)
        {

            labelAcelerador.Content = carrito.acelerar();
            labelFrenado.Content = "";

        }

        private void buton_bocinar_Click(object sender, RoutedEventArgs e)
        {
            labelBocinon.Content=carrito.pitar();
        }


        private void ButtonDesacelerar_Click(object sender, RoutedEventArgs e)
        {

            labeldesacelerar.Content = carrito.Desacelerar();
        }


        private void ButtonFrenado_Click(object sender, RoutedEventArgs e)
        {
            labelFrenado.Content = carrito.Frenado();
            labelAcelerador.Content = "    ";
            labeldesacelerar.Content = "   ";
        }

        private void ButtonApagar_Click(object sender, RoutedEventArgs e)
        {

            labelApagado.Content = carrito.ApagarMotor();
            labelEncendido.Content = "    ";
            labelAcelerador.Content = "    ";
            labeldesacelerar.Content = "    ";
            labelFrenado.Content = "    ";
            labelBocinon.Content = "    ";
            Music.Stop();
        }

        private void buttonApertura_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Multiselect = false,
                DefaultExt = ".mp3",

            };
            bool? dialogOk = fileDialog.ShowDialog();
            if(dialogOk == true)
            {
                fileName = fileDialog.FileName;
                TBarchivo.Text = fileDialog.SafeFileName;
                Music.Open(new Uri(fileName));
            }

        }

        private void buttonPlay_Click(object sender, RoutedEventArgs e)
        {
            Music.Play();
        }

        private void buttonPause_Click(object sender, RoutedEventArgs e)
        {
            Music.Pause();
        }

        private void buttonStop_Click(object sender, RoutedEventArgs e)
        {
            Music.Stop();
        
        }
    }
}
