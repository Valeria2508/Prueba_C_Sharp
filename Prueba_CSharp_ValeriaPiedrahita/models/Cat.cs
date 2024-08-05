using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_CSharp_ValeriaPiedrahita.models
{
    public class Cat
    {   
        //se crean atributos
        public bool BreedingStatus { get; set; }
        public string FurLenght { get; set; }

        // constructor de la clase  
        public Cat(bool breedingStatus, string furLenght)
        {
            BreedingStatus = breedingStatus;
            FurLenght = furLenght;
        }

        public void CreateAnimal(){

        }

        public void Hairdress(){

        }



    }
}