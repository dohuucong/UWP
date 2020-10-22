using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace U025
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private void MyCal(CalendarView sender, CalendarDatePickerDateChangedEventArgs args)
        {
            var selectDates = sender.SelectedDates.Select(p => p.Date.Month.ToString() + " / " + p.Date.Day.ToString()).ToArray();
            var Vl = string.Join(", ", selectDates);
            CalTextblock.Text = Vl;
        }

        private void InnerFlyoutbutton_Click(object sender, RoutedEventArgs e)
        {
            Myflyout.Hide();
        }
        private string[] selectionItems = new string[]
            {"Ferdcc", "Frak", "Frak","Frak","Frak","Frak","Frak","Frak","Frak"};
        
        private void MyAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            var autoSuggestBox = (AutoSuggestBox)sender;
            var filtered = selectionItems.Where(p => p.StartsWith(autoSuggestBox.Text)).ToArray();
            autoSuggestBox.ItemsSource = filtered;
        }
    }
}
