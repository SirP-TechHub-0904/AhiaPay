namespace AhiaPay.ViewModels;

public partial class BillPaymentViewModel : ObservableObject
{
    public BillPaymentViewModel()
    {

    }

    [RelayCommand]
    private async void PayNow()
    {
        await Shell.Current.GoToAsync(nameof(BillPaymentConfirmPage));
    }
}
