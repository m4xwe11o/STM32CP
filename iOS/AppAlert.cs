using System;
using UIKit;

namespace STM32CP.iOS
{
    /*  This class is used to manage the alerts when a button is clicked
     */
    public class AppAlert
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
