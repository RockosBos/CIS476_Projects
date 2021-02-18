using System;
using System.Runtime.Versioning;

namespace CIS476_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * AbstractFactory Factory = W90Factory.Instance();
            Client c1 = new Client(Factory);
            c1.Run();
            */

            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Nicholas Kessey\Documents\GitHub\CIS476_Projects\CIS476_P1\CIS476_P1\Test1.txt");
            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Nicholas Kessey\Documents\GitHub\CIS476_Projects\CIS476_P1\CIS476_P1\Test2.txt");
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Nicholas Kessey\Documents\GitHub\CIS476_Projects\CIS476_P1\CIS476_P1\Test3.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                AbstractFactory factory;
                Client c;
                switch (lines[i])
                {
                    case "Word90":
                        factory = W90Factory.Instance();
                        c = new Client(factory);
                        c.Run();
                        break;

                    case "Word00":
                        factory = W00Factory.Instance();
                        c = new Client(factory);
                        c.Run();
                        break;

                    case "Word10":
                        factory = W10Factory.Instance();
                        c = new Client(factory);
                        c.Run();
                        break;

                    case "Word20":
                        factory = W20Factory.Instance();
                        c = new Client(factory);
                        c.Run();
                        break;
                }
            
            }

            
        }
    }
}
