using Models;

namespace APILayer
{
	public interface IAPIHelperFunctions
	{
		string SerializeJson(BoardGameModel boardGame);
	}
}