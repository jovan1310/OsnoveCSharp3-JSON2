using Newtonsoft.Json;

namespace OsnoveCSharp3_JSON2
{
    public class Program
    {
        public class Proizvod
        {
            public string ImeProizvoda { get; set; }
            public decimal CenaProizvoda { get; set; }
            public List<string> OznakeProizvoda { get; set; }
        }
        static void Main(string[] args)
        {
            Proizvod proizvod1 = new Proizvod
            {
                ImeProizvoda = "Android telefon",
                CenaProizvoda = 498.52m,
                OznakeProizvoda = new List<string> {"Elektronika", "Telefoni" },
            };

            string jsonSerializovanjeObjekta = JsonConvert.SerializeObject(proizvod1);
            Console.WriteLine($"Primer serializovanog objekta u JSON formatu: \n{jsonSerializovanjeObjekta}");
        }
    }
}
