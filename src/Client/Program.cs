// See https://aka.ms/new-console-template for more information
using IdentityModel.Client;
using System.Net.Http.Json;
using System.Text.Json;

namespace Client
{
	public class Program
	{
		private static async Task Main()
		{

			Console.WriteLine("Hello, World!");
			var client = new HttpClient();
			var disco = await client.GetDiscoveryDocumentAsync("https://localhost:5001");
			if (disco.IsError)
			{
				Console.WriteLine(disco.Error);
				return;
			}

			Console.WriteLine(disco.TokenEndpoint);

			var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
			{
				Address = disco.TokenEndpoint,

				ClientId = "client",
				ClientSecret = "secret",
				Scope = "api1"
			});

			if (tokenResponse.IsError)
			{
				Console.WriteLine(tokenResponse.Error);
				return;
			}

			Console.WriteLine(tokenResponse.Json);

			var identityRequest = await client.GetAsync("https://localhost:44309/identity");
			var weatherforecastRequest = await client.GetAsync("https://localhost:44309/weatherforecast");

			Console.WriteLine("identity:" + await identityRequest.Content.ReadAsStreamAsync());
			Console.WriteLine("weather" + weatherforecastRequest.Content.ToString());
		}
	}
}
