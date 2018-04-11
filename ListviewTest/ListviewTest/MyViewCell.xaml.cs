using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FFImageLoading.Forms;
using CachedImageEvents;
using FFImageLoading.Args;

namespace ListviewTest
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyViewCell : ViewCell
	{
		public MyViewCell()
		{
			InitializeComponent();

			myImage.Success += UpdateImageSize;
		}

		void UpdateImageSize(object sender, FFImageLoading.Args.SuccessEventArgs args)
		{
			Device.BeginInvokeOnMainThread(() =>
			{
				this.ForceUpdateSize();
			});
		}
	}
}