using EyesGuard.ViewModels;
using EyesGuard.Views;
using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using System.Timers;
using Timer = System.Timers.Timer;

namespace EyesGuard.Processes;

public class TimeManager : ITimeManager
{
    private const int MINUTES_IN_MILISECONDS = 60_000;
    private readonly Timer _timer;

    public TimeManager()
    {
        _timer= new Timer();
    }

    public void Start(int minutes)
    {
        _timer.Interval = minutes * MINUTES_IN_MILISECONDS;
        _timer.Elapsed += OnTimedEvent!;
        _timer.AutoReset = true;
        _timer.Start();
    }

    public void Stop()
    {
        _timer.Stop();
    }

    private void OnTimedEvent(object source, ElapsedEventArgs e)
    {
        var popUpWindow = new PopupWindow
        {
            DataContext = new PopupWindowViewModel()
        };

    }

}
