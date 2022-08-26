namespace ShareInvest.Pages;

public partial class DetailPage : ContentPage
{
    public DetailPage(Models.CoinCap.Coin coin)
    {
        InitializeComponent();
        TableView.BindingContext = coin;
    }
    void OnClickedBtnUrl(object sender, EventArgs e)
    {
        Navigation.PushAsync(new WebViewPage(BtnUrl.Text));
    }
}