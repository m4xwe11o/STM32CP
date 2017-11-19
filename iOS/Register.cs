using Foundation;
using System;
using UIKit;

namespace STM32CP.iOS
{
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
                        new UIAlertView("Error", "Please fill in all fields!", null, "OK", null).Show();
                        return;
                    }
                    new UIAlertView("Clicked", firstname.Text.ToString() + "\n" + lastname.Text.ToString(), null, "OK", null).Show();
                }
                else
                {
                    new UIAlertView("Error", "Please accept the AGB!", null, "OK", null).Show();
                    return;
                }
            };
        }
    }
}