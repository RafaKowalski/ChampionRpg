using System;
using System.Collections.Generic;
using ChampionRpg.Entities;
using ChampionRpg.Entities.Exceptions;

namespace ChampionProgram;

public class Program
{
    public static void Main(string[] args)
    {
        Champion championOne = new Champion("Rafael");
        Item itemOne = new Item();
        Champion championTwo = new Champion("GustavinhoGamePlays");
        Item itemTwo = new Item();

        Console.WriteLine($"{championOne.Name} escolha uma classe: human/orc");
        string classeOne = Console.ReadLine();

        if (classeOne == "human")
            championOne.EscolhendoClasseHuman(championOne);
        else
            championOne.EscolhendoClasseOrc(championOne);

        Console.WriteLine($"{championTwo.Name} escolha uma classe: human/orc");
        string classeTwo = Console.ReadLine();

        if (classeTwo == "human")
            championTwo.EscolhendoClasseHuman(championTwo);
        else
            championTwo.EscolhendoClasseOrc(championTwo);

        Console.Clear();
        Console.WriteLine(championOne);
        Console.WriteLine();
        Console.WriteLine(championTwo);
        Console.WriteLine();

        try
        {
            int count = 1;
            while (true)
            {
                if (championOne.Hp <= 1 || championTwo.Hp <= 1)
                    break;

                Console.WriteLine();
                Console.WriteLine($"Turno {count}");
                Console.WriteLine($"{championOne.Name} joga \n");
                championOne.Choice(championOne.Name, championTwo, championOne.Attack, itemOne, championOne);

                Console.WriteLine("Hp pós turno: " + championOne.Hp + " " + championTwo.Hp);
                Console.WriteLine("Ataque pós turno: " + championOne.Attack + " " + championTwo.Attack);

                if (championTwo.Hp <= 0)
                {
                    Console.WriteLine("Vencendor Campeao Um! " + championOne.Name);
                    break;
                }

                count++;

                Console.WriteLine();
                Console.WriteLine($"Turno {count}");
                Console.WriteLine($"{championTwo.Name} joga \n");
                championTwo.Choice(championTwo.Name, championOne, championTwo.Attack, itemTwo, championTwo);

                Console.WriteLine("Hp pós turno: " + championOne.Hp + " " + championTwo.Hp);
                Console.WriteLine("Ataque pós turno: " + championOne.Attack + " " + championTwo.Attack);

                if (championOne.Hp <= 0)
                {
                    Console.WriteLine("Vencendor Campeao Dois! " + championTwo.Name);
                    break;
                }
                count++;
            }
        }
        catch (DomainException message)
        {
            Console.WriteLine("Error: " + message.Message);
        }
    }
}