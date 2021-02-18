using System;
using System.Collections.Generic;
using System.Text;

namespace CIS476_P1
{
    class W00Factory : AbstractFactory
    {
        public static int count = 0;

        private static W00Factory instance;

        protected W00Factory()
        {

        }

        public static W00Factory Instance()
        {
            if (count < 2)
            {
                instance = new W00Factory();
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
            return new W00Button();
        }
        public override Panel CreatePanel()
        {
            return new W00Panel();
        }
        public override Textbox CreateTextbox()
        {
            return new W00Textbox();
        }
    }
}

