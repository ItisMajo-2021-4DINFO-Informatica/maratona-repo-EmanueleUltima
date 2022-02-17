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

namespace BonaProvaComune5App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Piloti piloti;
        private object citta;

        public MainWindow()
        {
            InitializeComponent();
            piloti = new Piloti();
            DgElencoAtleti.ItemsSource = piloti.elencoMaratone;
        }

        private void BtnLeggiDaFile_Click(object sender, RoutedEventArgs e)
        {
            piloti.LeggiDati();
            DgElencoAtleti.Items.Refresh();
        }



        private void BtnCalcolaMinuti_Click(object sender, RoutedEventArgs e)
        {
            string Nome = TxtNome.Text;
           
            string Atleta = piloti.Nome(citta);
            LblAtleta.Content = Atleta;
        }
      
    private void BtnContaBrani_Click(object sender, RoutedEventArgs e)
        {
            string album = TxtAlbum.Text;
   
            string numeroBrani = piloti.ContaMaratona(album);
            LblNumBrani.Content = numeroBrani;
        }

       

    }
}