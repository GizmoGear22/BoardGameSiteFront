using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace APILayer
{
	public class DataHandler
	{
		private readonly HttpClient _httpClient;
		public DataHandler(HttpClient httpClient)
		{
			_httpClient = httpClient; 
		}

		public string SerializeJson(BoardGameModel boardGame)
		{
			var jsonString = JsonSerializer.Serialize(boardGame);
			return jsonString;
		}

		public async Task<BoardGameModel> PostNewGame(string boardGameJson)
		{
			string address = "https://localhost:44328/api/Main/CreateNewGame.html";
			return await _httpClient.PostAsJsonAsync(address, boardGameJson);
		}

		//public async Task<string> SerializeJson(BoardGameModel boardGame)
		//{
		//	string fileName = "NewBoardGame.json";
		//	await using FileStream createStream = File.Create(fileName);
		//	var data = await JsonSerializer.SerializeAsync<BoardGameModel>(createStream, boardGame);
		//	return data;
		//}

		//public async Task<BoardGameModel> PostNewGame(BoardGameModel model)
		//{
		//	string address = "https://localhost:44328/api/Main/CreateNewGame.html";
		//	return await _httpClient.PostAsJsonAsync(address, stringifiedModel);
		//}
	}
}
