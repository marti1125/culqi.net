using System;
using RestSharp;
namespace culqi.net
{
	public class Token
	{	
		Config config = new Config();

		Security security { get; set; }

		public Token(Security security)
		{
			this.security = security;
		}

		public string Create(TokenModel token)
		{
			var client = new RestClient(config.url_api_base);
			var request = new RestRequest("/tokens/",Method.POST);
			request.AddJsonBody(token);
			request.AddHeader("Authorization", "Code "+security.code_commerce);
			IRestResponse response = client.Execute(request);
			return response.Content;
		}

	}
}
