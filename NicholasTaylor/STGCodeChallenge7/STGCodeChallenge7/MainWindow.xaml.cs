using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace STGCodeChallenge7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtTextToProcess.Text = "0-7475-3269-9";
        }

        private void btnValidate_Click_1(object sender, RoutedEventArgs e)
        {
            if (validateISBN(txtTextToProcess.Text))
            {
                lblFinal.Foreground = Brushes.Green;
                lblFinal.Content = "Valid";
            }
            else
            {
                lblFinal.Foreground = Brushes.Red;
                lblFinal.Content = "Invalid";
            }
        }

        private bool validateISBN(string ISBN)
        {
            ISBN = Regex.Replace(ISBN.Replace("-", ""), @"\s", ""); //remove hyphens and whitespace
            string firstStepValidationPattern = @"[0-9]{9,10}[xX]*";
            if (ISBN.Length == 10 && Regex.Match(ISBN, firstStepValidationPattern).Success)
            {
                string numberPattern = @"(\d|[xX])"; //split the given text by groups of whole numbers (positive or negative) and letters.
                string[] splitText = Regex.Split(ISBN, numberPattern);
                List<int> numbers = new List<int>();
                foreach (string piece in splitText)
                {
                    if (Regex.Match(piece, "^" + @"(-\d+|\d+)" + "$").Success) //A number (positive or negative)
                    {
                        numbers.Add(int.Parse(piece));
                        
                    }
                    else if (Regex.Match(piece, "^" + "[xX]+" + "$").Success) //A letter
                    {
                        numbers.Add(10);
                    }
                }
                int sum = 0;
                for (int index = 0; index < 10; index++)
                {
                    sum += numbers[index] * (10 - index);
                }
                return sum % 11 == 0;
            }
            return false;
        }
    }
}
