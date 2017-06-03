using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairingTheTiles
{
    class RepairingTheTiles
    {
        static void Main(string[] args)
        {
            int playgroundLength = int.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileLength = double.Parse(Console.ReadLine());
            int benchWidth = int.Parse(Console.ReadLine());
            int benchLength = int.Parse(Console.ReadLine());

            int playgroundArea = playgroundLength * playgroundLength;
            double tileArea = tileLength * tileWidth;
            int benchArea = benchLength * benchWidth;

            int repairingArea = playgroundArea - benchArea;
            double tilesCounter = repairingArea / tileArea;
            double repairTime = tilesCounter * 0.2;

            Console.WriteLine("{0:f2}", tilesCounter);
            Console.WriteLine("{0:f2}", repairTime);
        }
    }
}
