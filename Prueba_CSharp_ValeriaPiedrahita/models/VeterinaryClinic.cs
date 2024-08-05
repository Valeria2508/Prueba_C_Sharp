using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_CSharp_ValeriaPiedrahita.models
{
    public class VeterinaryClinic
    {   
        //se crean atributos
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Dog> Dogs { get; set; }= new List<Dog>();// se crea e inicializan listas
        public List<Cat> Cats { get; set; } = new List<Cat>();


        // constructor de la clase
        public VeterinaryClinic(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public void SaveDog(Dog newDog){
            
        }


    }
}