using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Display.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace U31
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CoffeePage : Page
    {
        public CoffeePage()
        {
            this.InitializeComponent();
        }
        private string _roast;
        private string _Cream;
        private string _Sweetener;
        private void Roast_Click(object sender, RoutedEventArgs e)
        {
            var Slt = (MenuFlyoutItem)sender;
            _roast = Slt.Text;
            DisplayResult();
        }

        private void Cream_Click(object sender, RoutedEventArgs e)
        {
            var Slt = (MenuFlyoutItem)sender;
            _Cream = Slt.Text;
            DisplayResult();
        }

        private void Sweetener_Click(object sender, RoutedEventArgs e)
        {
            var Slt = (MenuFlyoutItem)sender;
            _Sweetener = Slt.Text;
            DisplayResult();
        }
        
        private void DisplayResult()
        {
            if(_roast == "None" || String.IsNullOrEmpty(_roast))
            {
                ResultextBlock.Text = "None"; return;
            }
            ResultextBlock.Text = _roast;
            if (_Cream == "None" && String.IsNullOrEmpty(_Cream))
            {
                ResultextBlock.Text += " +"+ _Cream;
            }
            if (_Sweetener == "None" &&  !String.IsNullOrEmpty(_Sweetener))
            {
                ResultextBlock.Text += " +"+ _Sweetener;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
