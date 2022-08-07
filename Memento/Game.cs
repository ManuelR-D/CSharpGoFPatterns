using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Memento
{
    internal class Game
    {
        string Name { get; set; }
        int Points { get; set; }

        public Game(string name, int points)
        {
            Name = name;
            Points = points;
        }
    }
}
