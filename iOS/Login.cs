using Foundation;
using System;
using UIKit;

namespace STM32CP.iOS
{
    public partial class Login : UIViewController
    {
        public Login(IntPtr handle) : base(handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            myLoginButton.TouchUpInside += delegate {
                var username = myUsername;
                var password = myPassword;
                if (password.Text.Length == 0 || username.Text.Length == 0)
                {
                    new UIAlertView("Error", "Username or password is emty!", null, "OK", null).Show();
                    return;
                }
                new UIAlertView("Clicked", username.Text.ToString() + "\n" + password.Text.ToString(), null, "OK", null).Show();
            };
        }
    }
}