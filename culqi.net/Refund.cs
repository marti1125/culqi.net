using System;
using RestSharp;
namespace culqi.net
{
	public class Refund
	{
		Security security { get; set; }

		public Refund(Security security)
		{
			this.security = security;
		}

		public string Create(RefundModel refund)
		{
			Util util = new Util();
			return util.Request(refund, RefundModel.URL, security.api_key, "post");
		}

		public string Get(String id)
		{
			Util util = new Util();
			return util.Request(null, RefundModel.URL + id + "/", security.api_key, "get");
		}

	}
}
