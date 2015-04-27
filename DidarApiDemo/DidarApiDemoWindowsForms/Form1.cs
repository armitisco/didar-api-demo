using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DidarApiWrapper.me.didar;
using System.Web.Script.Serialization;

namespace DidarApiDemoWindowsForms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private static string ToJson(object obj)
		{
			return new JavaScriptSerializer().Serialize(obj);
		}

		private void getBizDomainDataButton_Click(object sender, EventArgs e)
		{
			try
			{
				GetBizDomainData();
			}
			catch (Exception ex)
			{
				HandleError(ex);
			}
		}

		private void HandleError(Exception ex)
		{
			MessageBox.Show(ex.Message);
		}

		private void getUsersButton_Click(object sender, EventArgs e)
		{
			try
			{
				GetUsers();
			}
			catch (Exception ex)
			{
				HandleError(ex);
			}
		}

		private void getContactsButton_Click(object sender, EventArgs e)
		{
			try
			{
				GetContacts();
			}
			catch (Exception ex)
			{
				HandleError(ex);
			}
		}

		private async void GetBizDomainData()
		{
			BizDomainData data = await DidarApi.Wrapper.GetBizDomainData(apiKeyTextBox.Text);
			MessageBox.Show(ToJson(data));
		}

		private async void GetUsers()
		{
			BizDomainUser[] data = await DidarApi.Wrapper.GetUsersData(apiKeyTextBox.Text);
			MessageBox.Show(ToJson(data));
		}

		private async void GetContacts()
		{
			Contact[] data = await DidarApi.Wrapper.GetContactsData(apiKeyTextBox.Text, DateTime.Now.Date.AddDays(-10));
			MessageBox.Show(ToJson(data));
		}

		private void addContactButton_Click(object sender, EventArgs e)
		{
			try
			{
				AddContact();
			}
			catch (Exception ex)
			{
				HandleError(ex);
			}
		}

		private async void AddContact()
		{
			BizDomainUser[] users = await DidarApi.Wrapper.GetUsersData(apiKeyTextBox.Text);
			var rand = new Random();
			var user = users[rand.Next(users.Length)];

			Contact contact = new Contact()
			{ 
				OwnerId = user.Id,
				Title = titleTextBox.Text,
				FirstName = firstNameTextBox.Text,
				LastName = lastNameTextBox.Text,
				MobilePhone = mobilePhoneTextBox.Text,
				WorkPhone = workPhoneTextBox.Text,
				WorkPhoneExtension = workPhoneExtensionTextBox.Text
			};

			contact = await DidarApi.Wrapper.AddContact(apiKeyTextBox.Text, contact);

			MessageBox.Show(ToJson(contact));
			
		}

	}
}
