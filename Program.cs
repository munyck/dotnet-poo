using System;
using dotnet___poo.src.Entities;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero knight = new Hero("Arus", 42, "Knight");
            Ninja ninja = new Ninja("Wedge", 42, "Ninja");
            WhiteWizard whiteWizard = new WhiteWizard("Jenica", 42, "White Wizard");
            BlackWizard blackWizard = new BlackWizard("Topapa", 42, "Black Wizard");

            Console.WriteLine("Selecione o seu Personagem para jogar: ");
            Console.WriteLine("1 - " + knight);
            Console.WriteLine("2 - " + ninja);
            Console.WriteLine("3 - " + whiteWizard);
            Console.WriteLine("4 - " + blackWizard);

            var option = Console.ReadLine();

            switch (option){
                case "1":
                        Console.WriteLine("Você selecionou "+knight.Name);
                        break;
                case "2":
                        Console.WriteLine("Você selecionou "+ninja.Name);
                        break;
                case "3":
                        Console.WriteLine("Você selecionou "+whiteWizard.Name);
                        break;                
                case "4":
                        Console.WriteLine("Você selecionou "+blackWizard.Name);
                        break;
                default:
                        Console.WriteLine("Nenhum personagem selecionado.");
                        break;
            }
            Console.ReadKey();

        }
    }
}