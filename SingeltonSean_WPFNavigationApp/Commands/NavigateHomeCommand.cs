/*
*----------------------------------------------------------------------------------
*          Filename:	NavigateHomeCommand.cs
*          Date:        2023.07.25
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using SingeltonSean_WPFNavigationApp.Stores;
using SingeltonSean_WPFNavigationApp.ViewModels;

namespace SingeltonSean_WPFNavigationApp.Commands;

public class NavigateHomeCommand : CommandBase
{
    #region Fields

    private readonly NavigationStore _navigationStore;
    
    #endregion

    #region Constructor
    public NavigateHomeCommand(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
    }
    #endregion

    #region Commands

    public override void Execute(object? parameter)
    {
        _navigationStore.CurrentViewModel = new HomeViewModel(_navigationStore);
    }
    #endregion
}