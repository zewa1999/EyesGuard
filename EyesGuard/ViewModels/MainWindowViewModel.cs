using EyesGuard.Models;
using EyesGuard.Processes;
using EyesGuard.Views;
using ReactiveUI;
using System.Reactive;

namespace EyesGuard.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private readonly TimeManager _timer;
    private readonly PopupWindowViewModel _popWindowViewModel;

    public ReactiveCommand<Unit, Unit> ButtonStartCommand { get; }
    public ReactiveCommand<Unit, Unit> ButtonStopCommand { get; }

    public MainWindowViewModel()
    {
        _popWindowViewModel = new PopupWindowViewModel();

        _timer = new TimeManager();
        ButtonStartCommand = ReactiveCommand.Create(
               () =>
               {
                   _timer.Start(ConfigurationModel.IntervalMinutesTime);
               });

        ButtonStopCommand = ReactiveCommand.Create(
               () => _timer.Stop());

        var popupWindow = new PopupWindow
        {
            DataContext = _popWindowViewModel
        };

        popupWindow.Show();
    }

    #region properties

    private int _intervalTime;

    public int IntervalTime
    {
        get
        {
            return _intervalTime;
        }
        set
        {
            _intervalTime = value;
            // check if error here
            ConfigurationModel.IntervalMinutesTime = value;
            this.RaiseAndSetIfChanged(ref _intervalTime, value);
        }
    }

    private int _pauseDuration;

    public int PauseDuration
    {
        get
        {
            return _pauseDuration;
        }
        set
        {
            _pauseDuration = value;
            // check if error here
            ConfigurationModel.IntervalMinutesTime = value;
            this.RaiseAndSetIfChanged(ref _pauseDuration, value);
        }
    }

    private string _textToDisplay = null!;

    public string TextToDisplay
    {
        get
        {
            return _textToDisplay;
        }
        set
        {
            _textToDisplay = value;
            ConfigurationModel.TextToDisplay = value;
            this.RaiseAndSetIfChanged(ref _textToDisplay, value);
        }
    }

    private bool _isWindowPopupChecked;

    public bool IsWindowPopupChecked
    {
        get
        {
            return _isWindowPopupChecked;
        }
        set
        {
            _isWindowPopupChecked = value;
            ConfigurationModel.IsWindowPopupChecked = value;
            this.RaiseAndSetIfChanged(ref _isWindowPopupChecked, value);
        }
    }

    #endregion properties
}