using System.Security;
using System;
using System.Threading.Tasks;

mainGame();

void mainGame()
{
    Player player = new();
    Enemy enemy = new();

    Random rdm = new Random();


    while (player.HP > 0 || enemy.HP > 0)
    {
        Console.WriteLine("Player HP: " + player.hp);
        
        //Random crit chance
        if (rdm.Next(10) >= 7)
        {
            player.damage = player.damage + player.damage * 0.5;
        }
        if (rdm.Next(10) >= 7)
        {
            enemy.damage = enemy.damage + enemy.damage * 0.5;
        }

        if (player.HP < 0)
        {
            player.HP = 0;
        }
        else if (enemy.HP < 0)
        {
            enemy.HP = 0;
        }

        player.HP -= (int) enemy.damage;
        enemy.HP -= (int) player.damage;
    }

    Console.ReadLine();
}