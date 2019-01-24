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
    /// Logika interakcji dla klasy WybierzRodzajBiletu.xaml
    /// </summary>
    public partial class WybierzRodzajBiletu : Window
    {
        Zamowienie z;
        int m;
        public WybierzRodzajBiletu(Zamowienie z,int m)
        {
            InitializeComponent();
            this.z = z;
            this.m = m;

        }

        private void Button_zatwierdz_Click(object sender, RoutedEventArgs e)
        {
            if (combo_box_bilet.Text == "ulgowy 10zł")
            {
                z.DodajBilet(new BiletUlgowy(), m);
                this.Close();
            }
            else if (combo_box_bilet.Text == "normalny 20zł")
            {
                z.DodajBilet(new BiletNormalny(), m);
                this.Close();
            }
            else MessageBox.Show("Nie wybrałeś rodzaju!");
            }
    }
}
