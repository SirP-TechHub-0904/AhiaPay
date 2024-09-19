using AhiaPay.ViewModels.Onboardings;

namespace AhiaPay.Views.Onboardings;

public partial class WalkthroughAnimationPage : ContentPage
{
	public WalkthroughAnimationPage()
	{
		InitializeComponent();
		BindingContext = new WalkthroughAnimationViewModel(Navigation, this);
		
    }
}