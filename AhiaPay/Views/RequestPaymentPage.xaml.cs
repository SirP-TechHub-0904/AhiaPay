namespace AhiaPay.Views;

public partial class RequestPaymentPage : ContentPage
{
	public RequestPaymentPage()
	{
		InitializeComponent();
		BindingContext = new RequestPaymentViewModel();

    }
}