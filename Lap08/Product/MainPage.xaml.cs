using Product.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Product
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<productClass> Products;

        private ObservableCollection<Contact> Contacts;

        public MainPage()
        {
            this.InitializeComponent();
            Products = new List<productClass>();
            Products.Add(new productClass { ProductPath = "123"});
            Products.Add(new productClass { ProductPath = "abc" });
            //Products.Add(new productClass { ProductPath = "Assets/book3.png" });
            //Products.Add(new productClass { ProductPath = "Assets/book4.jpg" });
            //Products.Add(new productClass { ProductPath = "Assets/book5.jpg" });
            //Products.Add(new productClass { ProductPath = "Assets/book6.jpg" });

            Contacts = new ObservableCollection<Contact>();
        }

        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            string title = ((productClass)TitleCombox.SelectedValue).ProductPath;
            Contacts.Add(new Contact
            {
                Name = NameTextBox.Text,
                Price = PriceTextBox.Text,
                Qty = QtyTextBox.Text,
                Title = title
            }) ;

            NameTextBox.Text = "";
            PriceTextBox.Text = "";
            QtyTextBox.Text = "";
            //TitleTextBox.Text = "";

            NameTextBox.Focus(FocusState.Programmatic);
        }
    }
}
