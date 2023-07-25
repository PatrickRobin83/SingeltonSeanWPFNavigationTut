/*
*----------------------------------------------------------------------------------
*          Filename:	NavigationStore.cs
*          Date:        2023.07.25
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using System;
using SingeltonSean_WPFNavigationApp.ViewModels;

namespace SingeltonSean_WPFNavigationApp.Stores;

public class NavigationStore
{
    #region Fields

    private ViewModelBase _currenViewModel;

    #endregion
    #region Properties

    public ViewModelBase CurrentViewModel
    {
        get => _currenViewModel;
        set
        {
            _currenViewModel = value;
            OnCurrentViewModelChanged();
        }
    }
    #endregion

    public event Action CurrentViewModelChanged;
    
    private void OnCurrentViewModelChanged()
    {
        CurrentViewModelChanged?.Invoke();
    }
}
