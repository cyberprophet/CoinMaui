namespace ShareInvest.Pages
{
    public partial class CoinCap : ContentPage
    {
        public CoinCap() => InitializeComponent();
        protected override async void OnAppearing()
        {
            CoinView.ItemsSource = await Interface.CoinCap.API.GetCoinsAsync();
            base.OnAppearing();
        }
        void OnChangedCoinView(object sender, SelectionChangedEventArgs e)
        {
            var coin = CoinView.SelectedItem as Models.CoinCap.Coin;
            Navigation.PushAsync(new DetailPage(coin));
        }
    }
}