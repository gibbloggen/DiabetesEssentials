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

namespace DiabetesEssentials
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
                System.Diagnostics.Debug.WriteLine(j + " j is an int");
                sender.Text = j.ToString();
                System.Diagnostics.Debug.WriteLine(sender.Name);
            }

        }
        private void NewDay_SizeChanged(object sender, SizeChangedEventArgs e)
        {

            //JL
            double high = e.NewSize.Height; //profile 640
            double wide = e.NewSize.Width;// profile 360
            Frame j = (Frame) this.Parent;
            Border k = (Border)j.Parent;
            Grid l = (Grid) k.Parent;
            Grid m = (Grid) l.Parent;
            double wider = m.ActualWidth;
            double higher = m.ActualHeight;
            var n = m.Parent;

            ScrollFace.Height = high - 110;
          //  NewDayMain.Width = wider + 30 ;
           // ScrollFace.Width = wider - 10
            
            /*     if (high > wide) //profile
                 {

                     ScrollFace.Height = high - 10;


                 }else if ( wide > high) // landscape
                 {
                     ScrollFace.Height = high - 10;
                 }
                 */
        }
    }
}


