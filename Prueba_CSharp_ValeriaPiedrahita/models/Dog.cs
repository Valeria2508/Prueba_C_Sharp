using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_CSharp_ValeriaPiedrahita.models
{
    public class Dog : Animal
    {   // se crena atributos
        public bool BreedingStatus { get; set; }
        public string Temperament { get; set; }
        public string MicroShipNumber { get; set; }
        public string BarkVolume { get; set; }
        public string CoatType { get; set; }

        //se crea constructor
        public Dog(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg, bool breedingStatus, string temperament, string microShipNumber, string barkVolume, string coatType): base(id, name, birthdate, breed, color, weightInKg)
        {
            BreedingStatus = breedingStatus;
            Temperament = temperament;
            MicroShipNumber = microShipNumber;
            BarkVolume = barkVolume;
            CoatType = coatType;
        }

        public void CreateAnimal (){

        }

        public void Hairdress(){

        }



    }
}