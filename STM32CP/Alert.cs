using System;
using UIKit;

namespace STM32CP
{
    public class Alert
    {
        public static String error = "Error";
        public static String info = "Info";
        public static String clicked = "Clicked";
        public static String input = "Input";
        public static String buttonOk = "OK";

        public static void Message(String title, String message, String button)
        {
            UIAlertView alert = new UIAlertView()
            {
                Title = title,
                Message = message
            };
            alert.AddButton(button);
            alert.Show();
        }
    }
}
