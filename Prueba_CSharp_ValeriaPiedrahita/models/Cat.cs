using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_CSharp_ValeriaPiedrahita.models
{
    public class Cat : Animal
    {
        //se crean atributos
        public bool BreedingStatus { get; set; }
        public string FurLenght { get; set; }

        // constructor de la clase  
        public Cat(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg, bool breedingStatus, string furLenght) : base(id, name, birthdate, breed, color, weightInKg)
        {
            BreedingStatus = breedingStatus;
            FurLenght = furLenght;
        }

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
            Fur Lenght: {FurLenght} cm");
        }

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

        public void Hairdress(){
            if (FurLenght == "largo" || FurLenght == "muy largo")
            {
                Console.WriteLine("Se peluqieó al gato");
            }else
            {
                Console.WriteLine("No se puede peluquear al gato ya que  no tiene pelaje");
            }
        }


    }
}