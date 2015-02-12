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
using System.Windows.Ink;

namespace ToDo2
{
    /// <summary>
    /// ToDo2 created by OliPicard.
    /// Full Sourcecode @ github.com/olipicard
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int debian {get; set;} //global int
        public string ubuntu { get; set;} //global string 
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void execute_Click(object sender, RoutedEventArgs e)
        {
            debian++; //incrementing the Int for the switch.

            switch (debian)
            {
                case 1:
                    if (input.Text == null || string.IsNullOrWhiteSpace(input.Text))
                    {
                        MessageBox.Show("Whoops! Please enter in a todo job.");
                        debian = 0;
                    }
                    boxOne.Text = input.Text; //taking input from texbox moving it over to a label.
                    break;
                case 2:
                    if (input.Text == null || string.IsNullOrWhiteSpace(input.Text))
                    {
                        MessageBox.Show("Whoops! Please enter in a todo job.");
                        debian = 1;
                    }
                    boxTwo.Text = input.Text;
                    break;
                case 3:
                    if (input.Text == null || string.IsNullOrWhiteSpace(input.Text))
                    {
                        MessageBox.Show("Whoops! Please enter in a todo job.");
                        debian = 2;
                    }
                    boxThree.Text = input.Text;
                    break;
                case 4:
                    if (input.Text == null || string.IsNullOrWhiteSpace(input.Text))
                    {
                        MessageBox.Show("Whoops! Please enter in a todo job.");
                        debian = 3;
                    }
                    boxFour.Text = input.Text;
                    break;
                case 5:
                    if (input.Text == null || string.IsNullOrWhiteSpace(input.Text))
                    {
                        MessageBox.Show("Whoops! Please enter in a todo job.");
                        debian = 4;
                    }
                    boxFive.Text = input.Text;
                    break;
            }
            input.Text = "";
            if (debian == 5)
            {
                execute.IsEnabled = false;
            }
            
        }
        private void Button_Click(object sender, RoutedEventArgs e) //reset
        {
            debian = 0;
            boxOne.Text = "";
            boxOne.Foreground = new SolidColorBrush(Colors.Black);
            chkOne.IsChecked = false;
            boxTwo.Text = "";
            boxTwo.Foreground = new SolidColorBrush(Colors.Black);
            chkTwo.IsChecked = false;
            boxThree.Text = "";
            boxThree.Foreground = new SolidColorBrush(Colors.Black);
            chkThree.IsChecked = false;
            boxFour.Text = "";
            boxFour.Foreground = new SolidColorBrush(Colors.Black);
            chkFour.IsChecked = false;
            boxFive.Text = "";
            boxFive.Foreground = new SolidColorBrush(Colors.Black);
            chkFive.IsEnabled = false;
            execute.IsEnabled = true;
        }

        private void chkOneEvent(object sender, RoutedEventArgs e) //ChkBox One set new color.
        {
            boxOne.Foreground = new SolidColorBrush(Colors.Gray);
        }

        private void ChkOneReload(object sender, RoutedEventArgs e) //ChkBox One revert to default color.
        {
            boxOne.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void chkTwoEvent(object sender, RoutedEventArgs e)
        {
            boxTwo.Foreground = new SolidColorBrush(Colors.Gray);
        }

        private void chkTwoReload(object sender, RoutedEventArgs e)
        {
            boxTwo.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void chkThreeEvent(object sender, RoutedEventArgs e)
        {
            boxThree.Foreground = new SolidColorBrush(Colors.Gray);
        }

        private void chkThreeReload(object sender, RoutedEventArgs e)
        {
            boxThree.Foreground = new SolidColorBrush(Colors.Black);
        }
        private void chkfourEvent(object sender, RoutedEventArgs e) //if user pressed on tickbox, text turns gray.
        {
            boxFour.Foreground = new SolidColorBrush(Colors.Gray);
        }

        private void chkfourrollback(object sender, RoutedEventArgs e) //if user unticks the tickbox. text turns black.
        {
            boxFour.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void chkFiveEvent(object sender, RoutedEventArgs e)
        {
            boxFive.Foreground = new SolidColorBrush(Colors.Gray);
        }
        private void chkFiveReload(object sender, RoutedEventArgs e)
        {
            boxFive.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void Source(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/OliPicard/ToDo2");
        }

    }
}
