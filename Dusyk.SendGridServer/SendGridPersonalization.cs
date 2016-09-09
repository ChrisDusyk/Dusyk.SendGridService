using System.Collections.Generic;

namespace Dusyk.SendGridService
{
	public class SendGridPersonalization
	{
		public List<SendGridEmail> To { get; set; }
		public string Subject { get; set; }
	}
}