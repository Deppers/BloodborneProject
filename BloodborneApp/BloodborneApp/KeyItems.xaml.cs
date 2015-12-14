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

namespace BloodborneApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class KeyItems : Page
    {
        public KeyItems()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Menu), UriKind.Relative);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CainhurstBadge), UriKind.Relative);
        }

        private void button1_Copy_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CosmicBadge), UriKind.Relative);
        }

        private void button1_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CrowBadge), UriKind.Relative);
        }

        private void button1_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(FiringBadge), UriKind.Relative);
        }

        private void button1_Copy3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OldHunterBadge), UriKind.Relative);
        }

        private void button1_Copy4_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PowderKHBadge), UriKind.Relative);
        }

        private void button1_Copy5_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RadiantBadge), UriKind.Relative);
        }

        private void button1_Copy6_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SawBadge), UriKind.Relative);
        }

        private void button1_Copy7_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SparkBadge), UriKind.Relative);
        }

        private void button1_Copy8_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SwordHunterBadge), UriKind.Relative);
        }

        private void button1_Copy9_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(WheelBadge), UriKind.Relative);
        }
    }
}
