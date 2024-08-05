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
        public Dog(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg, bool breedingStatus, string temperament, string microShipNumber, string barkVolume, string coatType) : base(id, name, birthdate, breed, color, weightInKg) //el base ya que el padre tambien tiene constructor
        {
            BreedingStatus = breedingStatus;
            Temperament = temperament;
            MicroShipNumber = microShipNumber;
            BarkVolume = barkVolume;
            CoatType = coatType;
        }

        // se hereda metodo de la clase animal
        public override void ShowInforacion()
        {
            Console.WriteLine(@$"
            Information of animal
            Id: {Id}
            Name: {Name}
            Breed: {Breed}
            Color: {Color}
            Weight: {WeightInKg}kg
            Age: {CalculateAgeInMonths()} months
            Breeding Status: {BreedingStatus}
            Temperament: {Temperament}
            Microship Number: {MicroShipNumber}
            Bark Volume: {BarkVolume}
            Coat Type: {CoatType}");
        }

        // se crea metodo con validacion para ver si se castró al animal
        public void CastrateAnimal()
        {
            if (BreedingStatus == false)
            {
                Console.WriteLine("El animal YA se encuentra castrado, no se puede reproducir");
            }
            else
            {
                Console.WriteLine("El animal aun NO se encuentra castrado, aun se puede reproducir");
                BreedingStatus = true;
            }
        }

        //se crea metodo con validacion para ver si se peluquea a la mascota
        public void Hairdress()
        {   
            if (CoatType == "Sin pelo" || CoatType == "Pelo corto".ToLower())
            {
                Console.WriteLine("No se puede peluquear el perro ya que tiene el cabello corto");
            }else
            {
                Console.WriteLine("Se le corto el cabello al perro");
            }

        }

    }
}