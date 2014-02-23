﻿using System.Collections.ObjectModel;
using Chocolatey.Gui.ViewModels.Items;

namespace Chocolatey.Gui.ViewModels.Controls
{
    public interface ISourcesControlViewModel
    {
        ObservableCollection<SourceTabViewModel> Sources { get; set; } 
    }
}
