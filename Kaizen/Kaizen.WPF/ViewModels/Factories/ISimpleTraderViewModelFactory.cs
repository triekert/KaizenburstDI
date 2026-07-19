using Kaiizen.WPF.State.Navigators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kaiizen.WPF.ViewModels.Factories
{
    public interface IKaiizenViewModelFactory
    {
        ViewModelBase CreateViewModel(ViewType viewType);
    }
}
