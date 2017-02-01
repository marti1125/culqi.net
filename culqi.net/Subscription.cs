using System;
using RestSharp;
namespace culqi.net
{
	public class Subscription
	{
		Security security { get; set; }

		public Subscription(Security security)
		{
			this.security = security;
		}

		public string Create(SubscriptionModel subscription)
		{
			Util util = new Util();
			return util.Request(subscription, SubscriptionModel.URL, security.api_key, "post");
		}

		public string Get(String id)
		{
			Util util = new Util();
			return util.Request(null, SubscriptionModel.URL + id + "/", security.api_key, "get");
		}

		public string Delete(String id)
		{
			Util util = new Util();
			return util.Request(null, SubscriptionModel.URL + id + "/", security.api_key, "delete");
		}

	}
}
