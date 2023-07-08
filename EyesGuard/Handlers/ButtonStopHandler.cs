using EyesGuard.Models;
using EyesGuard.ViewModels;

namespace EyesGuard.Commands;

internal class ButtonStopHandler : IButtonHandlerBase
{
    public ViewModelBase ViewModel { get; }
    public ConfigurationModel ConfigurationModel { get; }

    public ButtonStopHandler(ViewModelBase viewModel, ConfigurationModel contractModel)
    {
        ViewModel = viewModel;
        ConfigurationModel = contractModel;
    }

    public void Execute()
    {
    }
}
