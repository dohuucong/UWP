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

namespace U20
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
        private void MyCheckBox_Tapped(object sender, TappedRoutedEventArgs a)
        {
            CheckBoxResulttextBlock.Text = MyCheckBox.IsChecked.ToString();
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButtonTextBlock.Text = (bool)YesRadioButton.IsChecked ? "yes" : "No";
        }
        private void ComBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxResulttextBlock == null) return;
            var combo = (ComboBox)sender;
            var item = (ComboBoxItem)combo.SelectedItem;
            ComboBoxResulttextBlock.Text = item.Content.ToString();
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var seletItems = MyListBox.Items.Cast<ListBoxItem>()
                .Where(p => p.IsSelected)
                .Select(t => t.Content.ToString())
                .ToArray();
            ListoxResultTextBlock.Text = string.Join(", ", seletItems);
        }
        private void MytoggleButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleButtonResultTextBlock.Text = MyButtonToggle.IsChecked.ToString();
        }

        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {

        }
    }
}
