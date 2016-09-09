using System.Threading.Tasks;

namespace Dusyk.SendGridService
{
	public interface IEmailSender
	{
		Task SendEmailAsync(string to, string subject, string from, string message);
	}
}