using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlCar
{
    interface IRemoteControlCar
    {
         void Drive();
    int DistanceTravelled { get;}
}
public class ProductionRemoteControlCar : IRemoteControlCar,IComparable<ProductionRemoteControlCar>
{
    public int DistanceTravelled { get; private set; }
    public int NumberOfVictories { get; set; }
	public int CompareTo(ProductionRemoteControlCar other)
	{
        return NumberOfVictories.CompareTo(other.NumberOfVictories);
	}
	public void Drive()
    {
        DistanceTravelled += 10;
    }
}
public class ExperimentalRemoteControlCar : IRemoteControlCar
{
    public int DistanceTravelled { get; private set; }
	public void Drive()
    {
        DistanceTravelled += 20;
    }
}
public static class TestTrack
{
    public static void Race(IRemoteControlCar car)
    {
        car.Drive();
    }
    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2)
    {
        
        var ls = new List<ProductionRemoteControlCar>() { prc1, prc2 };
        ls.Sort();
        return ls;
    }
}
}
