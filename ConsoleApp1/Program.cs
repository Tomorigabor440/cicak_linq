using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Szine { zold, Rozsaszin, Feher, Lila, Fekete}
    enum Neme { Fiu, Lany}
    class Cica
    {
        public int ID { get; set; }
        public string Neve { get; set; }
        public Szine Szine { get; set; }
        public DateTime SzuletesiDatum { get; set; }
        public Neme Neme { get; set; }
        public int Suly  { get; set; }
        public int Kor => DateTime.Now.Year - SzuletesiDatum.Year;

        public override string ToString()
        {
            return $"{ID,-5}{Neve,-15}{Szine,-10}{SzuletesiDatum.ToString("yyy.MM.dd"),-15}{Neme,-10}{Suly,-5}{Kor}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Cica> cicak = new List<Cica>()
            {
                new Cica()
                {
                    ID=1,
                    Neme=Neme.Fiu,
                    Neve="Megatron",
                    Suly=10,
                    Szine=Szine.Fekete,
                    SzuletesiDatum=new DateTime(2018,08,13),

                },
                new Cica()
                {
                    ID=2,
                    Neme=Neme.Lany,
                    Neve="Pizsama",
                    Suly=4,
                    Szine=Szine.Rozsaszin,
                    SzuletesiDatum=new DateTime(2022,12,20),
                },
                new Cica()
                {
                    ID=3,
                    Neme=Neme.Fiu,
                    Neve="Cesar",
                    Suly=5,
                    Szine=Szine.Fekete,
                    SzuletesiDatum=new DateTime(2023,10,27),
                },
                new Cica()
                {
                    ID=4,
                    Neme=Neme.Lany,
                    Neve="cica",
                    Suly=3,
                    Szine=Szine.Feher,
                    SzuletesiDatum=new DateTime(2023,02,11),
                },
            };

            Cica elsoCica=cicak.First();
            Console.WriteLine(elsoCica);

            Cica utolsoCica = cicak.Last();
            Console.WriteLine(utolsoCica);

            Console.ReadKey();
        }
    }
}
