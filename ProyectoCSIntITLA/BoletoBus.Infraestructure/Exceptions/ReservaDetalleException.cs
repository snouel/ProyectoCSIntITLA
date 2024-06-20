using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.Infraestructure.Exceptions
{
    public class ReservaDetalleDataException : Exception
    {
        public ReservaDetalleDataException(string message) : base(message)
        {
            // Logica para enviar el correo y loggear el error. 


        }
    }
}
