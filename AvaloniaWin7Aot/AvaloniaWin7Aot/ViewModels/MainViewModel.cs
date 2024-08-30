using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaWin7Aot.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _greeting = "Welcome to Avalonia!";
}
