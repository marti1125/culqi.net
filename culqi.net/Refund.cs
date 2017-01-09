using System;
using RestSharp;
namespace culqi.net
{
	public class Refund
	{
		Config config = new Config();

		Security security { get; set; }

		public Refund(Security security)
		{
			this.security = security;
		}

		public string Create(RefundModel refund)
		{
			var client = new RestClient(config.url_api_base);
			var request = new RestRequest("/refunds/", Method.POST);
			request.AddJsonBody(refund);
			request.AddHeader("Authorization", "Bearer " + security.api_key);
			IRestResponse response = client.Execute(request);
			return response.Content;
		}
	}
}
