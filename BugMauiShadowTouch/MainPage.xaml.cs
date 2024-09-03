using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace BugMauiShadowTouch;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Toast.Make("Image clicked", ToastDuration.Short).Show();
    }

    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        Toast.Make("Image with border clicked", ToastDuration.Short).Show();
    }
}

