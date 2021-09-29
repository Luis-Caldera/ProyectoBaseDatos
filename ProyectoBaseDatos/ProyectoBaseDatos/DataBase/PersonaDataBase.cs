using ProyectoBaseDatos.ModelData;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBaseDatos.DataBase
{
    public class PersonaDataBase
    {
        private readonly SQLiteAsyncConnection database;
        public PersonaDataBase(string path)
        {
            database = new SQLiteAsyncConnection(path);
            database.CreateTableAsync<Persona>().Wait();


        }

        // matodo Buscar todas las personas 
        public async Task<List<Persona>> GetPersonas()
        {
            return await database.Table<Persona>().ToListAsync();
        }

        // metodo buscar una sola persona por ID 
        public async Task<Persona> BuscarUnaPersona(int ID)
        {
            return await database.Table<Persona>().Where(x => x.IDProducto == ID).FirstOrDefaultAsync();
        }

        //metodo para guardar o Actualizar 
        public async Task<int> GuardarPersona(Persona persona)
        {
            if (persona.IDProducto != 0)
            {
                return await database.UpdateAsync(persona);
            }
            else
            {
                return await database.InsertAsync(persona);
            }
        }

        // metodo de eliminar una persona
        public async Task<int> EliminarPersona(Persona persona)
        {
            return await database.DeleteAsync(persona);
        }
    }
}
