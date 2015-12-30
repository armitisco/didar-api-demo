using DidarApiWrapperV2.me.didar;
using System;
using System.Collections.Generic;
using System.Text;

namespace DidarApiWrapperV2
{
	public static class Wrapper
	{
		public static BizDomainData GetBizDomainData(string apiKey)
		{
			using (Collaborative client = new Collaborative())
			{
				GetBizDomainData response = client.GetBizDomain(apiKey);
				if (response.Response.StatusCode == Status.OK)
					return response.Data;

				throw new Exception("API error: " + response.Response.StatusCode);
			}
		}

		public static BizDomainUser[] GetUsersData(string apiKey)
		{
			using (Collaborative client = new Collaborative())
			{
				GetUsersData response = client.GetUsers(apiKey);
				if (response.Response.StatusCode == Status.OK)
					return response.Data;
				throw new Exception("API error: " + response.Response.StatusCode);
			}
		}

		public static Contact[] GetContactsData(string apiKey, DateTime lastModified)
		{

			using (Collaborative client = new Collaborative())
			{
				GetContactsData response = client.GetContacts(apiKey, lastModified);
				if (response.Response.StatusCode == Status.OK)
					return response.Data;
				throw new Exception("API error: " + response.Response.StatusCode);
			}
		}



		public static Contact AddContact(string apiKey, Contact contactData)
		{
			using (Collaborative client = new Collaborative())
			{
				GetContactsData response = client.AddContact(apiKey, contactData);
				if (response.Response.StatusCode == Status.OK)
					return response.Data[0];
				throw new Exception("API error: " + response.Response.StatusCode);
			}
		}
	}
}
