using Models;

namespace APILayer
{
	public interface IDataHandler
	{
		Task<BoardGameModel> PostNewGame(string boardGameJson);
	}
}