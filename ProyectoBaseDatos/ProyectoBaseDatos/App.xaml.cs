using ProyectoBaseDatos.DataBase;
using ProyectoBaseDatos.Dependecy;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoBaseDatos
{
    public partial class App : Application
    {

        private static PersonaDataBase baseDatos;

           public static PersonaDataBase BaseDatos
           {
            get
            {
                if (baseDatos == null)
                {
                    return baseDatos = new PersonaDataBase(DependencyService.Get<IRutaBD>().GetPathBb("PersonasBD.bd3"));
                }
                else
                {
                    return baseDatos;
                }
            }
        }

        

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
