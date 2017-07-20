using DrawGame.Domain.Model.Game;

namespace DrawGame.Domain.Model.Core
{

    public interface IGame
    {
        int GameId { get; set; }
        string Name { get; set; }
        GameType GameType { get; set; }


        byte[] BackgroundImage { get; set; }
        byte[] WinImage { get; set; }
        byte[] LostImage { get; set; }
        byte[] WinSound { get; set; }
        byte[] LostSound { get; set; }
    }
}
