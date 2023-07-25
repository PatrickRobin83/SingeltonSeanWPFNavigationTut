/*
*----------------------------------------------------------------------------------
*          Filename:	AccountViewModel.cs
*          Date:        2023.07.25
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using System.Windows.Input;
using SingeltonSean_WPFNavigationApp.Commands;
using SingeltonSean_WPFNavigationApp.Stores;

namespace SingeltonSean_WPFNavigationApp.ViewModels;

public class AccountViewModel : ViewModelBase
{
    #region Properties

    public string Name => "Patrick Robin";
    #endregion

    #region Constructor

    public AccountViewModel(NavigationStore navigationStore)
    {
        NavigateHomeCommand = new NavigateCommand<HomeViewModel>(navigationStore, () => new HomeViewModel(navigationStore));
    }
    #endregion


    #region Commands

    public ICommand NavigateHomeCommand { get; }

    #endregion
}