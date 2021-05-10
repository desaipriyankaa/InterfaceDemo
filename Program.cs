using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //A a = new a();
            //B b = new b();
            //a.start();
            //b.start();
            //b.stop();

            
            //explicit casting
            var Bobj = new B();
            //InterfaceDEmo demo = Bobj;
            //demo.start();
            ((InterfaceDEmo)Bobj).start();
            Bobj.start();
            Bobj.stop();



            //Interface Type
            // InterfaceDEmo demo = new A();
            // demo.start();

            //InterfaceDEmo1 demo1 = new B();
            //demo1.start();
            //demo1.stop();

            //((InterfaceDEmo)A).start();
        }

    }
}
