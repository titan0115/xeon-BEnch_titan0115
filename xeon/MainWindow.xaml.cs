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
using System.Runtime;

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
         int TIMES = 0; //для таймера
         double DDrun = 0;
         double POINTS = 0;



        private void bench_Click(object sender, RoutedEventArgs e) //основная грязь
        {
            String tread = Vibor.Text;
            MV.Text = tread;
            int j = Convert.ToInt32(tread);
            int i = 0;
            TIMES = 0;
            block = 0;
            DDrun = 0;
            POINTS = 0;


            TiMers();
            

            while (i != j)
            {
                i++;
                DDoub();
            }
            
        }


        public async void DDoub()  // double
        {
            await Task.Run(() =>
            {
                while (true)
                {

                    
                    DDrun = (DDrun * Math.PI) / 2;

                    


                    if (block == 1)
                    {
                        break;
                    }
                }
            });
        }

        async void LLong()  // long
        {
            await Task.Run(() =>
            {
                while (true)
                {

                    long LLrun = 0;
                    LLrun = LLrun*1*2*LLrun;


                    if (block == 1)
                    {
                        break;
                    }
                }
            });
        }

        async void TiMers()  // таймер(говна)
        {
            
            
                while (true)
                {
                    TIMES++;
                    TimeOC.Text = TIMES.ToString();

                    await Task.Delay(1000);

                    if (block == 1)
                    {
                        break;
                    }
                }
            
        }

        private void Sbross_Click(object sender, RoutedEventArgs e)
        {
            block = 1;
        }
    }
}
