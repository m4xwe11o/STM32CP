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
                    Alert.Message(Alert.error, "Username or password is emty!", Alert.buttonOk);
                    MySQLServer.GetArticles();
                    //AppAlert.Message(AppAlert.error, "Username or password is emty!", AppAlert.buttonOk);
                    return;
                }
                Alert.Message(Alert.info, username.Text.ToString() + "\n" + password.Text.ToString() + "\n" + MySQLServer.article[2].Title, Alert.buttonOk);
                //AppAlert.Message(AppAlert.info, username.Text.ToString() + "\n" + password.Text.ToString(), AppAlert.buttonOk);
            };
            myPassword.ShouldReturn = (textField) => {
                textField.ResignFirstResponder();
                return true;
            };
        }
    }
}