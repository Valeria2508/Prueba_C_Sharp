using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_CSharp_ValeriaPiedrahita.models
{
    public abstract class Animal
    {   
        //se crean atributos protegidos
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected DateOnly Birthdate { get; set; }
        protected string Breed  { get; set; }
        protected string Color { get; set; }
        protected double WeightInKg { get; set; }

        //constructor de la clase

        public Animal(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg)
        {
            Id = id;
            Name = name;
            Birthdate = birthdate;
            Breed = breed;
            Color = color;
            WeightInKg = weightInKg;
        }

        //metodo abracto para mostrar infacion de la mascota, dog and cat
        public abstract void ShowInforacion();

        protected void BasicReview(){
            Console.WriteLine(@$"
            the dog that answers to the name {Name}, he is {CalculateAgeInMonths()} years old
            and is a {Breed} breed. He has a {Color} color, with very particular green spots. and weighs {WeightInKg} kg.");

        }
        // metodo para calcular edad del animal, se ve reflejada en el metodo ShowInforacion en dog and cat
        protected int CalculateAgeInMonths(){
            DateOnly CurrentDate = DateOnly.FromDateTime(DateTime.Now);//resta la fecha actual con la fecha de nacimiento
            int age = CurrentDate.Month - Birthdate.Month;
            return age;//devuelve la edad
        }


    }
}