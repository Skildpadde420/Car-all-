using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_all_
{
    class Car
    {
        #region Members
        private int _tankVolume = 40;
        #endregion
        #region Constructor
        public Car()
        {
        }        
        //public Car(int speed, int maxSpeed, int tankVolume, int maxTank)
        //{
        //}
        #endregion
        #region Properties
        public int ActualSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public int MaxTankCapacity{ get; set; }
        public int TankVolume
        { 
            get { return _tankVolume; } 
            protected set { _tankVolume = value; } 
        }
        #endregion

        #region Methods
        public virtual void SetMaxSpeed(int maxSpeed)
        {
            if (maxSpeed >= 80 || maxSpeed <= 300)
            {
                MaxSpeed = maxSpeed;
                Console.WriteLine("The maximum speed is: " + maxSpeed);
            }
            else
                Console.WriteLine("The speed is not in the limitations");
        }
        public virtual void IncreaseSpeed(int speed)
        {
            ActualSpeed += speed;
            if (ActualSpeed > MaxSpeed)
            {
                ActualSpeed = MaxSpeed;
                Console.WriteLine("The actual speed is: " + ActualSpeed);
            }
            else
                Console.WriteLine("The actual speed is: " + ActualSpeed);
        }
        public virtual void Refuel()
        {
            TankVolume = MaxTankCapacity;
            Console.WriteLine("New tank volume: " + TankVolume);
        }
        public virtual void Refuel(int tankVolume)
        {
            if (tankVolume <= MaxTankCapacity - TankVolume)
            {
                int newTankVolume = tankVolume + TankVolume;
                Console.WriteLine("New tank volume: " + newTankVolume);
            }
            else if (tankVolume > MaxTankCapacity - TankVolume)
            {
                Console.WriteLine("New tank volume: " + MaxTankCapacity);
            }
        }
        public virtual void DriveRace()
        {
            if (TankVolume > 15)
            {
                TankVolume -= 15;
                Console.WriteLine("New Tank Volume: " + TankVolume);

                if (TankVolume < 10)
                {
                    Console.WriteLine("Tank is almost empty, you need to refill soon!");
                }
            }
            else
            {
                TankVolume = 0;
                Console.WriteLine("Tank is empty, please refuel!");
            }
        }
        #endregion
    }
}
