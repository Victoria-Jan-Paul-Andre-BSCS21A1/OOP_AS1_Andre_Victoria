using System;
using System.Collections.Generic;

namespace Pet_Inventory
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            List<Pet> pets = new List<Pet>(); // list to store all pet objects

            Console.WriteLine("Welcome to Pet Inventory! \n");

            while (true)
            {
                Pet pet = null;
                string choice;

                while (true)
                {
                    Console.Write("Enter a Kind (Dog, Cat, Bird, Lizard): ");
                    string kindInput = Console.ReadLine();

                    try
                    {
                        if (Enum.TryParse(kindInput, true, out Kind kind))
                        {
                            if (kind == Kind.Dog)
                            {
                                pet = new Dog();
                            }
                            else if (kind == Kind.Cat)
                            {
                                pet = new Cat();
                            }
                            else if (kind == Kind.Bird)
                            {
                                pet = new Bird();
                            }
                            else if (kind == Kind.Lizard)
                            {
                                pet = new Lizard();
                            }

                            pet.kind = kind;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid pet type input. Please enter a valid type.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }

                Console.Write($"Enter the {pet.kind}'s name: ");
                pet.animalName = Console.ReadLine();

                while (true)
                {
                    Console.Write("Enter Gender (Male or Female): ");
                    string genderInput = Console.ReadLine();

                    try
                    {
                        if (Enum.TryParse(genderInput, true, out Gender gender))
                        {
                            pet.gender = gender;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid gender input. Please enter Male or Female.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }

                if (pet is Dog dog)
                {
                    Console.Write("Enter Breed: ");
                    dog.SetBreed(Console.ReadLine());
                }
                else if (pet is Cat cat)
                {
                    Console.Write("Whiskers? (Yes or No): ");
                    cat.SetWhiskers(Console.ReadLine());
                }
                else if (pet is Lizard lizard)
                {
                    Console.Write("Venomous? (Yes or No): ");
                    lizard.SetVenom(Console.ReadLine());
                }
                else if (pet is Bird bird)
                {
                    Console.Write("Has Sharp Claws? (Yes or No): ");
                    bird.SetClaws(Console.ReadLine());
                }

                Console.Write("Enter the owner's name: ");
                pet.ownerName = Console.ReadLine();

                pets.Add(pet);

                Console.Write("Do you want to add more pets (yes/no): ");
                choice = Console.ReadLine();

                if (choice == "no")
                {
                    while (true)
                    {
                        Console.Write("What type of pets do you want to list (Dog, Cat, Bird, Lizard, All): ");
                        string listChoice = Console.ReadLine();

                        try
                        {
                            if (listChoice == "Dog")
                            {
                                Console.WriteLine($"\nList of {listChoice}s:");
                                foreach (var p in pets)
                                {
                                    if (p.kind == Kind.Dog)
                                    {
                                        Console.WriteLine(p.ToString());
                                    }
                                }
                                break;
                            }
                            else if (listChoice == "Cat")
                            {
                                Console.WriteLine($"\nList of {listChoice}s:");
                                foreach (var p in pets)
                                {
                                    if (p.kind == Kind.Cat)
                                    {
                                        Console.WriteLine(p.ToString());
                                    }
                                }
                                break;
                            }
                            else if (listChoice == "Lizard")
                            {
                                Console.WriteLine($"\nList of {listChoice}s:");
                                foreach (var p in pets)
                                {
                                    if (p.kind == Kind.Lizard)
                                    {
                                        Console.WriteLine(p.ToString());
                                    }
                                }
                                break;
                            }
                            else if (listChoice == "Bird")
                            {
                                Console.WriteLine($"\nList of {listChoice}s:");
                                foreach (var p in pets)
                                {
                                    if (p.kind == Kind.Bird)
                                    {
                                        Console.WriteLine(p.ToString());
                                    }
                                }
                                break;
                            }
                            else if (listChoice == "All")
                            {
                                Console.WriteLine($"\nList of {listChoice} Animals:");
                                foreach (var p in pets)
                                {
                                    Console.WriteLine(p.ToString());
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid option. Please enter Dog, Cat, Bird, Lizard, or All.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }
                }
            }
        }
    }
}