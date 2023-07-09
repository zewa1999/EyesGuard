using System.Reactive;
using EyesGuard.Models;
using EyesGuard.Processes;
using EyesGuard.Views;
using ReactiveUI;

namespace EyesGuard.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private readonly ConfigurationModel _configurationModel;
    private readonly TimeManager _timer;
    private readonly PopupWindowViewModel _popWindowViewModel;

    public ReactiveCommand<Unit, Unit> ButtonStartCommand { get; }
    public ReactiveCommand<Unit, Unit> ButtonStopCommand { get; }

    public MainWindowViewModel()
    {
        _configurationModel = new ConfigurationModel();
        _popWindowViewModel = new PopupWindowViewModel();

        _timer = new TimeManager();
        ButtonStartCommand = ReactiveCommand.Create(
               () =>
               {
                   if (_intervalTime is not null)
                   {
                       _timer.Start(_configurationModel.IntervalMinutesTime);
                   }
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

    private string _intervalTime = null!;

    public string IntervalTime
    {
        get
        {
            return _intervalTime;
        }
        set
        {
            _intervalTime = value;
            // check if error here
            _configurationModel.IntervalMinutesTime = int.Parse(value);
            this.RaiseAndSetIfChanged(ref _intervalTime, value);
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
            _configurationModel.TextToDisplay = value;
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
            _configurationModel.IsWindowPopupChecked = value;
            this.RaiseAndSetIfChanged(ref _isWindowPopupChecked, value);
        }
    }

    #endregion properties
}