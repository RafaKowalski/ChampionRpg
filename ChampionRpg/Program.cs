using System;
using ChampionRpg.Entities;

namespace ChampionProgram;

public class Program
{
    public static void Main(string[] args)
    {
        Champion championOne, championTwo;

        Console.WriteLine("Digite o nome do primeiro campeao: ");
        string nameOne = Console.ReadLine();

        Console.WriteLine("Digite a quantidade de pontos vitais do primeiro campeao: ");
        int hpOne = int.Parse(Console.ReadLine());

        championOne = new Champion(nameOne, hpOne);

        Console.WriteLine("Digite o nome do segundo campeao: ");
        string nameTwo = Console.ReadLine();

        Console.WriteLine("Digite a quantidade de pontos vitais do segundo campeao: ");
        int hpTwo = int.Parse(Console.ReadLine());

        championTwo = new Champion(nameTwo, hpTwo);

        Console.WriteLine(championOne);
        Console.WriteLine(championTwo);
    }
}