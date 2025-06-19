namespace Packt.Shared;

public interface IPlayable
{
    void Play();
    void Pause();
    public void Stop()
    {
        WriteLine("Default implementation of Stop.");
    }
}