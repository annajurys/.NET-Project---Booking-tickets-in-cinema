using Microsoft.Win32;
using Projekt;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
    /// Logika interakcji dla klasy Podsumowanie.xaml
    /// </summary>
    public partial class Podsumowanie : Window
    {
        Zamowienie z;
        public Podsumowanie(Zamowienie z)
        {
            this.z = z;
            InitializeComponent();
            Text_box_podsumowanie.Text = z.ToString();
           

        }

        private void Button_drukuj_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter outputFile = new StreamWriter("Zamówienie.txt"))
            {
                    outputFile.Write(z.ToString());
                
            }
            Process.Start("Zamówienie.txt");
        }
    }
}
