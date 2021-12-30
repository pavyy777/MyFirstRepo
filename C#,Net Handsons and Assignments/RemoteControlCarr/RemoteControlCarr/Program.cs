using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlCarr
{
    class Program
    {
        static void Main(string[] args)
        {
            TestTrack.Race(new ProductionRemoteControlCar());
            TestTrack.Race(new ExperimentalRemoteControlCar());
            var prod = new ProductionRemoteControlCar();
            TestTrack.Race(prod);
            var exp = new ExperimentalRemoteControlCar();
            TestTrack.Race(exp);
           // prod.DistanceTravelled;
            //exp.DistanceTravelled;
            var prc1 = new ProductionRemoteControlCar();
            var prc2 = new ProductionRemoteControlCar();
            prc1.NumberOfVictories = 3;
            prc2.NumberOfVictories = 2;
            var rankings = TestTrack.GetRankedCars(prc1, prc2);



            Console.ReadLine();
        }
    }
}
