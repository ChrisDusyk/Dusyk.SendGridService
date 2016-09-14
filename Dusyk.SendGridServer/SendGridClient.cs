using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Dusyk.SendGridService
{
	public class SendGridClient : IEmailSender
	{
		private string _sendGridApiKey;
		private static HttpClient _client = new HttpClient();

		public SendGridClient(string apiKey)
		{
			_sendGridApiKey = apiKey;
		}

		public async Task SendEmailAsync(string to, string subject, string fromAddress, string message)
		{
			var sgMessage = new SendGridMessage(new SendGridEmail(to), subject, new SendGridEmail(fromAddress), message);

			try
			{
				string json = JsonConvert.SerializeObject(sgMessage);

				_client.BaseAddress = new Uri("https://api.sendgrid.com/v3/");
				_client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _sendGridApiKey);

				var response = await _client.PostAsync("mail/send", new StringContent(json, Encoding.UTF8, "application/json"));

				if (!response.IsSuccessStatusCode)
				{
					string errorJson = await response.Content.ReadAsStringAsync();
					throw new Exception($"Error in SendGridService from SendGrid, code: {response.StatusCode}, reason: {errorJson}");
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error in SendGridService", ex);
			}
		}
	}
}