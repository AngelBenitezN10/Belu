using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Loro
    {
        private string _memoria = "";
        private short _edad;
        
        public short Edad { get=>_edad; }

        public DateTime FechaNacimiento { get; set; }

        public string Nombre { get; set; }

        public Loro() { }
        


        public ushort CalcularEdad(DateTime nacimiento)
        {
             return (ushort)(DateTime.Now.Year-nacimiento.Year);
        }

        public void Escuchar(string Frase)
        {
            _memoria += Frase;
        }

        public string Hablar()
        {
            return _memoria;
        }

        public override string ToString()
        {
            return $"{Nombre}";
        }
    }
}
