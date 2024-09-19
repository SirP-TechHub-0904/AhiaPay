namespace AhiaPay.Views;
public partial class AllServicePage : ContentPage
{
	public AllServicePage()
	{
		InitializeComponent();
		BindingContext = new AllServiceViewModel();
    }
}