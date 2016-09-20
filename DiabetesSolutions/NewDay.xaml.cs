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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DiabetesSolutions
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NewDay : Page
    {
        Frame ContentFrame;

        public NewDay()
        {
            this.InitializeComponent();
            DayHeading.Text = "Happy " + DateTime.Today.DayOfWeek + "!";
            ContentFrame = (Frame)this.Parent;
           
        }

        private void Readings_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            int j;
            if (!Int32.TryParse(sender.Text, out j))
            {
                System.Diagnostics.Debug.WriteLine(j + "is not an int");
                sender.Text = "";
            }
            else
            {
                System.Diagnostics.Debug.WriteLine(j + "not an int");
            }

        }
        /*private void ListBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
          /*  if (NewDay.IsSelected)
            {

                ContentFrame.Navigate(typeof(NewDay));
                MenuSplitView.IsPaneOpen = false;


            }
            else 
          
            
            if (thirty_Day.IsSelected)
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

        }*/

    }
    }

