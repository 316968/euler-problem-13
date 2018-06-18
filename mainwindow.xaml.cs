/* Quinn Parker-Joyes
 * June 15 2018
 * euler problem 13: i added a really really big number and showed the first 10 digits of it
 */



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

namespace eulerProblem13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   //reads text file with all the numbers
        System.IO.StreamReader streamReader = new System.IO.StreamReader("euler100fifty.txt");
        //sum of the big numbers
        double sum;
        //helps read the text file so the sum can add it to itself
        string line;
        // result and result 2 are the same numbers but the replace thing wasnt working so i just made another string and it worked
        string result;
        string result2;

        public MainWindow()
        {
            InitializeComponent();
            // reads each line 
            while((line = streamReader.ReadLine()) != null)
            {   //adds the line to the sum
                sum += double.Parse(line);
            }
            streamReader.Close();
            //converts the sum to a string
            result = sum.ToString();
            //removes the decimal point because it has the giant number as 5.whatever to the power of something, so i had to remove the decimal point
            result2 = result.Replace(".", "");
            //i used substring to show the first ten digits
            MessageBox.Show(result2.Substring(0, 10));
        }
    }
}
