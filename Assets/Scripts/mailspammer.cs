using System;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MailSpammer {

	// Use this for initialization
	public static bool SendMail(String from, String password, String to, String subject, String text) {
		MailMessage mail = new MailMessage ();

		mail.From = new MailAddress (from);
		mail.To.Add (to);
		mail.Subject = subject;
		mail.Body = text;

		SmtpClient smtpServer = new SmtpClient ("smtp.gmail.com");
		smtpServer.Port = 587;
		smtpServer.Credentials = new System.Net.NetworkCredential (from, password) as ICredentialsByHost;
		smtpServer.EnableSsl = true;

		ServicePointManager.ServerCertificateValidationCallback =
			delegate (object sim, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) {
				return true;
			};
		
		smtpServer.Send (mail);
		return true;
	}
}