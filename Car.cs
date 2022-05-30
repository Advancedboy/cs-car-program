using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_homework
{
    internal class Car : Vehicle
    {
        public Car(string modelName, string brandName, string engineName, int enginePower, int productionYear) 
            : base(modelName, brandName, engineName, enginePower, productionYear)
        {

        } 

        public static Car FindMorePower(Car car1, Car car2)
        {
            if(car1.EnginePower > car2.EnginePower)
            {
                return car1;
            }
            if(car1.EnginePower < car2.EnginePower)
            {
                return car2;
            }
            return null;
        }
    }
}
