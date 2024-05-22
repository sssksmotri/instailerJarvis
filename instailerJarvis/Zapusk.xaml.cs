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
using System.Windows.Threading;

namespace instailerJarvis
{
    /// <summary>
    /// Логика взаимодействия для Zapusk.xaml
    /// </summary>
    public partial class Zapusk : Window
    {
        private DispatcherTimer _timer;

        public Zapusk()
        {
            InitializeComponent();
            StartProgress();
        }

        private void StartProgress()
        {
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(0.01);
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
            {
                progressBar.Value += 1;
            }
            else
            {
                _timer.Stop();
                NavigateToNextPage();
            }
        }

        private void NavigateToNextPage()
        {
            jarvisdalee jarvisdalee = new jarvisdalee(); // Replace 'NextPage' with your next window/page class
            jarvisdalee.Show();
            this.Close();
        }
    

        
        private void otmena(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
