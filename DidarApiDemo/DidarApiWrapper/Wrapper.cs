using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DidarApiWrapper.me.didar;

namespace DidarApi
{
	public static class Wrapper
	{
		public static async Task<BizDomainData> GetBizDomainData(string apiKey)
		{
			using (CollaborativeSoapClient client = new CollaborativeSoapClient())
			{
				GetBizDomainResponse response = await client.GetBizDomainAsync(apiKey);
				return response.Body.GetBizDomainResult.Data;
			}
		}
	}
}
