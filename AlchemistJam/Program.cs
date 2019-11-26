using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemistJam
{
    class Program
    {
        static void Main(string[] args)
        {
            var play = new GameManager();
            var scene = new Scene();
            scene.Add(new Laboratory(500, 500, @"C:\Vs\GameJamSenac\AlchemistJam\Asset\chemical-laboratory.png"));

            play.StartGame(scene);
            

        }
    }
}
