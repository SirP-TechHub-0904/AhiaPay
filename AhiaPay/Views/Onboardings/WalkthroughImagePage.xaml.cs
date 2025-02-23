using AhiaPay.ViewModels.Onboardings;

namespace AhiaPay.Views.Onboardings;

public partial class WalkthroughImagePage : ContentPage
{
	public WalkthroughImagePage()
	{
		InitializeComponent();
		BindingContext = new WalkthroughImageViewModel(Navigation, this);
    }

    protected override async void OnAppearing()
	{
        base.OnAppearing();
    }
}