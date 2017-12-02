using Foundation;
using System;
using UIKit;

namespace STM32CP.iOS
{
    /*  The Register class manages the register tab
     *  The shared part is to manage the sql statement and use the appropriate return value to proceed
     */
    public partial class Register : UIViewController
    {
        public Register(IntPtr handle) : base(handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            myAcceptance.TouchUpInside +=delegate {
                if (myAcceptance.On)
                {
                    myRegister.Enabled = true;
                    Console.WriteLine("Switch is enabled");
                }
                else
                {
                    Console.WriteLine("Switch is disabled");
                }
            };

            myRegister.TouchUpInside += delegate
            {
                var firstname = myFirstname;
                var lastname = myLastname;
                if (myAcceptance.On)
                {
                    if (firstname.Text.Length == 0 || lastname.Text.Length == 0)
                    {
                        Alert.Message(Alert.error, "Please fill in all fields!", Alert.buttonOk);
                        return;
                    }
                    Alert.Message(Alert.input, firstname.Text.ToString() + "\n" + lastname.Text.ToString(), Alert.buttonOk);
                }
                else
                {
                    Alert.Message(Alert.error, "Please accept the AGB!", Alert.buttonOk);
                }
            };
        }
    }
}