﻿using System;
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

namespace instailerJarvis
{
    /// <summary>
    /// Логика взаимодействия для jarvisdalee.xaml
    /// </summary>
    public partial class jarvisdalee : Window
    {
        public jarvisdalee()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Border border = new Border();
            border.Height = 219;
            SecondTextBlock.Text = "Jarvis также поддерживает персонализацию, позволяя настроить его под ваши предпочтения и потребности. Вы можете настроить язык, голос и другие параметры, чтобы Jarvis был максимально удобным для вас";

            // Manually update window height (in case the height doesn't change automatically)
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Border border = new Border();
            border.Height = SecondTextBlock.ActualHeight + 58;
            SecondTextBlock.Text = "С помощью Jarvis вы сможете открывать приложения, выполнить поиск в интернете, управлять музыкой, установить напоминания, создавать и редактировать документы, отправлять электронные письма и многое другое - все это лишь сказав нужную команду вслух. Его голосовые функции позволяют вам выполнить задачи быстро и без усилий";

            // Manually update window height (in case the height doesn't change automatically)
            
        }


        private void otmena(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Border border = new Border();
            border.Height = SecondTextBlock.ActualHeight + 58;
            SecondTextBlock.Text = "С помощью Jarvis вы сможете открывать приложения, выполнить поиск в интернете, управлять музыкой, установить напоминания, создавать и редактировать документы, отправлять электронные письма и многое другое - все это лишь сказав нужную команду вслух. Его голосовые функции позволяют вам выполнить задачи быстро и без усилий";
        }
    }
}
