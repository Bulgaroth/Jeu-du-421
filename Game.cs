using System;
using System.Collections.Generic;

namespace JeuDu421
{
    class Game
    {
        public readonly int nbRounds;
        public readonly int nbDice;

        private List<Die> dice;

        public Game(int nbRiggedDice = 0, int nbRounds = 5, int nbDice = 5)
        {
            this.nbRounds = nbRounds;
            this.nbDice = nbDice;

            dice = new();

            for (int i = 0; i < nbDice; i++) dice.Add(new Die());
        }

        public override string ToString() 
        {
            string display = "";
            for (int i = 0; i < nbDice; i++) display += "+---+ ";
            display += "\n";
            for (int i = 0; i < nbDice; i++) display += $"| {dice[i].face} | ";
            display += "\n";
            for (int i = 0; i < nbDice; i++) display += "+---+ ";
            display += "\n";

            return display;
        }

        public int Relancer(int i) { return dice[i].Lancer(); }

        public int Score() 
        {
            int score = 0;
            foreach (Die d in dice) score += d.face;
            return score;
        }

        public int Run()
        {
            Console.WriteLine(" Le jeu du 421 :");
            for(int i = 0; i < nbRounds; i++)
            {
                Console.WriteLine(ToString());
                Console.Write("Quels sont les dés que vous souhaitez relancer ? :");
                Relancer(int.Parse(Console.ReadLine())-1);
            }
            return Score();
        }
    }
}
