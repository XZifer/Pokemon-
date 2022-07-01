using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon.Datos;
using Pokemon.Modelos.Clases;
using System.Text.Json.Serialization;

namespace Pokemon.Aplicacion
{
    public class Program
    {
        public static void Main()
        {
            string path = @"C:\Users\Luis Fernando\source\repos\XZifer\Algoritmos2\Pokemon!\Pokemon.Datos\bin\Debug\net6.0\Movimientos.json";
            Movimientos movimientos = new Movimientos();
            List<Movimiento> listMoves = new List<Movimiento>();
            listMoves= Deserializador(path);
            for (int i = 0; i < listMoves.Count; i++)
            {
                Movimiento movimiento = listMoves[i];
                Console.WriteLine("Nombre: " + movimiento.Nombre);
            }

        }

        private static List<Movimiento> Deserializador(string ruta)
        {
            List<Movimiento> listaMovimientos = new List<Movimiento>();
            string jsonString = File.ReadAllText(ruta);
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.Converters.Add(new JsonStringEnumConverter());
            listaMovimientos = JsonSerializer.Deserialize<List<Movimiento>>(jsonString,options);
            return listaMovimientos;
        }
    }
}
