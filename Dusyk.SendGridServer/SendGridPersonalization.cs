using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dusyk.SendGridServer
{
	public class SendGridPersonalization
	{
		public List<SendGridEmail> To { get; set; }
		public string Subject { get; set; }
	}
}
