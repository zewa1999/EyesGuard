using Avalonia.Threading;
using EyesGuard.Models;
using ReactiveUI;
using System;
using System.ComponentModel;
using System.Reactive.Linq;

namespace EyesGuard.ViewModels;

public class PopupWindowViewModel : ViewModelBase
{
    public PopupWindowViewModel()
    {
        StartProgressBar();
    }

    private void StartProgressBar()
    {
        Observable.Interval(TimeSpan.FromSeconds(1))
            .Take(20)
            .Subscribe(_ =>
            {
                Progress += 1;
            });
    }


    private int _progress = 8;

    public int Progress
    {
        get
        {
            return _progress;
        }
        set
        {
            _progress = value;
            this.RaiseAndSetIfChanged(ref _progress, value);
        }
    }
}
