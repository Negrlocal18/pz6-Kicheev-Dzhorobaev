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

namespace prt2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int number;
            number = Convert.ToInt32(NumberInput .Text);

            int firstThreeDigitsSum = (number / 100000) + (number / 10000) % 10 + (number / 1000) % 10;
            int lastThreeDigitsSum = (number % 10) + (number / 100) % 10 + (number / 10) % 10;
            if (firstThreeDigitsSum == lastThreeDigitsSum) 
            
           {
                ResultLabel.Content = "сумма первых трёх цифр равна сумме последних трёх цифр";

            }
            else
            {
                ResultLabel.Content = "сумма первых трёх цифр не ровна сумме последних трёх цифр";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           Window2 Window2 = new Window2();
            Window2.Show();
            this.Close();
        }
    }
}
