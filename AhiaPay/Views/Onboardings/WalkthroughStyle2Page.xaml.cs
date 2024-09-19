using AhiaPay.ViewModels.Onboardings;

namespace AhiaPay.Views.Onboardings;

public partial class WalkthroughStyle2Page : ContentPage
{
	public WalkthroughStyle2Page()
	{
		InitializeComponent();
		BindingContext = new WalkthroughStyle2ViewModel(Navigation, this);

    }
}