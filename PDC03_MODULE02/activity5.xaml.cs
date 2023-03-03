using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace PDC03_MODULE02
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class activity5 : ContentPage
	{
		ObservableCollection<employee> employees = new ObservableCollection<employee>();
		public ObservableCollection<employee> Employees { get { return employees; } }	
		public activity5 ()
		{
			InitializeComponent ();

			{
				lst.ItemsSource = employees;

				employees.Add(new employee { DisplayName = "Leni Robredo", Position = "President", profileimage="image1.png" });
                employees.Add(new employee { DisplayName = "Kiko Pangilinan", Position = "Vice President", profileimage = "image2.jpg" });
                employees.Add(new employee { DisplayName = "Raffy Tulfo", Position = "Secretary", profileimage = "image3.jfif" });
            }
		}
	}
}