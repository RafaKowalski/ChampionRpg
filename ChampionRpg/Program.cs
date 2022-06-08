using System;
using ChampionRpg.Entities;

namespace ChampionProgram;

public class Program
{
    public static void Main(string[] args)
    {

        Champion championOne = new Champion("Rafael", 50, 10, 2);

        Champion championTwo = new Champion("GustavinhoGamePlays", 40, 5, 2);

        Console.Clear();
        Console.WriteLine(championOne);
        Console.WriteLine();
        Console.WriteLine(championTwo);

        Console.WriteLine("Atacando adversário: ");

        championOne.LosingHp(championTwo, championOne.Attack);

        int count = 0;
        while (true)
        {
            if (championOne.Hp <= 0 || championTwo.Hp <= 0)
                break;

            Console.WriteLine($"Turno {count}");
            championOne.LosingHp(championTwo, championOne.Attack);
            championTwo.LosingHp(championOne, championTwo.Attack);

            Console.WriteLine("Hp pós turno: " + championOne.Hp + " " + championTwo.Hp);
            count++;
        }

        if (championOne.Hp == 0)
            Console.WriteLine("Vencendor Campeao dois! " + championTwo);
        else
            Console.WriteLine("Vencendor Camepao um! " + championOne);
    }
}