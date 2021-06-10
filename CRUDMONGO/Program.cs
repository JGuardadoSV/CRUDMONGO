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


        }
    }
}
