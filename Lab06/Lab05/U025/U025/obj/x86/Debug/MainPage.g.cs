﻿#pragma checksum "C:\Users\Pc\Documents\GitHub\UWP-NhuHoangMinhDuc\Lab05\U025\U025\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "60F26251EE5AFA5C17045E94027E0021"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace U025
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
            case 2: // MainPage.xaml line 52
                {
                    this.MyFloutButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 3: // MainPage.xaml line 82
                {
                    this.MyAutoSuggestBox = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.MyAutoSuggestBox).TextChanged += this.MyAutoSuggestBox_TextChanged;
                }
                break;
            case 4: // MainPage.xaml line 54
                {
                    this.Myflyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                }
                break;
            case 5: // MainPage.xaml line 57
                {
                    this.InnerFlyoutButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.InnerFlyoutButton).Click += this.InnerFlyoutbutton_Click;
                }
                break;
            case 6: // MainPage.xaml line 47
                {
                    this.MyClaendarView = (global::Windows.UI.Xaml.Controls.CalendarView)(target);
                    ((global::Windows.UI.Xaml.Controls.CalendarView)this.MyClaendarView).SelectedDatesChanged += this.MyCal;
                }
                break;
            case 7: // MainPage.xaml line 49
                {
                    this.CalTextblock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

