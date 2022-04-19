using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClaseS3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pagina_dos : ContentPage
    {
        public pagina_dos(string user, string pass)
        {
            InitializeComponent();
            DisplayAlert("Mensaje", "El usuario es" + user + "La contrasena es" + pass, "cerrar");
        }
    }
}