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
    /// Logika interakcji dla klasy DodajPromien.xaml
    /// </summary>
    public partial class DodajPromien : Window
    {
        public int promien { get; set; }
        public DodajPromien()
        {
            InitializeComponent();
        }

        public DodajPromien(string text)
        {
            InitializeComponent();
            question.Content = text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                promien = int.Parse(answer.Text);
                DialogResult = true;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}
