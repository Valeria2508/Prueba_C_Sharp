using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_CSharp_ValeriaPiedrahita.models
{
    public class ManagerApp
    {
        public static Dog CreateDog(){
            return new Dog(1, "Buddy", new DateOnly(2012, 1, 15), "Golden", "Blanco y negro", 4.5, false, "Timido","32","fuerte","pelo mediano");
        }

        public static Cat CreateCat(){
            return new Cat(1, "mia", new DateOnly(2015, 2, 2), "Persa", "Blanco", 32, true, "Pelo largo");
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