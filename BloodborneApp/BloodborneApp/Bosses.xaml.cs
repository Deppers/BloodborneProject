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
    public sealed partial class Bosses : Page
    {
        public Bosses()
        {
            this.InitializeComponent();
        }

        private void button_Home(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Menu), UriKind.Relative);
        }

        private void button1_ClericBeast(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ClericBeast), UriKind.Relative);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(FatherGascoigne), UriKind.Relative);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(VicarAmelia), UriKind.Relative);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BloodStarvedBeast), UriKind.Relative);
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ShadowOfYharnam), UriKind.Relative);
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(WitchOfHemwick), UriKind.Relative);
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(DarkbeastPaarl), UriKind.Relative);
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Rom), UriKind.Relative);
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OneReborn), UriKind.Relative);
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Micolash), UriKind.Relative);
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Mergo), UriKind.Relative);
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MartyrLorgarius), UriKind.Relative);
        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CelestialEmissary), UriKind.Relative);
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Ebrietas), UriKind.Relative);
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Amygdala), UriKind.Relative);
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Gehrman), UriKind.Relative);
        }

        private void button17_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MoonPresence), UriKind.Relative);
        }

        
    }
}
