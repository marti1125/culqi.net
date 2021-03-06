﻿using System;
using System.Collections.Generic;
namespace culqi.net
{
	public class Refund
	{
		Security security { get; set; }

		public Refund(Security security)
		{
			this.security = security;
		}

		public string List(Dictionary<string, string> query_params)
		{
			Util util = new Util();
			return util.Request(query_params, RefundModel.URL, security.api_key, "get");
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
