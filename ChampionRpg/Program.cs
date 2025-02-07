using System;
using System.Collections.Generic;
using ChampionRpg.Entities;
using ChampionRpg.Entities.Exceptions;

namespace ChampionProgram;

public class Program
{
    public static void Main(string[] args)
    {
        Champion championOne = new("Rafael");
        Item itemOne = new Item();
        Champion championTwo = new("GustavinhoGamePlays");
        Item itemTwo = new Item();

        try
        {
            Console.WriteLine($"{championOne.Name} escolha uma classe: human/orc/elf/dwarf");
            string classeOne = Console.ReadLine();

            switch (classeOne)
            {
                case "human":
                    Human human = new Human();
                    human.EscolhendoClasseHuman(championOne);
                    break;

                case "orc":
                    Orc orc = new Orc();
                    orc.EscolhendoClasseOrc(championOne);
                    break;

                case "elf":
                    Elf elf = new Elf();
                    elf.EscolhendoClasseElf(championOne);
                    break;

                case "dwarf":
                    Dwarf dwarf = new Dwarf();
                    dwarf.EscolhendoClasseDwarf(championOne);
                    break;

                default:
                    throw new DomainException("Opção digitada incorretamente");
            }
        }
        catch (DomainException message)
        {
            Console.WriteLine("Error: " + message.Message);
        }

        try
        {
            Console.WriteLine($"{championTwo.Name} escolha uma classe: human/orc/elf/dwarf");
            string classeTwo = Console.ReadLine();

            switch (classeTwo)
            {
                case "human":
                    Human human = new Human();
                    human.EscolhendoClasseHuman(championTwo);
                    break;

                case "orc":
                    Orc orc = new Orc();
                    orc.EscolhendoClasseOrc(championTwo);
                    break;

                case "elf":
                    Elf elf = new Elf();
                    elf.EscolhendoClasseElf(championTwo);
                    break;

                case "dwarf":
                    Dwarf dwarf = new Dwarf();
                    dwarf.EscolhendoClasseDwarf(championTwo);
                    break;

                default:
                    throw new DomainException("Opção digitada incorretamente");
            }
        }
        catch (DomainException message)
        {
            Console.WriteLine("Error: " + message.Message);
        }

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