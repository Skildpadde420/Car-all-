using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_all_
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myAudi = new Car();
            myAudi.ActualSpeed = 0;
            myAudi.MaxSpeed = 210;
            myAudi.MaxTankCapacity = 65;

            myAudi.SetMaxSpeed(180);
            myAudi.IncreaseSpeed(40);
            myAudi.IncreaseSpeed(40);
            myAudi.IncreaseSpeed(40);
            myAudi.IncreaseSpeed(40);
            myAudi.IncreaseSpeed(40);
            myAudi.IncreaseSpeed(40);
            myAudi.DriveRace();
            myAudi.Refuel();
            myAudi.DriveRace();
            myAudi.DriveRace();
            myAudi.DriveRace();
            myAudi.DriveRace();
            myAudi.DriveRace();
            myAudi.Refuel(myAudi.MaxTankCapacity);

            SportsCar myLambo = new SportsCar();
            myLambo.ActualSpeed = 0;
            myLambo.MaxSpeed = 410;
            myLambo.MaxTankCapacity = 85;

            myLambo.SetMaxSpeed(370);
            myLambo.IncreaseSpeed(90);
            myLambo.IncreaseSpeed(90);
            myLambo.IncreaseSpeed(90);
            myLambo.IncreaseSpeed(120);
            myLambo.DriveRace();
            myLambo.Refuel();
            myLambo.DriveRace();
            myLambo.DriveRace();
            myLambo.DriveRace();
            myLambo.DriveRace();
            myLambo.DriveRace();
            myLambo.Refuel(myLambo.MaxTankCapacity);

            Console.ReadLine();
        }
    }
}
