using ProyectoBaseDatos.ModelData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoBaseDatos.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewTodos : ContentPage
    {
        public ViewTodos(List<ModelData.Persona> lista)
        {
            InitializeComponent();
            Lista.ItemsSource = lista;
        }


        private async void Lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var producto = (Persona)e.SelectedItem;
            await DisplayAlert("ID", "ID Producto: " + producto.IDProducto + "\n" + "Nombre del Producto: " + producto.NombreProducto + "\n" + "Descripcion del producto: "+ producto.DescripcionProducto + "\n" + "Precio del producto: " + producto.PrecioProducto + "\n"+ "Cantidad del producto: " + producto.CantidadProducto,"ok");


        }

        private Task DisplayAlert(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        private void Lista_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}