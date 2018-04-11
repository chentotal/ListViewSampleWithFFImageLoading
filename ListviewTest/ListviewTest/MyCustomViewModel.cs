using System;
using System.Collections.Generic;
using System.Text;

namespace ListviewTest
{
    public class MyCustomViewModel : ViewModelBase
	{
		string _imageUrl;

		public string ImageURL
		{
			set { SetProperty(ref _imageUrl, value); }
			get { return _imageUrl; }
		}

		public MyCustomViewModel(string imageURL)
		{
			ImageURL = imageURL;
		}
	}
}
