using System;
using System.Collections.Generic;
using System.Net.Http;
using PCLStorage;
using Xamarin.Forms;

namespace FileSystem_Example
{
	public partial class DownloadPage_Example : ContentPage
	{
		public DownloadPage_Example()
		{
			InitializeComponent();
		}

		async void Read_Clicked(object sender, System.EventArgs e)
		{
			//throw new NotImplementedException();
			xAI.IsVisible = true;
			xAI.IsRunning = true;
			IFolder rootfolder = FileSystem.Current.LocalStorage;
			IFolder folder = await rootfolder.CreateFolderAsync("temp", CreationCollisionOption.OpenIfExists);

			string xFileName = "Cat.jpg";
			IFile file = await folder.CreateFileAsync(xFileName, CreationCollisionOption.ReplaceExisting);

			var xHttpClient = new HttpClient();
			using (var jpg = await xHttpClient.GetStreamAsync(xLink.Text))
			{
				using (var fs = await file.OpenAsync(FileAccess.ReadAndWrite))
				{
					jpg.CopyTo(fs);
					xImage.Source = file.Path;
					xAI.IsRunning = false;
					xAI.IsVisible = false;
				}
			}
		}
	}
}
