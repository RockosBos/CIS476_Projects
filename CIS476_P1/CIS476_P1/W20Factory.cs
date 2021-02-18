using System;
using System.Collections.Generic;
using System.Text;

namespace CIS476_P1
{
    class W20Factory : AbstractFactory
    {
        public static int count = 0;

        private static W20Factory instance;

        protected W20Factory()
        {

        }

        public static W20Factory Instance()
        {
            if (count < 2)
            {
                instance = new W20Factory();
            }
            else
            {
                Console.WriteLine(instance.GetType().Name + " instance limit reached!");
                return null;
            }
            count++;
            return instance;
        }

        public override Button CreateButton()
        {
            return new W20Button();
        }
        public override Panel CreatePanel()
        {
            return new W20Panel();
        }
        public override Textbox CreateTextbox()
        {
            return new W20Textbox();
        }
    }
}
