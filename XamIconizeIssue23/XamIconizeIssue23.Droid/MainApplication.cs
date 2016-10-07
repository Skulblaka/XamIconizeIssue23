using System;

using Android.App;
using Android.Runtime;

namespace XamIconizeIssue23.Droid
{
    [Application(Label = "Issue #23", Theme = "@style/MainTheme")]
    public class MainApplication : Application
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownerShip)
            : base(handle, ownerShip)
        {
            // Intentionally left blank
        }

        public override void OnCreate()
        {
            base.OnCreate();

            Plugin.Iconize.Iconize.With(new Plugin.Iconize.Fonts.FontAwesomeModule());
        }
    }
}