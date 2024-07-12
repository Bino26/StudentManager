using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using MimeKit;
using SharedLibrary.Models.Entity;
using StudentManager.Server.Services.Contracts;



public class EmailService : IEmailService
{
    private readonly EmailSettings emailSettings;

    public EmailService(IOptions<EmailSettings> emailSettings)
    {
        this.emailSettings = emailSettings.Value;
    }

    public async Task SendEmailAsync(string to, string subject, string body)
    {
        var email = new MimeMessage();
        email.From.Add(MailboxAddress.Parse(emailSettings.FromEmail));
        email.To.Add(MailboxAddress.Parse(to));
        email.Subject = subject;
        email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = body };

        using var smtp = new SmtpClient();
        await smtp.ConnectAsync(emailSettings.SmtpServer, emailSettings.SmtpPort, false);
        await smtp.AuthenticateAsync(emailSettings.SmtpUser, emailSettings.SmtpPass);
        await smtp.SendAsync(email);
        await smtp.DisconnectAsync(true);

    }
}
