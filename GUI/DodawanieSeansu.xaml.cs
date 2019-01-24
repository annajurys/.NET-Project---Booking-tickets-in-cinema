using Projekt;
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

namespace GUI
{
    /// <summary>
    /// Logika interakcji dla klasy DodawanieSeansu.xaml
    /// </summary>
    /// 
   
    public partial class DodawanieSeansu : Window
    { ListaSeansow l1 = new ListaSeansow();
        Film f1 = new Film();
        public DodawanieSeansu()
        {
            InitializeComponent();
            l1 = l1.OdczytajXML("seanse.xml") as ListaSeansow;
        }
        public DodawanieSeansu(Film f) : this()
        {

            f1 = f;
            textbox_film.Text = f.ToString();
            this.ShowDialog();
            



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime data = DateTime.Parse(date_picker_d.ToString()).AddHours(int.Parse(text_box_h.Text)).AddMinutes(double.Parse(text_box_m.Text));
                l1.DodajSeans(new Seans(f1, data, new Sala(100)));
                l1.ZapiszXML("seanse.xml");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Coś poszło nie tak");
            }
        }
    }
}
