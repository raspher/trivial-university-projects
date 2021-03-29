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
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Lista3zad1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Samochod> samochody = new List<Samochod>();

        public MainWindow()
        {
            InitializeComponent();
            listaSamochodow.ItemsSource = samochody;
        }
        // Logika
        private void Button_Click_Dodaj(object sender, RoutedEventArgs e)
        {
            try
            {
                if (poleTyp.Text == "Sportowy")
                    samochody.Add(new Sportowy(
                        int.Parse(poleID.Text),
                        poleMarka.Text,
                        poleModel.Text,
                        poleTyp.Text,
                        int.Parse(poleRokProdukcji.Text),
                        int.Parse(polePojemnosc.Text),
                        int.Parse(poleDodatkowe.Text)
                        ));
                if (poleTyp.Text == "Terenowy")
                    samochody.Add(new Terenowy(
                        int.Parse(poleID.Text),
                        poleMarka.Text,
                        poleModel.Text,
                        poleTyp.Text,
                        int.Parse(poleRokProdukcji.Text),
                        int.Parse(polePojemnosc.Text),
                        poleDodatkowe.Text
                        ));
                if (poleTyp.Text == "Rodzinny")
                    samochody.Add(new Rodzinny(
                        int.Parse(poleID.Text),
                        poleMarka.Text,
                        poleModel.Text,
                        poleTyp.Text,
                        int.Parse(poleRokProdukcji.Text),
                        int.Parse(polePojemnosc.Text),
                        poleDodatkowe.Text
                        ));

                listaSamochodow.Items.Refresh();
            } catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }



        // GUI

        private void poleTyp_DropDownClosed(object sender, EventArgs e)
        {
            switch (poleTyp.Text)
            {   
                case "Sportowy":
                    PoleDodatkowe.Content = "Moc (KM)";
                    break;
                case "Terenowy":
                    PoleDodatkowe.Content = "Napęd";
                    break;
                default:
                    PoleDodatkowe.Content = "Miejsc siedzących";
                    break;
            }

            poleWyszDod.Content = PoleDodatkowe.Content;
        }

        private void Button_Click_Pokaz(object sender, RoutedEventArgs e)
        {
            var zaznaczony = listaSamochodow.SelectedItem as Samochod;
            poleSzczegoly.Text = zaznaczony.Pisz();
        }

        private void Button_Click_Usun(object sender, RoutedEventArgs e)
        {
            var zaznaczony = listaSamochodow.SelectedItem as Samochod;
            samochody.Remove(zaznaczony);
            listaSamochodow.Items.Refresh();
        }

        private void Button_Click_Edytuj(object sender, RoutedEventArgs e)
        {
            var zaznaczony = listaSamochodow.SelectedItem as Samochod;
            try
            {
                if (poleTyp.Text == "Sportowy")
                    samochody[samochody.FindIndex(el => el.id == zaznaczony.id)] = (new Sportowy(
                        int.Parse(poleID.Text),
                        poleMarka.Text,
                        poleModel.Text,
                        poleTyp.Text,
                        int.Parse(poleRokProdukcji.Text),
                        int.Parse(polePojemnosc.Text),
                        int.Parse(poleDodatkowe.Text)
                        ));
                if (poleTyp.Text == "Terenowy")
                    samochody[samochody.FindIndex(el => el.id == zaznaczony.id)] = (new Terenowy(
                        int.Parse(poleID.Text),
                        poleMarka.Text,
                        poleModel.Text,
                        poleTyp.Text,
                        int.Parse(poleRokProdukcji.Text),
                        int.Parse(polePojemnosc.Text),
                        poleDodatkowe.Text
                        ));
                if (poleTyp.Text == "Rodzinny")
                    samochody[samochody.FindIndex(el => el.id == zaznaczony.id)] = (new Rodzinny(
                        int.Parse(poleID.Text),
                        poleMarka.Text,
                        poleModel.Text,
                        poleTyp.Text,
                        int.Parse(poleRokProdukcji.Text),
                        int.Parse(polePojemnosc.Text),
                        poleDodatkowe.Text
                        ));

                listaSamochodow.Items.Refresh();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            listaSamochodow.Items.Refresh();
        }

        private void listaSamochodow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var zaznaczony = listaSamochodow.SelectedItem as Samochod;
                poleID.Text = zaznaczony.id.ToString();
                poleMarka.Text = zaznaczony.marka;
                poleModel.Text = zaznaczony.model;
                poleTyp.Text = zaznaczony.typ;
                poleTyp_DropDownClosed(sender, e);
                poleRokProdukcji.Text = zaznaczony.rokProdukcji.ToString();
                polePojemnosc.Text = zaznaczony.pojemnoscSilnika.ToString();

                if (poleTyp.Text.Equals("Sportowy"))
                {
                    var samochodxx = samochody.Find(el => el.id == zaznaczony.id) as Sportowy;
                    poleDodatkowe.Text = samochodxx.moc.ToString();
                }

                if (poleTyp.Text.Equals("Terenowy"))
                {
                    var samochodxx = samochody.Find(el => el.id == zaznaczony.id) as Terenowy;
                    poleDodatkowe.Text = samochodxx.naped.ToString();
                }

                if (poleTyp.Text.Equals("Rodzinny"))
                {
                    var samochodxx = samochody.Find(el => el.id == zaznaczony.id) as Rodzinny;
                    poleDodatkowe.Text = samochodxx.miejsc.ToString();
                }
            } catch(Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        private void Button_Click_Szukaj(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(buttonSzukaj.Content + ":" + buttonSzukaj.Content.ToString());
            if (buttonSzukaj.Content.ToString() == "Szukaj")
            {
                buttonSzukaj.Content = "Powrót";
                pokazWyniki();
            } else
            {
                listaSamochodow.ItemsSource = samochody;
                buttonSzukaj.Content = "Szukaj";
            }
        }

        private void pokazWyniki()
        {
            if (poleWyszukiwanie.Text.Equals("ID"))
                listaSamochodow.ItemsSource = samochody.FindAll(el => el.id.ToString() == poleID.Text);
            else if (poleWyszukiwanie.Text.Equals("Marka"))
                listaSamochodow.ItemsSource = samochody.FindAll(el => el.marka == poleMarka.Text);
            else if (poleWyszukiwanie.Text.Equals("Model"))
                listaSamochodow.ItemsSource = samochody.FindAll(el => el.model == poleModel.Text);
            else if (poleWyszukiwanie.Text.Equals("Typ"))
                listaSamochodow.ItemsSource = samochody.FindAll(el => el.typ == poleTyp.Text);
            else if (poleWyszukiwanie.Text.Equals("Rok Produkcji"))
                listaSamochodow.ItemsSource = samochody.FindAll(el => el.rokProdukcji.ToString() == poleRokProdukcji.Text);
            else if (poleWyszukiwanie.Text.Equals("Pojemnosc"))
                listaSamochodow.ItemsSource = samochody.FindAll(el => el.pojemnoscSilnika.ToString() == polePojemnosc.Text);
            else // dodatkowe
                listaSamochodow.ItemsSource = samochody.FindAll(el => el.typ == poleTyp.Text).FindAll(el => el.getPoleDod() == poleDodatkowe.Text);
        }
    }
}
