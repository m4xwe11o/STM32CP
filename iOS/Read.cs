using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace STM32CP.iOS
{
    public partial class Read : UITableViewController
    {
        
        public Read (IntPtr handle) : base (handle)
        {
        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();
           
        }
    }
}