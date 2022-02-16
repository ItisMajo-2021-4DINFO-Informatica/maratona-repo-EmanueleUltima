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

        public MainWindow()
        {
            InitializeComponent();
            piloti = new Piloti();
            DgElencoPiloti.ItemsSource = piloti.elencoBrani;
        }

        private void BtnLeggiDaFile_Click(object sender, RoutedEventArgs e)
        {
            piloti.LeggiDati();
            DgElencoPiloti.Items.Refresh();
        }

        private void BtnCercaArtista_Click(object sender, RoutedEventArgs e)
        {
            string titolo = TxtTitolo.Text;
            // eventualmente aggiungo un controllo sull'input
            string artistaTrovato = piloti.CercaArtista(città);
            LblArtista.Content = artistaTrovato;
        }

        private void BtnContaBrani_Click(object sender, RoutedEventArgs e)
        {
            string album = TxtAlbum.Text;
            // eventualmente aggiungo un controllo sull'input
            string numeroBrani = piloti.ContaBrani(album);
            LblNumBrani.Content = numeroBrani;
        }

        private void BtnDurata_Click(object sender, RoutedEventArgs e)
        {
            string durata = piloti.CalcolaDurata();
            LblNumBrani.Content = durata;
        }
    }
}