using ProyectoBaseDatos.ModelData;
using ProyectoBaseDatos.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProyectoBaseDatos
{
    public partial class MainPage : ContentPage
    {
        Persona persona = null;
        public MainPage()
        {
            InitializeComponent();
        }


        private async void Insertar(object sender, EventArgs e)
        {
            var idproducto = idProducto.Text;
            var nombreproducto = NombreProducto.Text;
            var descripcionProducto = DescripcionProducto.Text;
            var precioproducto = PrecioProducto.Text;
            var cantidadproducto = CantidadProducto.Text;

            try
            {
                Persona persona = new Persona
                {
                    NombreProducto = nombreproducto,
                    DescripcionProducto = descripcionProducto,
                    PrecioProducto = Convert.ToInt32(precioproducto),
                    CantidadProducto = Convert.ToInt32(cantidadproducto)
                };

                var resultado = await App.BaseDatos.GuardarPersona(persona);

                if (resultado > 0)
                {
                    await DisplayAlert("Mensaje", "Usuario Insertado, actualizado con exito.", "OK");
                }
                else
                {
                    await DisplayAlert("Mensaje", "Usuario NO Insertado, actualizado.", "OK");
                }
                limpiar();
            }
            catch
            {
                await DisplayAlert("Insertar","Error, sig los pasos...","OK");
            }
            

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            try
            {
                persona = await App.BaseDatos.BuscarUnaPersona(Convert.ToInt32(idProducto.Text));

                if (persona == null)
                {
                    await DisplayAlert("Buscar", "Persona NO encontrada.", "OK");
                }
                else
                {
                    NombreProducto.Text = persona.NombreProducto;
                    DescripcionProducto.Text = persona.DescripcionProducto;
                    PrecioProducto.Text = Convert.ToString(persona.PrecioProducto);
                    CantidadProducto.Text = Convert.ToString(persona.CantidadProducto);
                }
            }
            catch
            {
                await DisplayAlert("Insertar", "Error, sig los pasos...", "OK");
            }

            
        }

        public void limpiar()
        {
            idProducto.Text = "";
            NombreProducto.Text = "";
            DescripcionProducto.Text = "";
            PrecioProducto.Text = "";
            CantidadProducto.Text = "";
        }

        private async void Eliminar(object sender, EventArgs e)
        {
            try
            {
                var personaEliminada = await App.BaseDatos.EliminarPersona(persona);

                if (personaEliminada > 0)
                {
                    await DisplayAlert("Eliminada", "Persona eliminada con exito.", "OK");
                }
                else
                {
                    await DisplayAlert("Eliminada", "Persona no eliminada.", "OK");
                }

                limpiar();
            }
            catch
            {
                await DisplayAlert("Eliminar", "Error, sig los pasos...", "OK");
            }
            
        }

        private async void MostrarTodo(object sender, EventArgs e)
        {
            try
            {
                var Lista = await App.BaseDatos.GetPersonas();
                await Navigation.PushAsync(new ViewTodos(Lista));
              
            }
            catch
            {
                await DisplayAlert("Mostrar todo", "Error, sig los pasos...", "OK");
            }
            
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            NombreProducto.Text = "";
            DescripcionProducto.Text = "";
            PrecioProducto.Text = "";
            CantidadProducto.Text = "";
        }
    }


}
