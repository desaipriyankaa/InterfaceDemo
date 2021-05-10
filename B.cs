using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    public class B : InterfaceDEmo1, InterfaceDEmo
    {
        public void start()
        {
            Console.WriteLine("Operation started in class B...");
        }

        public void stop()
        {
            Console.WriteLine("Operation stopped in class B...");
        }
        void InterfaceDEmo.start()
        {

            Console.WriteLine("Oeration of interfaceDemo started in class B");
        }
    }
}
