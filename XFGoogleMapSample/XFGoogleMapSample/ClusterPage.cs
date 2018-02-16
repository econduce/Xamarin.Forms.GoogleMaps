using System;

using Xamarin.Forms;

namespace XFGoogleMapSample
{
    public class ClusterPage : ContentPage
    {
        public ClusterPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

