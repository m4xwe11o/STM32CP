using System;
namespace STM32CP
{
    public class AppAlert
    {
        public AppAlert()
        {
        }
        public void Message(String title, String message, String button)
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
