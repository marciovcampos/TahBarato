using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TahBarato
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : MasterDetailPage
    {
		public Menu ()
		{
			InitializeComponent ();
            Detail = new NavigationPage(new HomePage());
        }

        private void GoHomePage(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new HomePage());
            IsPresented = false;
        }
        private void GoSobrePage(object sender, System.EventArgs e)
        {
            Detail.Navigation.PushAsync(new SobrePage());
            IsPresented = false;
        }
    }
}