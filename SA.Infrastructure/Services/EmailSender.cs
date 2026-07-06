using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using SA.Domain.Identity;
using System.Net;
using System.Net.Mail;

namespace SA.Infrastructure.Services
{
    public class EmailSender : IEmailSender<ApplicationUser>
    { 
        // Idealmente, inyecta IConfiguration para leer estos valores del appsettings.json
        private readonly string smtpServer = "smtp.gmail.com";
        private readonly int port = 587;
        private readonly string emailFrom = "onsaledaniel78963@gmail.com";
        private readonly string password = "mqoerwffooeaupoi";
        private readonly IWebHostEnvironment _env;

        // Inyectamos el entorno para poder ubicar los archivos HTML
        public EmailSender(IWebHostEnvironment env)
        {
            _env = env;
        }

        public async Task SendConfirmationLinkAsync(ApplicationUser user, string email, string confirmationLink)
        {
            //await SendEmailAsync(email, "Confirma tu cuenta", $"Por favor confirma tu cuenta haciendo clic aquí: <a href='{confirmationLink}'>link</a>");
            // 1. Ubicamos el archivo HTML
            var templatePath = Path.Combine(_env.ContentRootPath, "EmailTemplates", "ConfirmEmail.html");

            // 2. Leemos el contenido
            var htmlBody = await File.ReadAllTextAsync(templatePath);

            // 3. Reemplazamos las variables dinámicas
            htmlBody = htmlBody.Replace("{{UserEmail}}", email);
            htmlBody = htmlBody.Replace("{{ConfirmationLink}}", confirmationLink);

            // 4. Enviamos el correo
            await SendEmailAsync(email, "Confirma tu cuenta en SAGA", htmlBody);
        }

        public async Task SendPasswordResetLinkAsync(ApplicationUser user, string email, string resetLink)
        {
            //await SendEmailAsync(email, "Restablecer contraseña", $"Restablece tu contraseña haciendo clic aquí: <a href='{resetLink}'>link</a>");
            // 1. Ubicamos el archivo HTML
            var templatePath = Path.Combine(_env.ContentRootPath, "EmailTemplates", "ResetPasswordLink.html");

            // 2. Leemos el contenido
            var htmlBody = await File.ReadAllTextAsync(templatePath);

            // 3. Reemplazamos las variables dinámicas
            htmlBody = htmlBody.Replace("{{UserEmail}}", email);
            htmlBody = htmlBody.Replace("{{ResetLink}}", resetLink);

            // 4. Enviamos el correo
            await SendEmailAsync(email, "Restablecer contraseña en SAGA", htmlBody);
        }

        public async Task SendPasswordResetCodeAsync(ApplicationUser user, string email, string resetCode)
        {
            //await SendEmailAsync(email, "Código para restablecer contraseña", $"Tu código es: {resetCode}");
            // 1. Ubicamos el archivo HTML
            var templatePath = Path.Combine(_env.ContentRootPath, "EmailTemplates", "ResetPasswordCode.html");

            // 2. Leemos el contenido
            var htmlBody = await File.ReadAllTextAsync(templatePath);

            // 3. Reemplazamos las variables dinámicas
            htmlBody = htmlBody.Replace("{{UserEmail}}", email);
            htmlBody = htmlBody.Replace("{{ResetCode}}", resetCode);

            // 4. Enviamos el correo
            await SendEmailAsync(email, "Tu código de seguridad SAGA", htmlBody);
        }

        private async Task SendEmailAsync(string toEmail, string subject, string htmlMessage)
        {
            using var client = new SmtpClient(smtpServer, port)
            {
                // IMPORTANTE: Esto debe ir ANTES de asignar las credenciales. Si no lo haces, algunos servidores rebotan la petición.
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(emailFrom, password),
                EnableSsl = true
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(emailFrom, "Sistema SAGA"), // Agrega un nombre amigable aquí
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };
            mailMessage.To.Add(toEmail);

            await client.SendMailAsync(mailMessage);
        }
    }
}