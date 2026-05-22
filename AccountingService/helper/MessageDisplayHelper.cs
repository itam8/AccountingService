using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingService.helper
{
    public static class MessageDisplayHelper
    {
        public static void ShowMessage(Label label, string message)
        {
            label.Text = message;
        }

        public static void HideMessage(Label label)
        {
            label.Text = "";
        }
    }
}
