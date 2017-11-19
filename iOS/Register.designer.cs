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
        UIKit.UITextField myFirstname { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField myLastname { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton myRegister { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (myAcceptance != null) {
                myAcceptance.Dispose ();
                myAcceptance = null;
            }

            if (myFirstname != null) {
                myFirstname.Dispose ();
                myFirstname = null;
            }

            if (myLastname != null) {
                myLastname.Dispose ();
                myLastname = null;
            }

            if (myRegister != null) {
                myRegister.Dispose ();
                myRegister = null;
            }
        }
    }
}