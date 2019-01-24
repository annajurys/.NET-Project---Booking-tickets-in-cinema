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
    /// Logika interakcji dla klasy Plan.xaml
    /// </summary>
    public partial class Plan : Window
    {
        SolidColorBrush czerwony = new SolidColorBrush(Colors.Red);
        SolidColorBrush zielony = new SolidColorBrush(Colors.Green);
        SolidColorBrush pomaranczowy = new SolidColorBrush(Colors.Orange);
        Zamowienie z;
        ListaSeansow ls;
        public Plan(Zamowienie z,ListaSeansow ls)
        {
           
            InitializeComponent();
            this.z = z;
            this.ls = ls;
            int count = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    Button MyControl1 = new Button();
                    MyControl1.Content = count.ToString();
                    MyControl1.Name = "Button"+count.ToString();
                    if (z.seans.plan[count-1] == 1)
                        MyControl1.Background = czerwony;
                    else
                        MyControl1.Background = zielony;
                    MyControl1.Click += klik;
                    Grid.SetColumn(MyControl1, j);
                    Grid.SetRow(MyControl1, i);
                    Planik.Children.Add(MyControl1);
                    count++;
                }
              

            }
            
        }
        private void klik(object sender, RoutedEventArgs e)
        {

            List<int> lista = new List<int>();
            Button przycisk = sender as Button;
            if (przycisk.Background == czerwony)
                MessageBox.Show("Miejsce już zajęte!");
            else if(przycisk.Background == zielony)
            {
                przycisk.Background = pomaranczowy;
                int i = z.lista_biletow.Count;
                WybierzRodzajBiletu okno = new WybierzRodzajBiletu(z, Convert.ToInt32(przycisk.Content));
                okno.ShowDialog();
                int j = z.lista_biletow.Count;
                if (i == j)
                    przycisk.Background = zielony;

            }
            else if (przycisk.Background == pomaranczowy)
            {
                przycisk.Background = zielony;
                z.UsunBilet(Convert.ToInt32(przycisk.Content));
            }
        }

        private void Button_zamowienie_Click(object sender, RoutedEventArgs e)
        {
            if (z.lista_biletow.Count == 0)
                MessageBox.Show("Nie wybrałeś żadnego miejsca, spróbuj ponownie.");
            else
            {
                Podsumowanie okno = new Podsumowanie(z);
                ls.ZapiszXML("seanse.xml");
                this.Hide();
                okno.ShowDialog();
                this.Close();
            }
        }
    }
    }

