using System;
using RestSharp;
namespace culqi.net
{
	public class Charge
	{	
		Config config = new Config();

		Security security { get; set; }

		public Charge(Security security)
		{
			this.security = security;
		}

		public string Create(ChargeModel charge)
		{
			var client = new RestClient(config.url_api_base);
			var request = new RestRequest("/charges/", Method.POST);
			request.AddJsonBody(charge);
			request.AddHeader("Authorization", "Bearer " + security.api_key);
			IRestResponse response = client.Execute(request);
			return response.Content;
		}

	}
}
