using System;
using RestSharp;
namespace culqi.net
{
	public class Charge
	{
		Security security { get; set; }

		public Charge(Security security)
		{
			this.security = security;
		}

		public string Create(ChargeModel charge)
		{	
			Util util = new Util();
			return util.Request(charge, ChargeModel.URL, security.api_key, "post");
		}

		public string Get(String id)
		{
			Util util = new Util();
			return util.Request(null, ChargeModel.URL+id+"/", security.api_key, "get");
		}

	}
}
