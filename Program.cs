using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class persona
    {
        //Campos
        private string _nombre;
        private string _apellido;
        public string Correo { get; set; }


        //Propiedades 
        public string Apellido { get => _apellido; set => _apellido = value; }

        public string Nombre
        {
            get => _nombre; 
            set
            {
                if (value == "")
                {
                    _nombre = "Fulano de tal" ;

                    else  _nombre = value;
                      

                }
            }
        }
   

      
        /*
        public string Nombre
        {
            get => Nombre1;

            set => Nombre1 = value;
        }
       */

        public string getNombre()
        {
            return Nombre;
        }

       // public string Nombre => _nombre;


        public void setNombre(string n)
        {
            Nombre = n;
        }

        }
    class Program
    {
        static void Main(string[] args)
        {
            persona ana = new persona();

            // ana.setNombre("Ana"); 
            ana.Nombre = "Ana";

            Console.WriteLine($"Nombre: {ana.Nombre}");

            Console.ReadKey();
        }
    }
}
