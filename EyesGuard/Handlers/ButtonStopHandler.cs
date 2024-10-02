using EyesGuard.Models;
using EyesGuard.ViewModels;

namespace EyesGuard.Handlers;

internal class ButtonStopHandler : IButtonHandlerBase
{
    public ViewModelBase ViewModel { get; }

    public ButtonStopHandler(ViewModelBase viewModel)
    {
        ViewModel = viewModel;
    }

    public void Execute()
    {
    }
}