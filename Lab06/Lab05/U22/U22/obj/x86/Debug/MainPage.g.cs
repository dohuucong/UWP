﻿#pragma checksum "C:\Users\Pc\Documents\GitHub\UWP-NhuHoangMinhDuc\Lab05\U22\U22\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A59115CC12936C0C608ED57D6BD59069"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace U22
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 50
                {
                    this.MysplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 3: // MainPage.xaml line 54
                {
                    global::Windows.UI.Xaml.Controls.ListBox element3 = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ListBox)element3).SelectionChanged += this.ListBox_SelectionChanged;
                }
                break;
            case 4: // MainPage.xaml line 56
                {
                    this.Financial = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 5: // MainPage.xaml line 64
                {
                    this.Food = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 6: // MainPage.xaml line 67
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element6 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element6).SelectionChanged += this.TextBlock_SelectionChanged;
                }
                break;
            case 7: // MainPage.xaml line 75
                {
                    this.MyFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 8: // MainPage.xaml line 17
                {
                    this.HumbergerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.HumbergerButton).Click += this.HumbergerButton_Click;
                }
                break;
            case 9: // MainPage.xaml line 24
                {
                    this.BackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BackButton).Click += this.BackButton_Click;
                }
                break;
            case 10: // MainPage.xaml line 32
                {
                    this.TitleTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // MainPage.xaml line 38
                {
                    this.SearchButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 12: // MainPage.xaml line 44
                {
                    this.SearchTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

