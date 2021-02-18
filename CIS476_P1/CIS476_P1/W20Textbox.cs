using System;
using System.Collections.Generic;
using System.Text;

namespace CIS476_P1
{
    class W20Textbox : Textbox
    {
        public override void DisplayName(Textbox a)
        {
            Console.WriteLine("This is a Textbox as " + a.GetType().Name);
        }
    }
}
