﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpotifyForms.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyLibraryView : TabbedPage
	{
		public MyLibraryView()
		{
			InitializeComponent();
		}
	}
}