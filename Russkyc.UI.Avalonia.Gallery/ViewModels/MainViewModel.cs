using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Russkyc.UI.Avalonia.Gallery.Views.Pages;

namespace Russkyc.UI.Avalonia.Gallery.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private List<object> _pages;

    [ObservableProperty]
    private int _activePageIndex;

    [ObservableProperty]
    private object _activePage;

    public MainViewModel()
    {
        _pages = [
            new ButtonView(),
            new ToggleButtonView(),
            new TextBoxView(),
            new CardView()
        ];
        
        ActivePageIndex = 0;
        ActivePage = _pages[0];
    }

    [RelayCommand]
    void OpenPage(int pageIndex)
    {
        ActivePage = _pages[pageIndex];
        ActivePageIndex = pageIndex;
    }
}