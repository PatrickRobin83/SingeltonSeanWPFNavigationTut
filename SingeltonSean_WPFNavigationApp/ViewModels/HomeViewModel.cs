/*
*----------------------------------------------------------------------------------
*          Filename:	HomeViewModel.cs
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

public class HomeViewModel : ViewModelBase
{
    #region Fields

    #endregion

    #region Properties

    public string WelcomMessage => "Welcome to my Application";

    #endregion

    #region Constructor

    public HomeViewModel(NavigationStore navigationStore)
    {
        NavigateAccountCommand = new NavigateCommand<AccountViewModel>(navigationStore, () => new AccountViewModel(navigationStore));
    }

    #endregion

    #region Methods

    #endregion

    #region Commands

    public ICommand NavigateAccountCommand { get; }



    #endregion
}