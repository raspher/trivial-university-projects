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

using OxyPlot;

namespace lista4zad3
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Title { get; private set; }

        public IList<DataPoint> PointsFx { get; private set; }
        public IList<DataPoint> PointsFy { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            this.PointsFx = new List<DataPoint>();
            this.PointsFy = new List<DataPoint>(); ;

            this.DataContext = this;
        }

        private void axisXY_TextChanged(object sender, TextChangedEventArgs e)
        {
            PointsFx.Clear();
            PointsFy.Clear();
            try {
                int points = int.Parse(HowMany.Text);
                for (int i = 0; i < points; i++)
                {
                    PointsFx.Add(new DataPoint(i, double.Parse(axisA.Text) * i * i));
                    PointsFy.Add(new DataPoint(i, double.Parse(axisA.Text)*i + double.Parse(axisB.Text)));
                }
            }
            catch { }

            Czart.InvalidatePlot(true);

            
        }
    }
}
