using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder;

public class GamePlay
{
    int rollDice, playerPosition = 0, playerPosition1 = 0, playerPosition2 = 0;
    int count = 0;
    public void Start()
    {
        Console.WriteLine("Game is Start:" + playerPosition);
    }

    //UC2
    public void RollDice()
    {
        int playerPos = 0, rollDice;
        Random random = new Random();
        rollDice = random.Next(1, 7);
        Console.WriteLine("Rolled Dice number is:" + rollDice);
    }

    //UC3
    public void CheckingPlayerPosition()
    {
        int playerPosition = 0, rollDice;
        Random random = new Random();
        rollDice = random.Next(1, 6);
        Console.WriteLine("Rolled Dice number is:" + rollDice);
        Console.WriteLine("Player Option 1.No Play 2.Ladder 3.Snake");
        var list = new List<string> { "No Play", "Ladder", "Snake" };
        int pos = random.Next(list.Count);
        if (list[pos] == "Ladder")
        {
            playerPosition += rollDice;
        }
        else if (list[pos] == "Snake")
        {
            playerPosition -= rollDice;
        }
        Console.WriteLine("Player option:" + list[pos]);
        Console.WriteLine("Player updated position:" + playerPosition);
    }

    //UC4
    public void PlayerPositionZeroRestart()
    {
        int rollDice, playerPosition = 0;
        Random random = new Random();

        //List to check options
        var list = new List<string> { "No Play", "Ladder", "Snake" };

        //Conditions for user options
        rollDice = random.Next(1, 6);
        Console.WriteLine("Dice number is : " + rollDice);
        Console.WriteLine("Player checks options 1.No Play  2.Ladder  3.Snake");

        //Use random to check user option
        int index = random.Next(list.Count);
        Console.WriteLine("Player option is : " + list[index]);
        if (playerPosition + rollDice < 100)
        {
            if (list[index] == "Ladder") playerPosition += rollDice;
            if (list[index] == "Snake") playerPosition -= rollDice;
        }

        if (playerPosition < 0)
        {
            playerPosition = 0;
        }
        Console.WriteLine("Player current position : " + playerPosition);
        Console.WriteLine("Final position is :" + playerPosition);
    }

}
