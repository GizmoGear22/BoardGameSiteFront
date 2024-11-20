using Models;

namespace APILayer.DataHandlers
{
    public interface IDataHandler
    {
        Task<HttpResponseMessage> PostNewGame(BoardGameModel boardGameJson);
    }
}