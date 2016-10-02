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

namespace DiabetesEssentials
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            DayHeading.Text = "Happy " + DateTime.Today.DayOfWeek + "!";
            ContentFrame.Navigate(typeof(ReadingsInput));
            // MenuSplitView.IsPaneOpen = true;
        }


        private void ListBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (Inputting.IsSelected)
            {

                InputMenuBox.Visibility = Visibility.Visible;

            
            }
            else if (thirty_Day.IsSelected)
            {
                //ContentFrame.Navigate(typeof(_30Day));
                MenuSplitView.IsPaneOpen = false;

                InputMenuBox.Visibility = Visibility.Collapsed;





            }
            else if (Ninety_Day.IsSelected)
            {
                //ContentFrame.Navigate(typeof(_90Day));
                MenuSplitView.IsPaneOpen = false;

            }
            else if (DoctorReports.IsSelected)
            {
                //ContentFrame.Navigate(typeof(DoctorsReport));
                MenuSplitView.IsPaneOpen = false;

            }
            else if (ImportReadings.IsSelected)
            {
                //  ContentFrame.Navigate(typeof(ImportReadings));
                MenuSplitView.IsPaneOpen = false;

            }
            else if (ExportReadings.IsSelected)
            {
                // ContentFrame.Navigate(typeof(ExportReadings));
                MenuSplitView.IsPaneOpen = false;

            }
        }

        private void MainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MenuSplitView.IsPaneOpen = !MenuSplitView.IsPaneOpen;

        }
        private void MainMenu_SizeChanged(object sender, SizeChangedEventArgs e)
        {

            //JL
            double high = e.NewSize.Height; //profile 640
            double wide = e.NewSize.Width;// profile 360
            var q = MainPage.HeightProperty;

            MenuSplitView.Height = high-42;
            //ScrollFace.Height = high - ((high * -.2 ) + 125);
            ScrollFace.Height = high - 200 - (high /10);
            
            
            //MainPager.Width = wide;
            //   NewDay j = (NewDay) ContentFrame


            // ContentFrame.Content;
            /*     if (high > wide) //profile
                 {

                     ScrollFace.Height = high - 10;


                 }else if ( wide > high) // landscape
                 {
                     ScrollFace.Height = high - 10;
                 }
                 */
            }

        private void MinorMenuButton_Click(object sender, RoutedEventArgs e)
        {
            if (InputMenuBox.Visibility == Visibility.Collapsed) InputMenuBox.Visibility = Visibility.Visible; else InputMenuBox.Visibility = Visibility.Collapsed;
        }

        private void InputMenuBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if( Readings.IsSelected )
            {
                ContentFrame.Navigate(typeof(ReadingsInput));

            }
            else if ( Efforts.IsSelected)
            {
                ContentFrame.Navigate(typeof(Efforts));
            }
        }
    }
}

