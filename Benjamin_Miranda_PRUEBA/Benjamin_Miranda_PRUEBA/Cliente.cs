using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benjamin_Miranda_PRUEBA
{
    public class Cliente
    {
        private string rut;
        private string nombre;
        private string celular;
        private string email;
        private Atencion[] atenciones = new Atencion[20];
        private int cantidad = 0;
        public string Rut
        {
            get { return rut; }
            set { rut = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Atencion this[int index]
        {
            get { return atenciones[index]; }
            set { atenciones[index] = value;
                cantidad++; }
        }


        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }


    }
}
