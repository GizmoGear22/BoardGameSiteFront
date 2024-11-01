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
	public class DataHandler : IDataHandler
	{
		private readonly HttpClient _httpClient;
		public DataHandler(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<BoardGameModel> PostNewGame(string boardGameJson)
		{
			throw new NotImplementedException();
		}
	}
}
