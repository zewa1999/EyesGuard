using EyesGuard.Models;
using EyesGuard.ViewModels;

namespace EyesGuard.Handlers;

public interface IButtonHandlerBase
{
    public ViewModelBase ViewModel { get; }

    public abstract void Execute();
}