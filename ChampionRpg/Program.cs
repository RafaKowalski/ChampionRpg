﻿using System;
using System.Collections.Generic;
using ChampionRpg.Entities;

namespace ChampionProgram;

public class Program
{
    public static void Main(string[] args)
    {

        Champion championOne = new Champion("Rafael", 50, 10, 2);
        Item itemOne = new Item("HealthPotion", 2);
        Champion championTwo = new Champion("GustavinhoGamePlays", 40, 5, 2);
        Item itemTwo = new Item();
        Inventory inventoryOne = new Inventory();

        List<Item> list = new List<Item>();

        list.Add(new Item("HealthPotin", 2));
        list.Add(new Item("AttackPotion", 3));

        foreach (Item item in list)
            Console.WriteLine(item);

        Console.Clear();
        Console.WriteLine(championOne);
        Console.WriteLine();
        Console.WriteLine(championTwo);
        Console.WriteLine();



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

        /*if (championOne.Hp == 0)
            Console.WriteLine("Vencendor Campeao dois! " + championTwo.Name);
        else
            Console.WriteLine("Vencendor Campeao Um! " + championOne.Name);*/
    }
}