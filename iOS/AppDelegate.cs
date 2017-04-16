using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace FileSystem_Example.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			LoadApplication(new App());

			//var folders = Enum.GetValues(typeof(Environment.SpecialFolder));
			//foreach (var f in folders)
			//{
			//	var sfolder = (Environment.SpecialFolder)f;
			//	var path = Environment.GetFolderPath(sfolder);
			//	Console.WriteLine($"{f}={path}");
			//}

			return base.FinishedLaunching(app, options);
		}
	}
}
