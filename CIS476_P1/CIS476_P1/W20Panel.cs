using System;
using System.Collections.Generic;
using System.Text;

namespace CIS476_P1
{
    class W20Panel : Panel
    {
        public override void DisplayName(Panel a)
        {
            Console.WriteLine("This is a Panel as " + a.GetType().Name);
        }
    }
}
