﻿using OTSC_ui.Tools.AppSettingJsonPhars.Temaplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace OTSC_ui.Tools.SendMailWithcode.CodeSend
{
    internal class EmailServiceTest : IEmailService
    {
        private readonly string _senderEmail = "smtp@mailtrap.io";
        private readonly string _senderPassword = "bcd1d261c83fc9cb5b4658ef317e1ea9";
        private readonly string _smtpHost = "live.smtp.mailtrap.io";
        private readonly int _smtpPort = 587;


        public void SendEmail(string recipientEmail, string subject, string body)
        {

            using var smtpClient = new SmtpClient(_smtpHost, _smtpPort)
            {
                Credentials = new NetworkCredential(_senderEmail, _senderPassword),
                EnableSsl = true
            };
            try
            {
                smtpClient.Send("hello@demomailtrap.com", "ldsloop.dkod@gmail.com", "Mytest", "testbody");
            }
            catch (Exception ex)
            {
                Log.Error($"Email send error {nameof(EmailServiceWithTemplate)} ERORR:{ex.Message}");
            }
            Log.Information($"Email send in {nameof(EmailServiceWithTemplate)}to({recipientEmail})");
        }
    }
}