/*
*----------------------------------------------------------------------------------
*          Filename:	NavigateAccountCommand.cs
*          Date:        2023.07.25
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using System;
using SingeltonSean_WPFNavigationApp.Stores;
using SingeltonSean_WPFNavigationApp.ViewModels;

namespace SingeltonSean_WPFNavigationApp.Commands;

public class NavigateCommand<TViewModel> : CommandBase
where TViewModel : ViewModelBase
{
    #region Fields

    private readonly NavigationStore _navigationStore;
    private readonly Func<TViewModel> _createViewModel;

    #endregion

    #region Constructor
    public NavigateCommand(NavigationStore navigationStore, Func<TViewModel> createViewModel)
    {
        _navigationStore = navigationStore;
        _createViewModel = createViewModel;
    }
    #endregion

    #region Commands

    public override void Execute(object? parameter)
    {
        _navigationStore.CurrentViewModel = _createViewModel();
    }
    #endregion
}