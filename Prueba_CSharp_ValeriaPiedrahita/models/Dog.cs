using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_CSharp_ValeriaPiedrahita.models
{
    public class Dog
    {
        public bool BreedingStatus { get; set; }
        public string Temperament { get; set; }
        public string MicroShipNumber { get; set; }
        public string BarkVolume { get; set; }
        public string CoatType { get; set; }

        public Dog(bool breedingStatus, string temperament, string microShipNumber, string barkVolume, string coatType)
        {
            BreedingStatus = breedingStatus;
            Temperament = temperament;
            MicroShipNumber = microShipNumber;
            BarkVolume = barkVolume;
            CoatType = coatType;
        }

        
    }
}