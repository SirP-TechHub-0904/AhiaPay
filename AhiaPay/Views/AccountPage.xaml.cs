namespace AhiaPay.Views;

public partial class AccountPage : ContentPage
{
    public AccountPage()
    {
        InitializeComponent();
        BindingContext = new AccountViewModel();
    }
}