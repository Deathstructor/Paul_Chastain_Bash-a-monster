using System;
using System.Threading;

mainGame();

void mainGame()
{
    Player player = new();
    Enemy enemy = new();

    Random rdm = new Random();

    Console.WriteLine("Player HP: " + player.HP);
    Console.WriteLine("Enemy HP: " + enemy.HP);
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Thread.Sleep(2000);

    while (player.HP > 0 && enemy.HP > 0)
    {
        player.damage = 10;
        enemy.damage = 10;

        //Random crit chance
        if (rdm.Next(10) >= 7)
        {
            player.damage = player.damage + player.damage * 0.5;
        }
        if (rdm.Next(10) >= 7)
        {
            enemy.damage = enemy.damage + enemy.damage * 0.5;
        }

        player.HP -= (int) enemy.damage;
        enemy.HP -= (int) player.damage;
        
        if (player.HP < 0)
        {
            player.HP = 0;
        }
        else if (enemy.HP < 0)
        {
            enemy.HP = 0;
        }

        Console.WriteLine("Player HP: " + player.HP);
        Console.WriteLine("Player Damage: " + player.damage);
        Console.WriteLine();
        Console.WriteLine("Enemy HP: " + enemy.HP);
        Console.WriteLine("Enemy Damage: " + enemy.damage);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Thread.Sleep(2000);
    }

    if (enemy.HP == 0)
    {
        Console.WriteLine("Player has won!");
    } else {
        Console.WriteLine("Enemy has won!");
    }
    
    Console.WriteLine("Press any key to exit");
    Console.ReadLine();
}