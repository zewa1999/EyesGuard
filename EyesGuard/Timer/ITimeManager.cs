namespace EyesGuard.Processes;

public interface ITimeManager
{
    public void Start(int minutes);
    public void Stop();

}
