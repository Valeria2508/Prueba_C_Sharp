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
        public static void Menu()
        {
            var veterinary = new VeterinaryClinic();
            var perro1 = new Dog("bruno", new DateOnly(2020, 02, 02), "sad", "sd", 19.6, true, "timido", "12", "sdf", "Sin largo");
            veterinary.SaveDog(perro1);

            bool exit = false;
            while (!exit)
            {
                ManagerApp.ShowHeader();
                

                Console.WriteLine("=========================================================================================");
                Console.WriteLine("                           Centro de Veterinaria                                     ");
                Console.WriteLine("=========================================================================================");
                ManagerApp.Separator();
                Console.WriteLine("                            Ingrese su opción:                                           ");
                Console.WriteLine("                             1. Save a Cat                                              ");
                Console.WriteLine("                             2. Save a Dog                                               ");
                Console.WriteLine("                             3. Show All Patients                                        ");
                Console.WriteLine("                             4. Update Dog                                               ");
                Console.WriteLine("                             5. Update Cat                                               ");
                Console.WriteLine("                             6. Delete Dog                                               ");
                Console.WriteLine("                             7. Delete Cat                                               ");
                Console.WriteLine("                             8. Show Animals                                             ");
                Console.WriteLine("                             9. Show Paients                                             ");
                Console.WriteLine("                             10. CastrateAnimal                                          ");
                Console.WriteLine("                             11. ShowHeader                                              ");
                Console.WriteLine("                             0. Exit                                                     ");
                Console.WriteLine("=========================================================================================");

                ManagerApp.ShowFooter();


                string option = Console.ReadLine(); // variable para saber la respuesta del usuario

                switch (option)
                {
                    case "1":
                        veterinary.SaveCat(ManagerApp.CreateCat());
                        PausarMenu();
                        break;
                    case "2":
                        veterinary.SaveDog(ManagerApp.CreateDog());
                        PausarMenu();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el Id para editar el perro");
                        Guid idDogToEdit = Guid.Parse(Console.ReadLine());
                        veterinary.UpdateDog(veterinary.Dogs, idDogToEdit);
                        PausarMenu();

                        break;
                    case "4":
                        Console.WriteLine("Ingrese el Id para editar el gato");
                        Guid idCatToEdit = Guid.Parse(Console.ReadLine());
                        veterinary.UpdateCat(veterinary.Cats, idCatToEdit);
                        PausarMenu();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el Id para eliminar el perro");
                        Guid idDogToDelete = Guid.Parse(Console.ReadLine());
                        veterinary.DeleteDog(veterinary.Dogs, idDogToDelete);
                        PausarMenu();

                        break;
                    case "6":
                        Console.WriteLine("Ingrese el Id para eliminar el gato");
                        Guid idCatToDelete = Guid.Parse(Console.ReadLine());
                        veterinary.DeleteCat(veterinary.Cats, idCatToDelete);
                        PausarMenu();
                        break;
                    case "7":
                        veterinary.ShowAllPatients();
                        PausarMenu();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese el tipo de animal que quiera encontrar (perro, gato)");
                        string animalToFind = Console.ReadLine();
                        veterinary.ShowAnimals(animalToFind);
                        PausarMenu();
                        break;
                    case "9":
                        Console.WriteLine("Ingrese el id del paciente");
                        var patientId = Guid.Parse(Console.ReadLine());
                        veterinary.ShowPaient(patientId);
                        PausarMenu();
                        break;
                    case "10":
                        perro1.CastrateAnimal();
                        PausarMenu();
                        break;
                    case "11":
                        perro1.Hairdress();
                        PausarMenu();
                        break;
                    default:
                        break;
                }


            }
        }


        // metodo guardas nueva mascota en la lista de mascotas
        public void SaveDog(Dog newDog)
        {
            Dogs.Add(newDog);
            Console.WriteLine("Perro guardado con éxito");
        }

        public void SaveCat(Cat newCat)
        {
            Cats.Add(newCat);
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
                        var newWeightInKg = Convert.ToDouble(Console.ReadLine());
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
                        if (newtemperament != "timido" && newtemperament != "normal" && newtemperament != "agresivo".ToLower()) // se realizan validaciones con un ifelse
                        {
                            Console.WriteLine("Opcion inválida");
                        }
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
                        if (newcoatType != "Sin pelo" && newcoatType != "Pelo corto" && newcoatType != "Pelo mediano" && newcoatType != "Pelo largo".ToLower())
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
        //metodo para editar gato
        public void UpdateCat(List<Cat> cats, Guid Id)
        {
            var catEdit = cats.Find(d => d.GetId() == Id);
            if (catEdit != null)
            {
                Console.WriteLine(@"Que dato de la mascota deseas editar:
                            1. weightInKg
                            2. breedingStatus
                            5. FurLenght");
                string editar = Console.ReadLine();

                switch (editar)
                {
                    case "1":
                        Console.WriteLine("Ingrese el nuevo peso en Kg");
                        var newWeightInKg = Convert.ToDouble(Console.ReadLine());
                        catEdit.SetWeightInKg(newWeightInKg);
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el nuevo estado de catracion (true/false)");
                        var newbreedingStatus = Convert.ToBoolean(Console.ReadLine());
                        catEdit.BreedingStatus = newbreedingStatus;
                        break;

                    case "3":
                        Console.WriteLine("Ingrese la nueva longitud de pelo");
                        var newFurLenght = Console.ReadLine().ToLower();
                        if (newFurLenght != "Sin pelo" && newFurLenght != "Pelo corto" && newFurLenght != "Pelo mediano" && newFurLenght != "Pelo largo".ToLower())
                        {
                            catEdit.FurLenght = newFurLenght;
                        }
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }
        //metodo eliminar perro por id
        public void DeleteDog(List<Dog> dogs, Guid Id)
        {
            Console.WriteLine("Ingrese el Id de su perro");
            var dogDelete = dogs.Find(d => d.GetId() == Id);
            if (dogDelete != null)
            {
                dogs.Remove(dogDelete);
                Console.WriteLine("Perro eliminado con éxito");
            }
        }
        //metodo eliminar gato por id
        public void DeleteCat(List<Cat> cats, Guid Id)
        {
            Console.WriteLine("Ingrese el Id de su gato");
            var catDelete = cats.Find(d => d.GetId() == Id);
            if (catDelete != null)
            {
                cats.Remove(catDelete);
                Console.WriteLine("Gato eliminado con éxito");
            }
        }
        //metodo mostrar todos los pacientes
        public void ShowAllPatients()
        {
            foreach (var dog in Dogs)
            {
                dog.ShowInforacion();
                ManagerApp.Separator();
            }
            foreach (var cat in Cats)
            {
                cat.ShowInforacion();
                ManagerApp.Separator();
            }

        }
        //metodo mostrar animales por tipo
        public void ShowAnimals(string type)
        {
            if (type == "Perro".ToLower())
            {
                foreach (var dog in Dogs)
                {
                    dog.ShowInforacion();
                    ManagerApp.Separator();
                }
            }
            else if (type == "Gato".ToLower())
            {
                foreach (var cat in Cats)
                {
                    cat.ShowInforacion();
                    ManagerApp.Separator();
                }
            }
            else
            {
                Console.WriteLine("Tipo de animal invalido");
            }
        }
        //metodo mostrar paciente por id
        public void ShowPaient(Guid Id)
        {
            var dog = Dogs.Find(d => d.GetId() == Id);
            if (dog != null)
            {
                dog.ShowInforacion();
                ManagerApp.Separator();
            }
            else
            {
                var cat = Cats.Find(c => c.GetId() == Id);
                if (cat != null)
                {
                    cat.ShowInforacion();
                    ManagerApp.Separator();
                }
                else
                {
                    Console.WriteLine("Mascota no encontrada");
                    ManagerApp.Separator();
                }
            }
        }
        //metodo pausar menu
        public static void PausarMenu()
        {
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadKey();

        }

    }
}