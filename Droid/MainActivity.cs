using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace FileSystem_Example.Droid
{
	[Activity(Label = "FileSystem_Example.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);

			var folders = Enum.GetValues(typeof(System.Environment.SpecialFolder));
			foreach (var f in folders)
			{
				var sfolder = (System.Environment.SpecialFolder)f;
				var path = System.Environment.GetFolderPath(sfolder);
				Console.WriteLine($"{f}={path}");
			}

			LoadApplication(new App());
		}
	}
}
