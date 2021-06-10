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

            // insert
            var persona = new BsonDocument { { "Nombre","Desde C#" } };

            coleccion.InsertOne(persona);


            // FIND - Select

            var documentos = coleccion.Find(new BsonDocument()).ToList().Count;

            Console.WriteLine("Existen {0} documentos en la coleccion peronas",documentos);


            var listado = coleccion.Find(new BsonDocument()).ToList();

            foreach (var b in listado)
            {
                 Console.WriteLine(b);
            }


        }
    }
}
