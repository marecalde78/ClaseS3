using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClaseS3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtContrasena.Text;

            await Navigation.PushAsync(new pagina_dos(user, pass));


        }


        private void buttonPaginados_Clicked(object sender, EventArgs e)
        {

        }
    }
}
