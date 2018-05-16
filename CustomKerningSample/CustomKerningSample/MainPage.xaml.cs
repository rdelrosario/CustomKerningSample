using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomKerningSample
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
		{
			InitializeComponent();
		}

        public void Handle_SelectedIndexChanged(object sender, EventArgs e)
        {
            element.Kerning = Convert.ToInt32(picker.SelectedItem);
        }
	}
}
