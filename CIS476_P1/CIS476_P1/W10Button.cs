using System;
using System.Collections.Generic;
using System.Text;

namespace CIS476_P1
{
    class W10Button : Button
    {
        public override void DisplayName(Button a)
        {
            Console.WriteLine("This is a Button as " + a.GetType().Name);
        }
    }
}
