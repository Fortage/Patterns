using System;
using System.Collections.Generic;
using System.Text;

namespace PlantCar
{
    class BMWPlantCar : IPlantCar
    {
        public ICarcass CreateCarcass() => new BMWCarcass();

        public Iengine CreateEngine() => new BMWEngine();

        public ISalon CreateSalon() => new BMWSalon();
    }
}

