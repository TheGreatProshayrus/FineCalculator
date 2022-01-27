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

namespace FineCalculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Start_Date;
        string End_Date;
        public MainWindow()
        {
            InitializeComponent();
        }
        public double GetDays(string date1, string date2)
        {
            DateTime start = DateTime.Parse(date1);
            DateTime end = DateTime.Parse(date2);

            return (end - start).TotalDays;
        }
        public void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Start_Date = StartData.SelectedDate.ToString();

        }

        public void DatePicker_SelectedDateChanged_1(object sender, SelectionChangedEventArgs e)
        {
            End_Date = EndData.SelectedDate.ToString();
       
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           double result = GetDays(Start_Date, End_Date);
            MessageBox.Show(result.ToString());
        }
    }
}
