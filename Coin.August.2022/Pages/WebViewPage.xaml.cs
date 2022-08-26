namespace ShareInvest.Pages;

public partial class WebViewPage : ContentPage
{
    public WebViewPage(string url)
    {
        InitializeComponent();
        WebView.Source = url;
    }
}