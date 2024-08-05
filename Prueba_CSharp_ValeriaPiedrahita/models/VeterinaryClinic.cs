using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_CSharp_ValeriaPiedrahita.models
{
    public class VeterinaryClinic
    {
        //se crean atributos
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Dog> Dogs { get; set; } = new List<Dog>();// se crea e inicializan listas
        public List<Cat> Cats { get; set; } = new List<Cat>();

        //constructor vacio de la clase

        VeterinaryClinic()
        {
        }


        // constructor lleno  de la clase
        public VeterinaryClinic(string name, string address)
        {
            Name = name;
            Address = address;
        }



        // crear menu
        public void Menu()
        {

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("=========================================================================================");
                Console.WriteLine("                           Centro de Veterinaria                                     ");
                Console.WriteLine("=========================================================================================");
                Console.WriteLine("                            Ingrese su opción:                                           ");
                Console.WriteLine("                             1. Save a Dog                                               ");
                Console.WriteLine("                             2. Save a cat                                               ");
                Console.WriteLine("                             3. Update Dog                                               ");
                Console.WriteLine("                             4. Update Cat                                               ");
                Console.WriteLine("                             5. Delete Dog                                               ");
                Console.WriteLine("                             6. Delete Cat                                               ");
                Console.WriteLine("                             7. Show All Patients                                        ");
                Console.WriteLine("                             8. Show Animals                                             ");
                Console.WriteLine("                             9. Show Paients                                             ");
                Console.WriteLine("                             0. Exit                                                     ");
                Console.WriteLine("=========================================================================================");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Dog newDog = ManagerApp.CreateDog();
                        SaveDog(newDog);
                        break;
                    case "2":
                        Cat newCat = ManagerApp.CreateCat();
                        SaveCat(newCat);
                        break;
                    case "3":
                        break;
                    default:
                        break;
                }


            }
        }


        // metodo guardas nueva mascota en la lista de mascotas
        public void SaveDog(Dog newDog)
        {
            Console.WriteLine("Perro guardado con éxito");
        }

        public void SaveCat(Cat newCat)
        {
            Console.WriteLine("Gato guardado con éxito");
        }


        //metodo editar perro
        public void UpdateDog(List<Dog> dogs, Guid Id)
        {
            var dogEdit = dogs.Find(d => d.GetId() == Id);
            if (dogEdit != null)
            {
                Console.WriteLine(@"Que dato de la mascota deseas editar:
                            1. weightInKg
                            2. breedingStatus
                            3. temperament
                            4. microShipNumber
                            5. coatType");
                string editar = Console.ReadLine();

                switch (editar)
                {
                    case "1":
                        Console.WriteLine("Ingrese el nuevo peso en Kg");
                        var newWeightInKg =Convert.ToDouble( Console.ReadLine());
                        dogEdit.SetWeightInKg(newWeightInKg);
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el nuevo estado de catracion");
                        var newbreedingStatus = Convert.ToBoolean(Console.ReadLine());
                        dogEdit.BreedingStatus = newbreedingStatus;
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el nuevo temperamento");
                        var newtemperament = Console.ReadLine().ToLower();
                        dogEdit.Temperament = newtemperament;
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el nuevo numero de microShip");
                        var newmicroShipNumber = Console.ReadLine();
                        dogEdit.MicroShipNumber = newmicroShipNumber;
                        break;
                    case "5":
                        Console.WriteLine("Ingrese la nueva longitud de pelo");
                        var newcoatType = Console.ReadLine().ToLower();
                        if (newcoatType!= "Sin pelo" && newcoatType!= "Pelo corto" && newcoatType != "Pelo mediano" &&  newcoatType != "Pelo largo".ToLower())
                        {
                            dogEdit.CoatType = newcoatType;
                        }
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }




    }
}