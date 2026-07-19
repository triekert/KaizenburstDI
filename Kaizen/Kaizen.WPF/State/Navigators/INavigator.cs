using Kaiizen.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Kaiizen.WPF.State.Navigators
{
    public enum ViewType
    {
        Login,
        Home,
        Portfolio,
        Buy,
        Sell
    }

    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
        event Action StateChanged;
    }
}
