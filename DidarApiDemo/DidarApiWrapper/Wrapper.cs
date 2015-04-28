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
				if (response.Body.GetBizDomainResult.Response.StatusCode == Status.OK)
					return response.Body.GetBizDomainResult.Data;
				else
					throw new Exception("API error: " + response.Body.GetBizDomainResult.Response.StatusCode);
			}
		}

		public static async Task<BizDomainUser[]> GetUsersData(string apiKey)
		{
			using (CollaborativeSoapClient client = new CollaborativeSoapClient())
			{
				GetUsersResponse response = await client.GetUsersAsync(apiKey);
				if (response.Body.GetUsersResult.Response.StatusCode == Status.OK)
					return response.Body.GetUsersResult.Data;
				else
					throw new Exception("API error: " + response.Body.GetUsersResult.Response.StatusCode);
			}
		}

		public static async Task<Contact[]> GetContactsData(string apiKey, DateTime lastModified)
		{

			using (CollaborativeSoapClient client = new CollaborativeSoapClient())
			{
				GetContactsResponse response = await client.GetContactsAsync(apiKey, lastModified);
				if (response.Body.GetContactsResult.Response.StatusCode == Status.OK)
					return response.Body.GetContactsResult.Data;
				else
					throw new Exception("API error: " + response.Body.GetContactsResult.Response.StatusCode);
			} 
		}



		public static async Task<Contact> AddContact(string apiKey, Contact contactData)
		{
			throw new NotImplementedException();
			//using (CollaborativeSoapClient client = new CollaborativeSoapClient())
			//{
			//	AddContactResponse response = await client.AddContactAsync(apiKey, contactData);
			//	if (response.Body.AddContactResult.Response.StatusCode == Status.OK)
			//		return response.Body.AddContactResult.Data[0];
			//	else
			//		throw new Exception("API error: " + response.Body.AddContactResult.Response.StatusCode);
			//}
		}
	}
}
