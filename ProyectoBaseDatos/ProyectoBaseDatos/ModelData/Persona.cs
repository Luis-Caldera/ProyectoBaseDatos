using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ProyectoBaseDatos.ModelData
{
    public class Persona
    {
        [PrimaryKey, AutoIncrement]
        public int IDProducto { get; set; }

        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public int PrecioProducto { get; set; }
        public int CantidadProducto { get; set; }

    }
}
