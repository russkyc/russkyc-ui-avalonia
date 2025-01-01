using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Russkyc.UI.Avalonia.Gallery.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private object _activePage;

    [RelayCommand]
    void OpenPage(object page)
    {
        ActivePage = page;
    }
}