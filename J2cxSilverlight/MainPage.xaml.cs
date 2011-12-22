using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

using System.Windows.Controls.Theming;
using System.Threading;

namespace J2cxSilverlight
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            label1.Visibility = Visibility.Visible;
            myStoryboard.Begin();
            myStoryboard.Completed += new EventHandler(myStoryboard_Completed);

        }

        private void myStoryboard_Completed(object sender, EventArgs e)
        {
            label2.Visibility = Visibility.Visible;
            myStoryboard2.Begin();
            myStoryboard2.Completed += new EventHandler(myStoryboard2_Completed);
        }

        private void myStoryboard2_Completed(object sender, EventArgs e)
        {
            label3.Visibility = Visibility.Visible;
            myStoryboard3.Begin();
            myStoryboard3.Completed += new EventHandler(myStoryboard3_Completed);
        }
        private void myStoryboard3_Completed(object sender, EventArgs e)
        {
            myStoryboardFake.Begin();
            myStoryboardFake.Completed += new EventHandler(myStoryboardFake_Completed);
        }
        private void myStoryboardFake_Completed(object sender, EventArgs e)
        {
            Uri myuri = new Uri("/Page1.xaml", UriKind.RelativeOrAbsolute);
            //myframe.Navigate(myuri);
            //System.Windows.Browser.HtmlPage.Window.Navigate(myuri);
            this.myframe.Navigate(myuri);
            //Console.WriteLine(myuri.ToString());
            //myframe.Navigate(myuri);
        }

    }
}
