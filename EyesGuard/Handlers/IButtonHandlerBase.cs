using EyesGuard.Models;
using EyesGuard.ViewModels;

namespace EyesGuard.Commands;

public interface IButtonHandlerBase
{
    public ViewModelBase ViewModel { get; }
    public ConfigurationModel ConfigurationModel { get; }

    public abstract void Execute();
}
