namespace AhiaPay.Views;

public partial class MobileTopupPage : ContentPage
{
	public MobileTopupPage()
	{
		InitializeComponent();
		BindingContext = new MobileTopupViewModel();

    }
}