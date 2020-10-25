using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_all_
{
    class SportsCar : Car
    {
        #region Constructor
        public SportsCar()
        {
        }
        #endregion
        #region Methods
        public override void SetMaxSpeed(int maxSpeed)
        {
            if (maxSpeed >= 250)
            {
                MaxSpeed = maxSpeed;
                Console.WriteLine("The maximum speed is: " + maxSpeed);
            }
            else
                Console.WriteLine("The speed is too low");
        }
        #endregion
    }
}
