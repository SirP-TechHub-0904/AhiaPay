namespace AhiaPay.Views;

public partial class BillPaymentConfirmPage : ContentPage
{
	public BillPaymentConfirmPage()
	{
		InitializeComponent();
		BindingContext = new BillPaymentConfirmViewModel();
	}
}