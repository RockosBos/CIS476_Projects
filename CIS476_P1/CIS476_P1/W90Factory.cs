using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CIS476_P1
{
    class W90Factory : AbstractFactory
    {
        public static int count = 0;

        private static W90Factory instance;

        protected W90Factory()
        {

        }

        public static W90Factory Instance()
        {
            if(count < 2)
            {
                instance = new W90Factory();
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
            return new W90Button();
        }
        public override Panel CreatePanel()
        {
            return new W90Panel();
        }
        public override Textbox CreateTextbox()
        {
            return new W90Textbox();
        }
    }
}
