using Kaiizen.FinancialModelingPrepAPI.Services;
using Kaiizen.WPF.State.Navigators;
using Kaiizen.WPF.ViewModels;
using Kaiizen.WPF.ViewModels.Factories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Kaiizen.WPF.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly INavigator _navigator;
        private readonly IKaiizenViewModelFactory _viewModelFactory;

        public UpdateCurrentViewModelCommand(INavigator navigator, IKaiizenViewModelFactory viewModelFactory)
        {
            _navigator = navigator;
            _viewModelFactory = viewModelFactory;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;

                _navigator.CurrentViewModel = _viewModelFactory.CreateViewModel(viewType);
            }
        }
    }
}