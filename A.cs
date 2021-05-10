using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    public class A : InterfaceDEmo
    {
        void InterfaceDEmo.start()
        {
            Console.WriteLine("Operation has started in class A...");
        }
    }
}
