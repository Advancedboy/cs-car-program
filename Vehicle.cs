using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_homework
{
    internal abstract class Vehicle
    {
        public string ModelName { get; set; }
        public string BrandName { get; set; }
        public string EngineName { get; set; }
        public int EnginePower { get; }
        public int ProductionYear { get; }

        public Vehicle(string modelName, string brandName, string engineName, int enginePower, int productionYear)
        {
            if (string.IsNullOrEmpty(modelName))
            {
                throw new ArgumentNullException(nameof(modelName));
            }
            if (string.IsNullOrEmpty(brandName))
            {
                throw new ArgumentNullException(nameof(brandName));
            }
            if (string.IsNullOrEmpty(engineName))
            {
                throw new ArgumentNullException(nameof(engineName));
            }
            if(enginePower < 0)
            {
                throw new ArgumentException(nameof(enginePower));
            }
            if(productionYear < 1885)
            {
                throw new ArgumentException(nameof(productionYear));
            }
            ModelName = modelName;
            BrandName = brandName;
            EngineName = engineName;
            EnginePower = enginePower;
            ProductionYear = productionYear;
        }

        public override string ToString()
        {
            return $"Brand Name: {BrandName}.\n" +
                $"Model name: {ModelName}.\n" + 
                $"Engine Name: {EngineName}.\nEngine Power: {EnginePower}.\n" +
                $"Proguction Year: {ProductionYear}.\n";
        }
    }
}
