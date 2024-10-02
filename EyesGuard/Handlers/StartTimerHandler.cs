using EyesGuard.ViewModels;

namespace EyesGuard.Handlers;

internal class StartTimerHandler : IButtonHandlerBase
{
    public ViewModelBase ViewModel { get; }

    public StartTimerHandler(ViewModelBase viewModel)
    {
        ViewModel = viewModel;
    }

    public void Execute()
    {
    }
}