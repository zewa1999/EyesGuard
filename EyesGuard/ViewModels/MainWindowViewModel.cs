using System.Reactive;
using EyesGuard.Commands;
using EyesGuard.Models;
using ReactiveUI;

namespace EyesGuard.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private readonly ConfigurationModel _configurationModel;
    private readonly IButtonHandlerBase _startButtonHandler;
    private readonly IButtonHandlerBase _stopButtonHandler;
    public ReactiveCommand<Unit, Unit> ButtonStartCommand { get; }
    public ReactiveCommand<Unit, Unit> ButtonStopCommand { get; }

    public MainWindowViewModel()
    {
        _configurationModel = new ConfigurationModel();

        // this should be changed to DI, maybe
        _startButtonHandler = new ButtonStartHandler(this, _configurationModel);
        _stopButtonHandler = new ButtonStartHandler(this, _configurationModel);

        ButtonStartCommand = ReactiveCommand.Create(
               () =>  _startButtonHandler.Execute());
        ButtonStopCommand = ReactiveCommand.Create(
               () => _stopButtonHandler.Execute());
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

    private bool _isNotificationChecked;

    public bool IsNotificationChecked
    {
        get
        {
            return _isNotificationChecked;
        }
        set
        {
            _isNotificationChecked = value;
            _configurationModel.IsNotificationChecked = value;
            this.RaiseAndSetIfChanged(ref _isNotificationChecked, value);
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