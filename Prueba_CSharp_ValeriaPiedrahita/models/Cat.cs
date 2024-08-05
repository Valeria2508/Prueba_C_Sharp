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
        public Cat(string name, DateOnly birthdate, string breed, string color, double weightInKg, bool breedingStatus, string furLenght) : base( name, birthdate, breed, color, weightInKg) //el base ya que el padre tambien tiene constructor
        {
            BreedingStatus = breedingStatus;
            FurLenght = furLenght;
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
            Fur Lenght: {FurLenght} cm");
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
                BreedingStatus = false;
            }
        }
        //se crea metodo con validacion para ver si se peluquea a la mascota
        public void Hairdress(){
            if (FurLenght == "Sin pelo")
            {
                Console.WriteLine("No se puede peluquear al gato ya que  no tiene pelaje");
            }else
            {
                Console.WriteLine("Se peluqieó al gato");
            }
        }


    }
}