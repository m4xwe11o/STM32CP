
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace STM32CP.Droid
{
    public class LoginFragment : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.LoginFragmentContainer, null);
            //TextView tv = (TextView)view.FindViewById(Resource.Id.LoginFragment_TextView_1);
            //tv.SetText(Resource.String.LoginFragment_String_TextView);
            //view.FindViewById(Resource.Id.imageView1).SetImageResource(Resource.Drawable.ic_action_speakers);
            return view;
        }
    }

    public class RegisterFragment: Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.RegisterFragmentContainer, null);
            //TextView tv = (TextView)view.FindViewById(Resource.Id.RegisterFragment_TextView_1);
            //tv.SetText(Resource.String.RegisterFragment_String_TextView);
            //view.FindViewById(Resource.Id.imageView1).SetImageResource(Resource.Drawable.ic_action_speakers);
            return view;
        }
    }

    public class ReadingArticleFragment : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.ReadArticleFragmentContainer, null);
            //TextView tv = (TextView)view.FindViewById(Resource.Id.ReadingArticleFragment_TextView_1);
            //tv.SetText(Resource.String.ReadingArticleFragment_String_TextView);
            //view.FindViewById(Resource.Id.imageView1).SetImageResource(Resource.Drawable.ic_action_speakers);
            return view;
        }
    }
}
