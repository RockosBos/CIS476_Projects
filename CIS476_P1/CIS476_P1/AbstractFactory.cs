using System;
using System.Collections.Generic;
using System.Text;

namespace CIS476_P1
{
    abstract class AbstractFactory
    {

        public abstract Button CreateButton();
        public abstract Panel CreatePanel();
        public abstract Textbox CreateTextbox();



    }
}
