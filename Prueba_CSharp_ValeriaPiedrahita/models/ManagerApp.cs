using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;

namespace Prueba_CSharp_ValeriaPiedrahita.models
{
    public class ManagerApp
    {   
        //metodo para crear un perro
        public static Dog CreateDog(){
            // se solicitan los datos al usuario y se guardan en variables
            Console.WriteLine("Por favor ingrese los siguientes datos del perro");
            Console.WriteLine("Ingrese el id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre");
            string name = Console.ReadLine(); 
            Console.WriteLine("Ingrese la fecha de nacimiento (YYYY-MM-DD)");
            DateOnly birthdate = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de raza");
            string breed = Console.ReadLine();
            Console.WriteLine("Ingrese el color");
            string color = Console.ReadLine();
            Console.WriteLine("Ingrese el peso en kilogramos");
            double weightInKg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese si el perro se encuentra en estado de castración (true/false)");
            bool breedingStatus = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de temperamento(Tímido, Normal o Agresivo. )".ToLower());
            string temperament = Console.ReadLine().ToLower();  // se convierte a minúsculas para comparar con los valores posibles.
            if (temperament != "Timido" && temperament != " Normal" && temperament != "Agresivo") // se realizan validaciones con un ifelse
            {
                Console.WriteLine("Opcion inválida");
                return CreateDog();
            }

            Console.WriteLine("Ingrese el número de microchip");
            string microShipNumber = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Ingrese que tan fuerte lagra".ToLower());
            string barkVolume = Console.ReadLine();

            Console.WriteLine("Ingrese el tipo de pelo (Sin pelo, Pelo corto, Pelo mediano, Pelo largo.)".ToLower());
            string coatType = Console.ReadLine();
            if (coatType!= "Sin pelo" && coatType!= "Pelo corto" && coatType != "Pelo mediano" &&  coatType != "Pelo largo".ToLower())
            {
                Console.WriteLine("Opcion inválida");
                return CreateDog();
            }// se realizan validaciones con un ifelse para validar que el usuario este ingresando bien los datos

            return new Dog(id, name, birthdate, breed, color, weightInKg, breedingStatus, temperament, microShipNumber, barkVolume, coatType);// se retorna una instancia
        }

        public static Cat CreateCat(){
            Console.WriteLine("Por favor ingrese los siguientes datos del gato");
            Console.WriteLine("Ingrese el id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre");
            string name = Console.ReadLine(); 
            Console.WriteLine("Ingrese la fecha de nacimiento (YYYY-MM-DD)");
            DateOnly birthdate = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de raza");
            string breed = Console.ReadLine();
            Console.WriteLine("Ingrese el color");
            string color = Console.ReadLine();
            Console.WriteLine("Ingrese el peso en kilogramos");
            double weightInKg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese si el gato se encuentra en estado de castración (true/false)");
            bool breedingStatus = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Ingrese la longitud del pelo (Sin pelo, Pelo corto, Pelo mediano, Pelo largo)");
            string furLenght = Console.ReadLine();

            return new Cat(id, name, birthdate, breed, color, weightInKg, breedingStatus, furLenght);
        }

        public static void ShowHeader(){
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Bienvenid@ al sistema de Centro de Veterinaria");
            Console.WriteLine("------------------------------------------------");
        } 

        public static void ShowFooter(){
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("        Gracias por utilizar nuestro sistema    ");
            Console.WriteLine("------------------------------------------------");
        }

        public static void Separator(){
            Console.WriteLine("------------------------------------------------");
        }
    }
}