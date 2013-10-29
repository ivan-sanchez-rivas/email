using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace email
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Recibe el correo de quien lo va mandar
                Console.WriteLine("De: ");
                MailAddress from = new MailAddress(Console.ReadLine());
                //Se escribe el correo a quien se le va a mandar
                Console.WriteLine("Para: ");
                MailAddress to = new MailAddress(Console.ReadLine());
                //Se unen el from y to a la clase Mail Message
                MailMessage correo = new MailMessage(from, to);
                //Se escribe el tema del correo
                Console.WriteLine("Tema: ");
                correo.Subject = Console.ReadLine();
                //Se escribe el Mensaje del correo
                Console.WriteLine("Mensaje: ");
                correo.Body = Console.ReadLine();
                //Se instancean el servicio para el cual se va a mandar
                SmtpClient smtp = new SmtpClient();
                Console.WriteLine("Mandando correo...");
                //Se manda el correo
                smtp.Send(correo);
                Console.WriteLine("Correo Mandado exitosamente");
                Console.ReadLine();
            }
            catch
            {
                //Exception que avisa si el correo se manda o no
                CustomException error = new CustomException();
                Console.ReadLine();
            }

        }
    }
}
