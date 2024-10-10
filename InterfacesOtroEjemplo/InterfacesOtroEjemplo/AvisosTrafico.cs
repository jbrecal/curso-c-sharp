using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesOtroEjemplo
{
    internal class AvisosTrafico : IAvisos  // heredamos la interfaz IAvisos
    {

        public AvisosTrafico()  // constructor
        {
            remitente = "DGT";

            mensaje = "Sanción comentida. Pague antes de 3 días y se beneficiará en una reducción del 50%";

            fecha = "";
        }
        public AvisosTrafico(string remitente, string  mensaje, string fecha)
        {
            this.remitente = remitente;  // estamos almacenando en la variable private lo que le pasemos por estos campos
            this.mensaje = mensaje;
            this.fecha = fecha;
        }

       
        public string getFecha()
        {
            return fecha;
        }

        public void mostrarAviso()
        {
            Console.WriteLine("Mensaje {0} ha sido enviado por {1} el día {2}" , mensaje, remitente, fecha);
        }

        private string remitente;

        private string mensaje;

        private string fecha;
    }
}
