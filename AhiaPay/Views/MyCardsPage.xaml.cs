namespace AhiaPay.Views;

public partial class MyCardsPage : ContentPage
{
	public MyCardsPage()
	{
		InitializeComponent();
        BindingContext = new MyCardsViewModel();
    }
}