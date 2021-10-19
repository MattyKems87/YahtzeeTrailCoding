using System;
using System.Collections.Generic;
using System.Linq;

namespace YahtzeeTrailCoding
{
    public static class YahtzeeService
    {
        public static YahtzeeRound PlayRound(int numberOfDice, int numberOfSides)
        {
            List<int> dice = new List<int>();
            var rand = new Random();
            for (int i = 0; i < numberOfDice; i++)
            {
                dice.Add(rand.Next(1, numberOfSides + 1));
            }

            var diceArr = dice.ToArray();
            return new YahtzeeRound
            {
                Dice = diceArr,
                Score = GetScore(dice.ToArray())
            };
        }
        public static int GetScore(int[] dice)
        {
            var groups = dice.GroupBy(x => x);
            return groups.Max(x => x.Sum());
        }
    }
}

public class YahtzeeRound
{
    private int[] _dice;
    private int _score = 0;

    public int[] Dice
    {
        get => _dice;
        set => _dice = value;
    }

    public int Score
    {
        get => _score;
        set => _score = value;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", Dice)}] => {Score}";
    }
}

