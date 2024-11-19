using Models;

namespace APILayer.DataHandlers
{
    public interface IDataHandler
    {
        Task PostNewGame(BoardGameModel boardGameJson);
    }
}