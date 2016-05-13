﻿using Norma.ViewModels.Internal;
using Norma.ViewModels.Tabs;

namespace Norma.ViewModels
{
    internal class SettingsWindowViewModel : ViewModel
    {
        public OptionsTabViewModel OptionsTabViewModel { get; }

        public SettingsWindowViewModel()
        {
            OptionsTabViewModel = new OptionsTabViewModel();
        }
    }
}