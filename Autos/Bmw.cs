using System;

namespace FactoryPattern.BasicExample.Autos
{
    public class Bmw : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("BMW engine turned on and is purrring!");
        }

        public void TurnOff()
        {
            Console.WriteLine("BMW engine has been turned off");
        }
    }
}
