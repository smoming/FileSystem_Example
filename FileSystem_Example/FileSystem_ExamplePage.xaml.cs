using System.Diagnostics;
using PCLStorage;
using Xamarin.Forms;

namespace FileSystem_Example
{
	public partial class FileSystem_ExamplePage : ContentPage
	{
		public FileSystem_ExamplePage()
		{
			InitializeComponent();
		}

		async protected override void OnAppearing()
		{
			base.OnAppearing();

			IFolder rootfolder = FileSystem.Current.LocalStorage;
			Debug.WriteLine($"rootfolder Name:{rootfolder.Name}");
			Debug.WriteLine($"rootfolder Paht:{rootfolder.Path}");

			IFolder folder = await rootfolder.CreateFolderAsync("temp", CreationCollisionOption.OpenIfExists);
			Debug.WriteLine($"folder Name:{folder.Name}");
			Debug.WriteLine($"folder Paht:{folder.Path}");

			IFile file = await folder.CreateFileAsync("MyTest.txt", CreationCollisionOption.OpenIfExists);
			await file.WriteAllTextAsync("Hello Ming");
		}

		async void Read_Clicked(object sender, System.EventArgs e)
		{
			//throw new NotImplementedException();
			xAI.IsRunning = true;
			IFolder rootfolder = FileSystem.Current.LocalStorage;
			IFolder folder = await rootfolder.CreateFolderAsync("temp", CreationCollisionOption.OpenIfExists);
			IFile file = await folder.CreateFileAsync("MyTest.txt", CreationCollisionOption.OpenIfExists);
			xLabel.Text = await file.ReadAllTextAsync();
			xAI.IsRunning = false;
		}

		async void Write_Clicked(object sender, System.EventArgs e)
		{
			//throw new NotImplementedException();
			xAI.IsRunning = true;
			IFolder rootfolder = FileSystem.Current.LocalStorage;
			IFolder folder = await rootfolder.CreateFolderAsync("temp", CreationCollisionOption.OpenIfExists);
			IFile file = await folder.CreateFileAsync("MyTest.txt", CreationCollisionOption.OpenIfExists);
			await file.WriteAllTextAsync(xWriteEntry.Text);
			await DisplayAlert("Info", "寫入成功", "OK");
			xAI.IsRunning = false;
		}
	}
}
