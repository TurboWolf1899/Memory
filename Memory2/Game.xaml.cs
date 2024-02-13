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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Memory2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Game : Page
    {
        public Game()
        {
            this.InitializeComponent();
        }

        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
        private void MenuFlyoutItem_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(About));
        }
        private void MenuFlyoutItem_Click_2(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("ms-appx:///Assets/misec.png"));
        }

        private void Image_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("ms-appx:///Assets/zvizda.png"));
        }

        private void Image_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("ms-appx:///Assets/sunce.png"));
        }

        private void Image_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("ms-appx:///Assets/misec.png"));
        }

        private void Image_Tapped_4(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("ms-appx:///Assets/jupiter.png"));
        }

        private void Image_Tapped_5(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("ms-appx:///Assets/zemlja.png"));
        }

        private void Image_Tapped_6(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("ms-appx:///Assets/oblak.png"));
        }

        private void Image_Tapped_7(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("ms-appx:///Assets/mars.png"));
        }

        private void Image_Tapped_8(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("ms-appx:///Assets/jupiter.png"));
        }

        private void Image_Tapped_9(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("ms-appx:///Assets/saturn.png"));
        }

        private void Image_Tapped_10(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("ms-appx:///Assets/oblak.png"));
        }

        private void Image_Tapped_11(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("ms-appx:///Assets/zemlja.png"));
        }

        private void Image_Tapped_12(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("ms-appx:///Assets/mars.png"));
        }

        private void Image_Tapped_13(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("ms-appx:///Assets/sunce.png"));
        }

        private void Image_Tapped_14(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("ms-appx:///Assets/zvizda.png"));
        }

        private void Image_Tapped_15(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("ms-appx:///Assets/saturn.png"));
        }
    }
}
