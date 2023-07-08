using EyesGuard.Models;
using EyesGuard.ViewModels;

namespace EyesGuard.Commands;

public class ButtonStartHandler : IButtonHandlerBase
{
    public ViewModelBase ViewModel { get; }
    public ConfigurationModel ConfigurationModel { get; }

    public ButtonStartHandler(ViewModelBase viewModel, ConfigurationModel contractModel)
    {
        ViewModel = viewModel;
        ConfigurationModel = contractModel;
    }

    public void Execute()
    {
        System.Console.WriteLine("cacat");
    }
}
