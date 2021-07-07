using System;

using System.Windows;
using System.Windows.Controls;


namespace Calendar_Challenge
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string daysbetween;
        public DateTime date1, date2;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rlabel.Content = daysbetween;
            BlackoutDates(date1, date2);
            int diff = (date2 - date1).Days;
            rlabel.Content = diff;

        }

        private void BlackoutDates(DateTime date1, DateTime date2)
        {
            calendar3.BlackoutDates.Clear();
            calendar3.BlackoutDates.Add(new CalendarDateRange(date1, date2));
        }
        //Date 1 is good
        public void cldr1_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            date1 = cldr1.SelectedDate.Value;
            lb1.Content = date1.ToString();

        }
        //Date 2 can only work for a certain amount of months
        private void cldr2_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            date2 = cldr2.SelectedDate.Value;
            lb2.Content = date2.ToString();
        }
    }
}
