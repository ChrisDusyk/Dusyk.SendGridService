# Dusyk.SendGridService
Wraps an HttpClient call to the v3 endpoint of SendGrid's web API to send emails. The message data is serialized to JSON and posted to the email/send endpoint.

# Credit
All credit for this solution goes to GitHub user [yellowsix](https://github.com/yellowsix), as proposed in an [issue thread](https://github.com/sendgrid/sendgrid-csharp/issues/221) for the official SendGrid SDK. I put this into actual code as I needed it for a personal project, and figured others could benefit from having this handy.

## Usage
As a .NET Core class library, this will automatically compile into a NuGet package. First, build the project and put the resulting NuGet package in your own NuGet feed. Next, include the NuGet package in your application. Once added, reference it where needed.

### ASP.NET Core
This library is designed to work with ASP.NET Core primarily, however will work with any .NET framework.

Using ASP.NET Core's Dependency Injection system, register the SendGridService in Startup.cs:

	services.AddTransient<IEmailSender, SendGridClient>(_ => new SendGridClient("API_KEY"));

This will register the SendGridClient into Dependency Injection, and it can be pulled into any location that needs an IEmailSender.

### Previous .NET Framework
This library can be easily instantiated like any other library object:

	var sendGridClient = new SendGridClient("API_KEY");