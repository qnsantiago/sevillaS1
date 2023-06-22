using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace jaraujoS1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSaludo_Clicked(object sender, EventArgs e)
        {
            string nombre = txtDato.Text; //
            int edad = Convert.ToInt32(txtEdad.Text);
            
            DisplayAlert("Mensaje de bienvenida", "tienes" + edad, "cerrar");
        }
    }
}
