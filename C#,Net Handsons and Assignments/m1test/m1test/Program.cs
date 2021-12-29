﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m1test
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Player> players = new List<Player>();
            players.Add(new Player { Name = "X", Team = "A", Score = 30 });
            players.Add(new Player { Name = "X", Team = "A", Score = 50 });
            players.Add(new Player { Name = "X", Team = "A", Score = 30 });
            PlayerImplementation playerImplementation = new PlayerImplementation();
            Console.WriteLine(playerImplementation.Average(players));
            Console.WriteLine(playerImplementation.Max(players));
            Console.WriteLine(playerImplementation.Min(players));
        }
    }
}
