﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using InternetShop.SiteApp.Services.CustomLogger;
using Microsoft.Extensions.Options;
using NLog;

namespace InternetShop.SiteApp.Services.EmailService
{
    public class EmailService
    {
        private readonly MailSettings _settings;
        private readonly SmtpClient _smtp;

        private readonly Logger _logger;
        public EmailService(IOptions<MailSettings> settings, ICustomLogger logger)
        {
            _settings = settings.Value;
            _smtp = new SmtpClient(_settings.Host, _settings.Port)
            {
                Credentials = new NetworkCredential(_settings.Mail, _settings.Password),
                EnableSsl = true
            };
            _logger = logger.Manager;
        }
        public async Task SendEmailAsync(MailRequestModel mailRequest)
        {
            MailAddress from = new MailAddress(_settings.Mail);
            MailAddress to = new MailAddress(mailRequest.ToEmail);
            MailMessage message = new MailMessage(from, to);
            message.Subject = mailRequest.Subject;
            message.Body = mailRequest.Body;
            try
            { 
                _smtp.SendAsync(message, null);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task SendEmailsAsync(List<MailRequestModel> mails)
        {
            foreach (var mail in mails)
            {
                try
                {
                    await SendEmailAsync(mail);
                }
                catch(Exception e)
                {
                    var errorMsg =
                        $"Ошибка при отправке email по адресу {mail.ToEmail}\nИсключение: {e.Message}\nStacktrace: {e.StackTrace}";
                    _logger.Error(errorMsg);
                    throw new Exception(errorMsg);
                }
            }
        }
    }
}