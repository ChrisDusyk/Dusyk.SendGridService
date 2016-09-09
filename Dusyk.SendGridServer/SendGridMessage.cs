using System.Collections.Generic;

namespace Dusyk.SendGridService
{
	// https://github.com/sendgrid/sendgrid-csharp/issues/221
	public class SendGridMessage
	{
		public const string TYPE_TEXT = "text";
		public const string TYPE_HTML = "text/html";

		public List<SendGridPersonalization> Personalizations { get; set; }
		public SendGridEmail From { get; set; }
		public List<SendGridContent> Content { get; set; }

		public SendGridMessage()
		{
		}

		public SendGridMessage(SendGridEmail to, string subject, SendGridEmail from, string message, string type = "text/html")
		{
			Personalizations = new List<SendGridPersonalization>
			{
				new SendGridPersonalization
				{
					To = new List<SendGridEmail> { to },
					Subject = subject
				}
			};

			From = from;
			Content = new List<SendGridContent>
			{
				new SendGridContent(type, message)
			};
		}
	}
}