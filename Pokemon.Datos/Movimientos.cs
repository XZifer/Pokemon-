using Pokemon.Modelos.Clases;
using System.Dynamic;
using System.Text.Json;

namespace Pokemon.Datos
{
    public class Movimientos
    {
        private List<Movimiento> ListaMovimientos { get; set; }
        public Movimientos()
        {
            //var jsonString = File.ReadAllText(@"T:/bookmarks-2013-11-13.json");
            //var rootMark = JsonConvert.DeserializeObject<Bookmark>(jsonString);
            ListaMovimientos = JsonSerializer.Deserialize<List<Movimiento>>(); ;
        }
    }
}