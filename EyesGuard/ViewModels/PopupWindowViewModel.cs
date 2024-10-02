using Avalonia.Threading;
using EyesGuard.Models;
using ReactiveUI;
using System;
using System.Reactive;

namespace EyesGuard.ViewModels;

public class PopupWindowViewModel : ViewModelBase
{
    private DispatcherTimer _timer;
    private TimeSpan _timeRemaining;

    public ReactiveCommand<Unit, Unit> StartTimerCommand { get; }

    private string _countdownTime;

    public string CountdownTime
    {
        get => _countdownTime;
        set => this.RaiseAndSetIfChanged(ref _countdownTime, value);
    }

    private string _userText;

    public string UserText
    {
        get => ConfigurationModel.TextToDisplay;
    }

    public PopupWindowViewModel()
    {
        _timeRemaining = TimeSpan.FromMinutes(ConfigurationModel.PauseDuration);
        _countdownTime = _timeRemaining.ToString("mm\\:ss");

        _timer = new DispatcherTimer();
        _timer.Interval = TimeSpan.FromSeconds(1);
        _timer.Tick += OnTimerTick!;
        _timer.Start();
    }

    private void OnTimerTick(object sender, EventArgs e)
    {
        if (_timeRemaining.TotalSeconds > 0)
        {
            _timeRemaining = _timeRemaining.Subtract(TimeSpan.FromSeconds(1));
            CountdownTime = _timeRemaining.ToString("mm\\:ss"); // Update the displayed time
        }
        else
        {
            _timer.Stop();
            CountdownTime = "00:00"; // Timer finished
        }
    }
}