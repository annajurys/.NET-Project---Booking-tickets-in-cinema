using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Projekt;

namespace GUI
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListaFilmow f1 = new ListaFilmow();
        ObservableCollection<Film> filmy;
        List<Seans> seanse = new List<Seans>();
        ListaSeansow l1 = new ListaSeansow();
        Film film;
        public MainWindow()
        {
            InitializeComponent();
            filmy = new ObservableCollection<Film>();
            ListaSeansow l1 = new ListaSeansow();
            l1 = l1.OdczytajXML("seanse.xml") as ListaSeansow;
            ListaFilmow f1 = new ListaFilmow();
            f1 = f1.OdczytajXML("filmy.xml") as ListaFilmow;
            filmy = new ObservableCollection<Film>(f1.lista_filmow);
            listbox_filmy.ItemsSource = filmy;
            int i = l1.lista_seansow.Count;
            dataa.DisplayDateEnd = l1.lista_seansow[i-1].data_i_godzina_rozpoczecia;
            
        }
        private void button_film_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                film = filmy.ElementAt(listbox_filmy.SelectedIndex) as Film;
                string data;
                data = dataa.SelectedDate.Value.Date.ToShortDateString();
                this.Hide();
                GodzinaWindow okno = new GodzinaWindow(film,data);
                this.Show();
                
                
            }
            
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Nie wybrałeś filmu lub/i daty!");
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Nie wybrałeś filmu lub/i daty!");
            }
           

        }

        private void Button_dodaj_film_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_dodaj_seans_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                film = filmy.ElementAt(listbox_filmy.SelectedIndex) as Film;
               
                
                this.Hide();
                DodawanieSeansu okno = new DodawanieSeansu(film);
                l1 = l1.OdczytajXML("seanse.xml") as ListaSeansow;
                l1.Sortuj();
                int i = l1.lista_seansow.Count;
                dataa.DisplayDateEnd = l1.lista_seansow[i - 1].data_i_godzina_rozpoczecia;
                this.Show();


            }

            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Nie wybrałeś filmu");
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Nie wybrałeś filmu");
            }
        }
    }
}
