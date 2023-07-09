using EyesGuard.Models;
using EyesGuard.Processes;
using EyesGuard.ViewModels;

namespace EyesGuard.Handlers;

public class ButtonStartHandler : IButtonHandlerBase
{
    public ViewModelBase ViewModel { get; }
    public ConfigurationModel ConfigurationModel { get; }

    public ButtonStartHandler(ViewModelBase viewModel, ConfigurationModel configurationModel)
    {
        ViewModel = viewModel;
        ConfigurationModel = configurationModel;
    }

    public void Execute()
    {
    }
}
