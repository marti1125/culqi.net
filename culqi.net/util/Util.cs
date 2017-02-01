﻿using System;
using System.Collections.Generic;
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
				if (model != null)
				{
					Dictionary<string, string> query_params = (Dictionary<string, string>)model;
					foreach (KeyValuePair<string, string> entry in query_params)
					{
						request.AddParameter(entry.Key, entry.Value, ParameterType.QueryString);
					}
				}
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
