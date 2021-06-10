using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Console.WriteLine(b);
            }

        }
    }
}
