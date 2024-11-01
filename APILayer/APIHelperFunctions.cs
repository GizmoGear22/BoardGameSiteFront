using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace APILayer
{
	public class APIHelperFunctions : IAPIHelperFunctions
	{
		public string SerializeJson(BoardGameModel boardGame)
		{
			var jsonString = JsonSerializer.Serialize(boardGame);
			return jsonString;
		}
	}
}
