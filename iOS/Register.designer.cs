// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace STM32CP.iOS
{
    [Register ("Register")]
    partial class Register
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch myAcceptance { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField myCity { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField myEmail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField myFirstname { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField myLastname { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField myPassword { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton myRegister { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField myRepeatPassword { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField myStreet { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (myAcceptance != null) {
                myAcceptance.Dispose ();
                myAcceptance = null;
            }

            if (myCity != null) {
                myCity.Dispose ();
                myCity = null;
            }

            if (myEmail != null) {
                myEmail.Dispose ();
                myEmail = null;
            }

            if (myFirstname != null) {
                myFirstname.Dispose ();
                myFirstname = null;
            }

            if (myLastname != null) {
                myLastname.Dispose ();
                myLastname = null;
            }

            if (myPassword != null) {
                myPassword.Dispose ();
                myPassword = null;
            }

            if (myRegister != null) {
                myRegister.Dispose ();
                myRegister = null;
            }

            if (myRepeatPassword != null) {
                myRepeatPassword.Dispose ();
                myRepeatPassword = null;
            }

            if (myStreet != null) {
                myStreet.Dispose ();
                myStreet = null;
            }
        }
    }
}