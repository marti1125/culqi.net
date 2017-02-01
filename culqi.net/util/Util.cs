using System;
using RestSharp;
namespace culqi.net
{
	public class Util
	{	

		Config config = new Config();

		public Util()
		{
		}

		public String Request(Object model, string url, string api_key, string type_method)
		{	
			
			RestSharp.RestRequest request = new RestRequest();

			if (type_method.Equals("get"))
			{
				request = new RestRequest(url, Method.GET);
			}
			else if (type_method.Equals("delete")) 
			{
				request = new RestRequest(url, Method.DELETE);
			}
			else if (type_method.Equals("post"))
			{
				request = new RestRequest(url, Method.POST);
				request.AddJsonBody(model);
			}

			var client = new RestClient(config.url_api_base);
			request.AddHeader("Authorization", "Bearer " + api_key);
			IRestResponse response = client.Execute(request);
			return response.Content;

		}

	}
}
