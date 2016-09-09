# Dusyk.SendGridService
Wraps an HttpClient call to the v3 endpoint of SendGrid's web API to send emails. The message data is serialized to JSON and posted to the email/send endpoint.

## Usage
First, include the NuGet package in your application. Once added, reference it where needed.

### ASP.NET Core
This library is designed to work with ASP.NET Core primarily, however will work with any .NET framework.

Using ASP.NET Core's Dependency Injection system, register the SendGridService in Startup.cs:

	services.AddTransient<IEmailSender, SendGridClient>(_ => new SendGridClient("API_KEY"));

This will register the SendGridClient into Dependency Injection, and it can be pulled into any location that needs an IEmailSender.

### Previous .NET Framework
This library can be easily instantiated like any other library object:

	var sendGridClient = new SendGridClient("API_KEY");