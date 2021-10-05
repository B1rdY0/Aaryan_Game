using System;
using System.Threading;

int PLHP = 1000;
int BOSS1HP = 1000;

int crit_dmg_kniv = 250;
int kniv_dmg = 100;
int stol_dmg = 50;
int crit_dmg_stol = 150;
int insta_kill = 1000;


test.test_1();

Random generator = new Random();


Console.WriteLine($"You have {PLHP}hp");
Thread.Sleep(1500);
System.Console.WriteLine($"your fighting Moon lord and has {BOSS1HP}");
Thread.Sleep(1500);
Console.WriteLine(@" _________         .    .
(..       \_    ,  |\  /|
 \       O  \  /|  \ \/ /
  \______    \/ |   \  / 
     vvvv\    \ |   /  |
     \^^^^  ==   \_/   |
      `\_   ===    \.  |
      / /\_   \ /      |
      |/   \_  \|      /
         \________/"); // the boss in pic 
Thread.Sleep(1500);
System.Console.WriteLine($"Choose your weapon a) kniv  b) stol c) mouse");



string answer = "Kniv";
answer = Console.ReadLine();
answer.ToLower();

if (answer == "kniv")
{
    System.Console.WriteLine($"You have a 80% for a normal hit or 20% for a critical hit ");
    Thread.Sleep(1500);
    int chance = generator.Next(10);
    //crit
    if (chance <= 1)
    {
        Console.WriteLine($"well done u did critical damage");
        Thread.Sleep(1500);
        BOSS1HP -= crit_dmg_kniv;
        Thread.Sleep(1500);
        System.Console.WriteLine($"BOSS HP is {BOSS1HP} HP");

    }
    //ej crit
    if (chance >= 2)
    {
        System.Console.WriteLine($"u used Kniv");
        Thread.Sleep(1500);
        BOSS1HP -= kniv_dmg;
        Thread.Sleep(1500);
        System.Console.WriteLine($"BOSS HP is {BOSS1HP} HP");
    }
}


if (answer == "stol")
{
    Console.WriteLine($"Sure... well u have 90 % for a normal hit but you have only 10 % for a crtit");
    int chanse_2 = generator.Next(10);
    //crit 
    if (chanse_2 <= 0.5)
    {
        System.Console.WriteLine($"Idk how did it but damn u did critical dmg");
        Thread.Sleep(1500);
        BOSS1HP -= crit_dmg_stol;
        Thread.Sleep(1500);
        System.Console.WriteLine($"the boss has {BOSS1HP} HP");
    }
    //ej crit 
    if (chanse_2 >= 1.5)
    {
        Console.WriteLine($"well that was not very effectiv was it now :)");
        Thread.Sleep(1500);
        BOSS1HP -= stol_dmg;
        Thread.Sleep(1500);
        System.Console.WriteLine($"the boss has {BOSS1HP} HP");
    }
}


if (answer == "mouse")
{
    System.Console.WriteLine("well to be honest u won gg");
    int chanse_3 = generator.Next(10);
    //crit 
    if (chanse_3 <= 10)
    {
        Console.WriteLine($"to be expected u did choose the right one ig");
        Thread.Sleep(1500);
        BOSS1HP -= insta_kill;
        Thread.Sleep(1500);
        Console.WriteLine($"GG the boss has {BOSS1HP} HP");
    }
}









Console.ReadLine();
