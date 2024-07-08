using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Enums.EntityTypes
{
    public class CarFeatureEnum
    {
        public enum FuelTypesEnum
        {
            DIESEL,
            LPG,
            GASOLINE,
            HYBRID,
            ELECTRIC
        }

        public enum BodyTypesEnum
        {
            SEDAN,
            COUPE,
            HATCHBACK,
            ROADSTER,
            CABRIO,
            SUV,
            CROSSOVER,
            PICKUP
        }

        public enum GearTypesEnum
        {
            AUTOMATIC,
            MANUEL,
            SEMI_AUTOMATIC
        }
    }
}
