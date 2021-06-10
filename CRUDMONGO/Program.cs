using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CRUDMONGO
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "mongodb://localhost:27017/";

            MongoClient cliente = new MongoClient(cadena);

            var ListadoBDS = cliente.ListDatabases().ToList();
            Console.WriteLine("Listado de bases de datos existentes");

            foreach (var b in ListadoBDS)
            {
                // Console.WriteLine(b);
            }

            var basededatos = cliente.GetDatabase("agenda");
            var coleccion = basededatos.GetCollection<BsonDocument>("Personas");

            var persona = new BsonDocument { { "Nombre","Desde C#" } };

            coleccion.InsertOne(persona);


        }
    }
}
