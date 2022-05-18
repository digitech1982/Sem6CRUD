using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sem6CRUD
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnInsertar_Clicked(object sender, EventArgs e)
        {
            try
            {
               WebClient cliente=new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection(); //contenedor tipo vector
                //Dato a enviar al Post-Insertar
                parametros.Add("codigo",txtCodigo.Text);
                parametros.Add("nombre", txtNombre.Text);
                parametros.Add("apellido", txtApellido.Text);
                parametros.Add("edad", txtEdad.Text);

                cliente.UploadValues("http://192.168.1.7/moviles1/post.php", "POST", parametros);
                DisplayAlert("Mensaje de Alerta", "Ingreso Correcto", "OK");

            }
            catch (Exception ex)
            {

                DisplayAlert("Mensaje de Alerta",ex.Message,"OK");
            }

        }

        private void btnRegreasar_Clicked(object sender, EventArgs e)
        {

        }
    }
}
