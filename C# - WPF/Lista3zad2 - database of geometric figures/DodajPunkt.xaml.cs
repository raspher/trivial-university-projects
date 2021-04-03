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

namespace Lista3zad2
{
    /// <summary>
    /// Logika interakcji dla klasy DodajPunkt.xaml
    /// </summary>
    public partial class DodajPunkt : Window
    {
        public Punkt GetPunkt;
        public DodajPunkt(int id, int iterator)
        {
            InitializeComponent();
            question.Content = $"Podaj współrzędne punktu {iterator}:";
            GetPunkt = new Punkt(id);
        }

        public DodajPunkt(int id, string text)
        {
            InitializeComponent();
            question.Content = $"{text}:";
            GetPunkt = new Punkt(id);
        }

        public DodajPunkt(int id)
        {
            InitializeComponent();
            GetPunkt = new Punkt(id);
        }

        private void Button_Click_OK(object sender, RoutedEventArgs e)
        {
            try
            {
                GetPunkt.x = int.Parse(answerX.Text);
                GetPunkt.y = int.Parse(answerY.Text);
                DialogResult = true;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void Button_Click_Anuluj(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
