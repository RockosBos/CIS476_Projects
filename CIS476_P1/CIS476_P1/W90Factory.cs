using System;
using System.Collections.Generic;
using System.Text;

namespace CIS476_P1
{
    class W90Factory : AbstractFactory
    {
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
