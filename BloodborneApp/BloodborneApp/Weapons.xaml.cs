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
    public sealed partial class Weapons : Page
    {
        public Weapons()
        {
            this.InitializeComponent();
        }

        private void button_Home(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Menu), UriKind.Relative);
        }

        private void button_BeastClaw(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BeastClaw), UriKind.Relative);
        }

        private void button_BurialBlade(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BurialBlade), UriKind.Relative);
        }

        private void button_BOM(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BladeOfMercy), UriKind.Relative);
        }

        private void button_Chikage(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Chikage), UriKind.Relative);
        }

        private void button_HunterAxe(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HunterAxe), UriKind.Relative);
        }

        private void button_Kirkhammer(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Kirkhammer), UriKind.Relative);
        }

        private void button_LorgariusWheel(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(LogariusWheel), UriKind.Relative);
        }

        private void button_LudwigFTW(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(LudwigsHolyBlade), UriKind.Relative);
        }

        private void button_Reiterspallach(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Reiterspallach), UriKind.Relative);
        }

        private void button_RifleSpear(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RifleSpear), UriKind.Relative);
        }

        private void button_SawCleaver(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SawCleaver), UriKind.Relative);
        }

        private void button_SawSpear(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SawSpear), UriKind.Relative);
        }

        private void button_StakeDriver(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(StakeDriver), UriKind.Relative);
        }

        private void button_ThreadedCane(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ThreadedCane), UriKind.Relative);
        }

        private void button_Tonitrus(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Tonitrus), UriKind.Relative);
        }

        private void button_UncannyLost(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(UncannyLost), UriKind.Relative);
        }

    }
}
