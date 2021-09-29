using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoBaseDatos.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VistaCompleta : ContentPage
    {
        public VistaCompleta(List<ModelData.Persona> lista)
        {
            InitializeComponent();
            Lista.ItemsSource = lista;
        }
    }
}