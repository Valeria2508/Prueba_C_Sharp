using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_CSharp_ValeriaPiedrahita.models
{
    public abstract class Animal
    {   
        //se crean atributos protegidos
        protected Guid Id { get; set; }
        protected string Name { get; set; }
        protected DateOnly Birthdate { get; set; }
        protected string Breed  { get; set; }
        protected string Color { get; set; }
        protected double WeightInKg { get; set; }

        //constructor de la clase

        public Animal(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg)
        {
            Id = Guid.NewGuid();
            Name = name;
            Birthdate = birthdate;
            Breed = breed;
            Color = color;
            WeightInKg = weightInKg;
        }

        //metodo abracto para mostrar infacion de la mascota, dog and cat
        public abstract void ShowInforacion();

        // metodo para mostrar una breve informacion de la mascota
        protected void BasicReview(){
            Console.WriteLine("Ingresa una descripcion breve de como ingresó su mascota a la veterinaria");
            string desc = Console.ReadLine();

            Console.WriteLine($"La descripcion de la mascota al ingresar a la veterinaria: {desc}");

        }
        // metodo para calcular edad del animal, se ve reflejada en el metodo ShowInforacion en dog and cat
        protected int CalculateAgeInMonths(){
            DateOnly CurrentDate = DateOnly.FromDateTime(DateTime.Now);//resta la fecha actual con la fecha de nacimiento
            int age = CurrentDate.Month - Birthdate.Month;
            return age;//devuelve la edad
        }

        public Guid  GetId(){
            return Id;
        }


    }
}