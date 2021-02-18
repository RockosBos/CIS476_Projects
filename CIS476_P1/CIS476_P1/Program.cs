using System;

namespace CIS476_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory Factory = new W90Factory();
            Client c1 = new Client(Factory);
            c1.Run();
        }
    }
}
