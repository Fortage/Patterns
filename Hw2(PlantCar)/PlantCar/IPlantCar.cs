using System;
using System.Collections.Generic;
using System.Text;

namespace PlantCar
{
    public interface IPlantCar
    {
        ICarcass CreateCarcass();
        Iengine CreateEngine();
        ISalon CreateSalon();
    }
}
