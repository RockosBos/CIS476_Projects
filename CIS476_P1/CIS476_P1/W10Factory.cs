using System;
using System.Collections.Generic;
using System.Text;

namespace CIS476_P1
{
    class W10Factory : AbstractFactory
    {
        public static int count = 0;

        private static W10Factory instance;

        protected W10Factory()
        {

        }

        public static W10Factory Instance()
        {
            if (count < 2)
            {
                instance = new W10Factory();
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
            return new W10Button();
        }
        public override Panel CreatePanel()
        {
            return new W10Panel();
        }
        public override Textbox CreateTextbox()
        {
            return new W10Textbox();
        }
    }
}
