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

namespace xeon
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int block = 0;
        private void bench_Click(object sender, RoutedEventArgs e)
        {
            String tread = Vibor.Text;
            MV.Text = tread;
            int j = Convert.ToInt32(tread);
            int i = 0;


            while (i != j)
            {
                i++;
                ras();
            }
        }

        async void ras()
        {
            await Task.Run(() =>
            {
                while (true)
                {

                    double runn = 0;
                    runn = ((runn + 1) / 2 * 3) * Math.PI;
                    runn = ((runn + 1) / 2 * 3) * Math.PI;
                    runn = ((runn + 1) / 2 * 3) * Math.PI;
                    runn = ((runn + 1) / 2 * 3) * Math.PI;
                    runn = ((runn + 1) / 2 * 3) * Math.PI;
                    runn = ((runn + 1) / 2 * 3) * Math.PI;

                    if(block == 1)
                    {
                        break;
                    }
                }
            });
        }

        private void Sbross_Click(object sender, RoutedEventArgs e)
        {
            block = 1;
        }
    }
}
