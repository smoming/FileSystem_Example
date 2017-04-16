using System.Diagnostics;
using PCLStorage;
using Xamarin.Forms;

namespace FileSystem_Example
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//MainPage = new FileSystem_ExamplePage();
			MainPage = new DownloadPage_Example();
		}

		protected override void OnStart()
		{
			// Handle when your app starts

			//IFolder rootfolder = FileSystem.Current.LocalStorage;
			//Debug.WriteLine($"rootfolder Name:{rootfolder.Name}");
			//Debug.WriteLine($"rootfolder Paht:{rootfolder.Path}");

			//IFolder folder = await rootfolder.CreateFolderAsync("temp", CreationCollisionOption.OpenIfExists);
			//Debug.WriteLine($"folder Name:{folder.Name}");
			//Debug.WriteLine($"folder Paht:{folder.Path}");

			//IFile file = await folder.CreateFileAsync("MyTest.txt", CreationCollisionOption.OpenIfExists);
			//await file.WriteAllTextAsync("Hello Ming");
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
