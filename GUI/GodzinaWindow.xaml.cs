using Projekt;
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
using System.Windows.Shapes;

namespace GUI
{
    /// <summary>
    /// Logika interakcji dla klasy GodzinaWindow.xaml
    /// </summary>
    public partial class GodzinaWindow : Window
    {
        ObservableCollection<Seans> ls=new ObservableCollection<Seans>();
        ListaSeansow l1 = new ListaSeansow();
        
         
        public GodzinaWindow()
        {
            InitializeComponent();
            l1 = l1.OdczytajXML("seanse.xml") as ListaSeansow;

        }
        public GodzinaWindow(Film f,string data):this()
        {
            

            foreach (Seans s in l1.lista_seansow)
            {
                if (s.film.tytul == f.tytul&&s.data_i_godzina_rozpoczecia.ToShortDateString()==data&&s.data_i_godzina_rozpoczecia>DateTime.Now.AddMinutes(-10))
                    ls.Add(s); 
            }
            textblock_wybranyfilm.Text=f.ToString();
            if (ls.Count == 0)
            {
                MessageBox.Show("Nie ma seansów w podanych dniach!");
            }
            else
            {
                listbox_godziny.ItemsSource = ls;
                this.ShowDialog();

            }
      
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int zaznaczony = listbox_godziny.SelectedIndex;
                Seans s = ls.ElementAt(zaznaczony);
                Zamowienie z1 = new Zamowienie(s);

                Plan okno = new Plan(z1,l1);
                this.Hide();
                okno.ShowDialog();
                this.Close();
            }

            catch (System.ArgumentOutOfRangeException)

            {
                MessageBox.Show("Nie wybrałeś godziny");
            }

        }
    }
}
