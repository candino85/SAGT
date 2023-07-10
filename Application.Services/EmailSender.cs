using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public static class EmailSender
    {
        public static void NotificarContraseña(string user, string pass, string email)
        {
            string asunto = "Registro en Sistema de Administración y Gestión de Turnos - UAI";
            string cuerpo = $"<p>Usted ha sido dado de alta en el sistema, puede iniciar sesión utilizando las siguientes credenciales:</p>" +
                $"<b>Su usuario es:</b> {user} <br><b> Su contraseña es: </b>{pass}<br>" +
                $"Recuerde modificar su contraseña desde Sesion > Cambiar Clave.";

            EnviarCorreo(email, asunto, cuerpo);
        }

        public static void EnviarCorreo(string destinatario, string asunto, string cuerpo)
        {
            try
            {
                // Configura los detalles de autenticación de Gmail
                string remitente = "andino.cristian@hotmail.com"; // Cambia esto por tu dirección de correo electrónico
                string contraseña = "E7n4spRd=T"; // Cambia esto por tu contraseña

                // Configura los detalles del correo electrónico
                MailMessage correo = new MailMessage(remitente, destinatario, asunto, cuerpo);
                correo.IsBodyHtml = true;   

                // Configura el cliente SMTP
                SmtpClient clienteSmtp = new SmtpClient("smtp.office365.com", 587);
                clienteSmtp.EnableSsl = true;
                clienteSmtp.UseDefaultCredentials = false;
                clienteSmtp.Credentials = new NetworkCredential(remitente, contraseña);

                // Envía el correo electrónico
                clienteSmtp.Send(correo);
                clienteSmtp.Dispose();

                Console.WriteLine("Correo electrónico enviado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar el correo electrónico: " + ex.Message);
            }
        }

    }
}
