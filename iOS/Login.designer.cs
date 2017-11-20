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
    [Register ("Login")]
    partial class Login
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton myLoginButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField myPassword { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField myUsername { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (myLoginButton != null) {
                myLoginButton.Dispose ();
                myLoginButton = null;
            }

            if (myPassword != null) {
                myPassword.Dispose ();
                myPassword = null;
            }

            if (myUsername != null) {
                myUsername.Dispose ();
                myUsername = null;
            }
        }
    }
}