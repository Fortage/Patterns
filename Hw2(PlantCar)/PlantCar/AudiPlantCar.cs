using System;
using System.Collections.Generic;
using System.Text;

namespace PlantCar
{
    class AudiPlantCar : IPlantCar
    {
        public ICarcass CreateCarcass() => new AudiCarcass();

        public Iengine CreateEngine() => new AudiEngine();

        public ISalon CreateSalon() => new AudiSalon();
    }
}
