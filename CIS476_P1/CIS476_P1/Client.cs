using System;
using System.Collections.Generic;
using System.Text;

namespace CIS476_P1
{
    class Client
    {
        private Button Button;
        private Panel Panel;
        private Textbox Textbox;

        public Client(AbstractFactory factory)
        {
            if (factory != null)
            {
                Button = factory.CreateButton();
                Panel = factory.CreatePanel();
                Textbox = factory.CreateTextbox();
            }
        }
        public void Run()
        {
            if (Button != null)
            {
                Button.DisplayName(Button);
                Panel.DisplayName(Panel);
                Textbox.DisplayName(Textbox);
            }
        }
    }
}
