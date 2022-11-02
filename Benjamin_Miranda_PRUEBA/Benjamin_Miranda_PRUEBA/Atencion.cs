using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benjamin_Miranda_PRUEBA
{
    public class Atencion
    {
        private string tipoAtencion;
        private string fecha;
        private string hora;
        private Cliente clienteAtencion;

        public string TipoAtencion
        {
            get { return tipoAtencion; }
            set { tipoAtencion = value; }
        }

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public Cliente ClienteAtencion
        {
            get { return clienteAtencion; }
            set {  clienteAtencion = value; }
        }
    }
}
