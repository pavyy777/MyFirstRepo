using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlCar
{
    class Program
    {
        static void Main(string[] args)
        {
            TestTrack.Race(new ProductionRemoteControlCar());
            TestTrack.Race(new ExperimentalRemoteControlCar());
            Console.ReadLine();

        }
    }
}
