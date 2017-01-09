using System;
using RestSharp;
namespace culqi.net
{
	public class Subscription
	{
		Config config = new Config();

		Security security { get; set; }

		public Subscription(Security security)
		{
			this.security = security;
		}

		public string Create(SubscriptionModel subscription)
		{
			var client = new RestClient(config.url_api_base);
			var request = new RestRequest("/subscriptions/", Method.POST);
			request.AddJsonBody(subscription);
			request.AddHeader("Authorization", "Bearer " + security.api_key);
			IRestResponse response = client.Execute(request);
			return response.Content;
		}
	}
}
