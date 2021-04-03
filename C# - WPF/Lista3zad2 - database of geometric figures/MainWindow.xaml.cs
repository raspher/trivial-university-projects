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

namespace Lista3zad2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Figura> figury = new List<Figura>();
        int figuryCounter = 0;
        
        public MainWindow()
        {
            InitializeComponent();
            listaFigur.ItemsSource = figury;
        }

        private void listaFigur_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var figura = listaFigur.SelectedItem as Figura;
                poleID.Text = figura.id.ToString();
                poleRodzaj.Text = figura.rodzaj;
            } catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void Button_Click_Dodaj(object sender, RoutedEventArgs e)
        {
            if (poleRodzaj.Text == "Punkt")
            {
                var dialog = new DodajPunkt(figuryCounter++);
                if (dialog.ShowDialog() == true)
                {
                    var item = dialog.GetPunkt as Figura;
                    figury.Add(item);
                }
            }

            if (poleRodzaj.Text == "Koło")
            {
                var dialogSrodek = new DodajPunkt(figuryCounter, "Podaj współrzędne środka koła");
                if (dialogSrodek.ShowDialog() == true)
                {
                    var dialogPromien = new DodajPromien();
                    if (dialogPromien.ShowDialog() == true)
                    {
                        figury.Add(
                            new Kolo(
                                figuryCounter++,
                                dialogSrodek.GetPunkt,
                                dialogPromien.promien));
                    }
                }
            }

            if (poleRodzaj.Text == "Trójkąt")
            {
                List<Punkt> trojkat = new List<Punkt>();
                for (int i = 0; i < 3; i++)
                {
                    var dialog = new DodajPunkt(figuryCounter, i);
                    if (dialog.ShowDialog() == true)
                    {
                        trojkat.Add(dialog.GetPunkt);
                    }
                }

                figury.Add(new Trojkat(figuryCounter++, trojkat));
            }

            if (poleRodzaj.Text == "Wielobok")
            {
                List<Punkt> punkty = new List<Punkt>();
                var dialogIle = new DodajPromien("Ile chcesz podać punktów?");
                if(dialogIle.ShowDialog() == true)
                    for(int i=0; i < dialogIle.promien; i++)
                    {
                        var dialog = new DodajPunkt(figuryCounter, i);
                        if (dialog.ShowDialog() == true)
                        {
                            punkty.Add(dialog.GetPunkt);
                        }
                    }

                figury.Add(new Wielobok(figuryCounter++, punkty));
            }

            listaFigur.Items.Refresh();
        }

        private void Button_Click_Usun(object sender, RoutedEventArgs e)
        {
            figury.RemoveAll(el => el.id.ToString().Equals(poleID.Text));
            listaFigur.Items.Refresh();
        }

        private void Button_Click_Edytuj(object sender, RoutedEventArgs e)
        {
            var id = int.Parse(poleID.Text);

            if (poleRodzaj.Text == "Punkt")
            {
                var dialog = new DodajPunkt(id);
                if (dialog.ShowDialog() == true)
                {
                    var item = dialog.GetPunkt as Figura;
                    figury[figury.FindIndex(el => el.id == id)] = item;
                }
            }

            if (poleRodzaj.Text == "Koło")
            {
                var dialogSrodek = new DodajPunkt(id, "Podaj współrzędne środka koła");
                if (dialogSrodek.ShowDialog() == true)
                {
                    var dialogPromien = new DodajPromien();
                    if (dialogPromien.ShowDialog() == true)
                    {
                        figury[figury.FindIndex(el => el.id == id)] =
                            new Kolo(
                                id,
                                dialogSrodek.GetPunkt,
                                dialogPromien.promien);
                    }
                }
            }

            if (poleRodzaj.Text == "Trójkąt")
            {
                List<Punkt> trojkat = new List<Punkt>();
                for (int i = 0; i < 3; i++)
                {
                    var dialog = new DodajPunkt(id, i);
                    if (dialog.ShowDialog() == true)
                    {
                        trojkat.Add(dialog.GetPunkt);
                    }
                }

                figury[figury.FindIndex(el => el.id == id)] = new Trojkat(id, trojkat);
            }

            if (poleRodzaj.Text == "Wielobok")
            {
                List<Punkt> punkty = new List<Punkt>();
                var dialogIle = new DodajPromien("Ile chcesz podać punktów?");
                if (dialogIle.ShowDialog() == true)
                    for (int i = 0; i < dialogIle.promien; i++)
                    {
                        var dialog = new DodajPunkt(id, i);
                        if (dialog.ShowDialog() == true)
                        {
                            punkty.Add(dialog.GetPunkt);
                        }
                    }

                figury[figury.FindIndex(el => el.id == id)] = new Wielobok(id, punkty);
            }

            listaFigur.Items.Refresh();
        }

        private void Button_Click_Pokaz(object sender, RoutedEventArgs e)
        {
            try
            {
                poleSzczegoly.Text = figury.Find(el => el.id.ToString().Equals(poleID.Text)).Wypisz();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
