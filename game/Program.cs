using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoiGame
{
    class Program
    {
        static void Main(string[] args)
        {
            HanoiGame game = new HanoiGame();
            game.setup();
            game.play();

            Console.ReadKey();
        }
    }
}