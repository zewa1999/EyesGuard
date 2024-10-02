using EyesGuard.Models;
using EyesGuard.ViewModels;

namespace EyesGuard.Handlers;

public class ButtonStartHandler : IButtonHandlerBase
{
    public ViewModelBase ViewModel { get; }

    public ButtonStartHandler(ViewModelBase viewModel)
    {
        ViewModel = viewModel;
    }

    public void Execute()
    {
    }
}