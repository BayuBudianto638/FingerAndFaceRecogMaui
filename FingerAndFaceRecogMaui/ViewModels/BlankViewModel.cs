using FingerAndFaceRecogMaui.Services.FingerPrintService;

namespace FingerAndFaceRecogMaui.ViewModels;

public partial class BlankViewModel : BaseViewModel, INotifyPropertyChanged
{
    private readonly FingerPrintAppService _fingerPrintService;
    public IAsyncRelayCommand LoginCommand { get; }

    public BlankViewModel(FingerPrintAppService fingerPrintService)
    {
        _fingerPrintService = fingerPrintService;
    }

    private bool _isBiometricsAvailable;
    public bool IsBiometricsAvailable
    {
        get => _isBiometricsAvailable;
        set => SetProperty(ref _isBiometricsAvailable, value);
    }

    private async Task LoginAsync()
    {
        // Your login logic
        var isAuthenticated = await _fingerPrintService.LoginASync();

        // Handle the authentication result as needed
    }
}
