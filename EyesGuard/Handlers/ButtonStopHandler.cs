using EyesGuard.Models;
using EyesGuard.ViewModels;

namespace EyesGuard.Handlers;

internal class ButtonStopHandler : IButtonHandlerBase
{
    public ViewModelBase ViewModel { get; }
    public ConfigurationModel ConfigurationModel { get; }

    public ButtonStopHandler(ViewModelBase viewModel, ConfigurationModel configurationModel)
    {
        ViewModel = viewModel;
        ConfigurationModel = configurationModel;
    }

    public void Execute()
    {
    }
}
