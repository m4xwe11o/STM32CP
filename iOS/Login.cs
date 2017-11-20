using Foundation;
using System;
using UIKit;

namespace STM32CP.iOS
{
    /*  The Login class manages the login tab
     *  The shared part is to manage the sql statement and use the appropriate return value to proceed
     */
    public partial class Login : UIViewController
    {
        public Login (IntPtr handle) : base (handle)
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
                    AppAlert.Message(AppAlert.error, "Username or password is emty!", AppAlert.buttonOk);
                    return;
                }
                AppAlert.Message(AppAlert.info, username.Text.ToString() + "\n" + password.Text.ToString(), AppAlert.buttonOk);
            };
        }
    }
}