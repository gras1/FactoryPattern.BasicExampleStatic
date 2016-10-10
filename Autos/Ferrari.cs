using System;

namespace FactoryPattern.BasicExample.Autos
{
    public class Ferrari : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("Ferrari engine turned on and is roarrring!");
        }

        public void TurnOff()
        {
            Console.WriteLine("Ferrari engine has been turned off");
        }
    }
}
