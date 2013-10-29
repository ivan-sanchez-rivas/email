using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace email
{
    public class CustomException
    {
        public string ErrorCode = "Error no se pudo mandar el correo\n";
        public CustomException()
        {
            Console.WriteLine(ErrorCode);
        }
    }
}
