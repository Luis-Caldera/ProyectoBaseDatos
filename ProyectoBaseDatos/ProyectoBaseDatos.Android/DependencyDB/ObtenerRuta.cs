using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using System.IO;
using ProyectoBaseDatos.Droid.DependencyDB;
using ProyectoBaseDatos.Dependecy;

[assembly: Dependency(typeof(ObtenerRuta))]
namespace ProyectoBaseDatos.Droid.DependencyDB
{
    public class ObtenerRuta : IRutaBD
    {
        public string GetPathBb(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }

    }
}