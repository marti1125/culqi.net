using System;
using RestSharp;
namespace culqi.net
{
	public class Plan
	{	
		Config config = new Config();

		Security security { get; set; }

		public Plan(Security security)
		{
			this.security = security;
		}

		public string Create(PlanModel plan)
		{
			var client = new RestClient(config.url_api_base);
			var request = new RestRequest("/plans/", Method.POST);
			request.AddJsonBody(plan);
			request.AddHeader("Authorization", "Bearer " + security.api_key);
			IRestResponse response = client.Execute(request);
			return response.Content;
		}

	}
}
