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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DiabetesSolutions
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ContentFrame.Navigate(typeof(NewDay));
        }

        private void ListBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (NewDay.IsSelected)
            {

                ContentFrame.Navigate(typeof(NewDay));
                MenuSplitView.IsPaneOpen = false;


            }
            else if (thirty_Day.IsSelected)
            {
                ContentFrame.Navigate(typeof(_30Day));
                MenuSplitView.IsPaneOpen = false;

            }
            else if (Ninety_Day.IsSelected)
            {
                ContentFrame.Navigate(typeof(_90Day));
                MenuSplitView.IsPaneOpen = false;

            }
            else if (DoctorReports.IsSelected)
            {
                ContentFrame.Navigate(typeof(DoctorsReport));
                MenuSplitView.IsPaneOpen = false;

            }
            else if (ImportReadings.IsSelected)
            {
                ContentFrame.Navigate(typeof(ImportReadings));
                MenuSplitView.IsPaneOpen = false;

            }
            else if (ExportReadings.IsSelected)
            {
                ContentFrame.Navigate(typeof(ExportReadings));
                MenuSplitView.IsPaneOpen = false;

            }
        }

        private void MainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MenuSplitView.IsPaneOpen = !MenuSplitView.IsPaneOpen;

        }
    }
}
