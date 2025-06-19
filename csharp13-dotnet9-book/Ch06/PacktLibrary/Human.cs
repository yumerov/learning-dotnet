namespace Packt.Shared;

public class Human: IGamePlayer, IKeyHolder
{
    public void Lose()
    {
        WriteLine("Implementation for losing a key.");
    }

    void IGamePlayer.Lose()
    {
        WriteLine("Implementation for losing a game.");
    }
}