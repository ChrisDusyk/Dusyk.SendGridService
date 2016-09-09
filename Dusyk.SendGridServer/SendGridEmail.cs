namespace Dusyk.SendGridService
{
	public class SendGridEmail
	{
		public string Email { get; set; }
		public string Name { get; set; }

		public SendGridEmail()
		{
		}

		public SendGridEmail(string email, string name = null)
		{
			Email = email;
			Name = (name == null) ? "" : name;
		}
	}
}