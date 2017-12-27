using Android.App;
using Android.Widget;
using Android.OS;
using Android.Util;

namespace STM32CP.Droid
{
    [Activity(Label = "STM32CP", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        Fragment[] _fragments;

        protected override void OnCreate(Bundle bundle)  
        {  
            base.OnCreate(bundle);  
  
            SetContentView(Resource.Layout.Main);  
            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;  
  
            // Add the tabs to Action Bar  
            //AddTab("Login");  
            //AddTab("Register");
            //AddTab("Reading");

            _fragments = new Fragment[]
            {
                new LoginFragment(),
                new RegisterFragment(),
                new ReadingArticleFragment()
            };

            AddTabToActionBar(Resource.String.LoginFragment_String_TextView);
            AddTabToActionBar(Resource.String.RegisterFragment_String_TextView);
            AddTabToActionBar(Resource.String.ReadingArticleFragment_String_TextView);
        }

        //private void AddTab(string tabText)  
        //{  
        //    ActionBar.Tab tab = ActionBar.NewTab();  
        //    tab.SetText(tabText);  
        //    tab.TabSelected += OnTabSelected;  
        //    ActionBar.AddTab(tab);  
        //}

        void AddTabToActionBar(int labelResourceId)
        {
            ActionBar.Tab tab = ActionBar.NewTab().SetText(labelResourceId);
            tab.TabSelected += TabOnTabSelected;
            ActionBar.AddTab(tab);
        }

        void TabOnTabSelected(object sender, ActionBar.TabEventArgs tabEventArgs)
        {
            ActionBar.Tab tab = (ActionBar.Tab)sender;

            Log.Debug("Tag", "The tab {0} has been selected.", tab.Text);
            Fragment frag = _fragments[tab.Position];
            tabEventArgs.FragmentTransaction.Replace(Resource.Id.containerFragment, frag);
        }

        private void OnTabSelected(object sender, ActionBar.TabEventArgs args)
        {
            var CurrentTab = (ActionBar.Tab)sender;

            if (CurrentTab.Position == 0)
            {
                Log.Debug("Info",CurrentTab.Position.ToString());
            }
            else
            {
                Log.Debug("Info", CurrentTab.Position.ToString());
            }
        }
    }
}

