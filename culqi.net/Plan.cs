using System;
using RestSharp;
namespace culqi.net
{
	public class Plan
	{	
		Security security { get; set; }

		public Plan(Security security)
		{
			this.security = security;
		}

		public string Create(PlanModel plan)
		{
			Util util = new Util();
			return util.Request(plan, PlanModel.URL, security.api_key, "post");
		}

		public string Get(String id)
		{
			Util util = new Util();
			return util.Request(null, PlanModel.URL + id + "/", security.api_key, "get");
		}

	}
}
