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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hrdy_20231025
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            selector.SelectedIndex = 0;
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (selector.SelectedIndex == 1)
            {
                inputC.Visibility = Visibility.Hidden;
                inputB.Visibility = Visibility.Visible;
                inputA.Visibility = Visibility.Visible;
                labelA.Visibility = Visibility.Visible;
                labelB.Visibility = Visibility.Visible;
                labelC.Visibility = Visibility.Hidden;
                cmA.Visibility = Visibility.Visible;
                cmB.Visibility = Visibility.Visible;
                cmC.Visibility = Visibility.Hidden;
            }
            else
            {
                inputA.Visibility = Visibility.Visible;
                inputB.Visibility = Visibility.Visible;
                inputC.Visibility = Visibility.Visible;
                labelA.Visibility = Visibility.Visible;
                labelB.Visibility = Visibility.Visible;
                labelC.Visibility = Visibility.Visible;
                cmA.Visibility = Visibility.Visible;
                cmB.Visibility = Visibility.Visible;
                cmC.Visibility = Visibility.Visible;
            }
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c;
            double s;
            double obsah;
            try
            {
                if(selector.SelectedIndex == 0)
                {
                    a = double.Parse(inputA.Text);
                    b = double.Parse(inputB.Text);
                    c = double.Parse(inputC.Text);
                    s = (a + b + c) / 2;
                    obsah = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                    output.Content = $"obsah trojúhelníku je {obsah}";
                }
                else
                {
                    a = double.Parse(inputA.Text);
                    b = double.Parse(inputB.Text);
                    obsah = a * b;
                    output.Content = $"obsah obdélníku je {obsah}";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ŠPATNĚ ZADANÉ HODNOTY! - {ex.Message}");
            }

            
        }
    }
}
