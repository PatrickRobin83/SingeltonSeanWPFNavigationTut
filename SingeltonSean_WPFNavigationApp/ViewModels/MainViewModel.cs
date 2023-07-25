/*
*----------------------------------------------------------------------------------
*          Filename:	MainViewModel.cs
*          Date:        2023.07.25
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using SingeltonSean_WPFNavigationApp.Stores;

namespace SingeltonSean_WPFNavigationApp.ViewModels;

public class MainViewModel : ViewModelBase
{
    private readonly NavigationStore _navigationStore;
    public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;

    public MainViewModel(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
        _navigationStore.CurrentViewModelChanged += OnCurrenViewModelChanged;
    }

    private void OnCurrenViewModelChanged()
    {
        OnPropertyChanged(nameof(CurrentViewModel));
    }
}