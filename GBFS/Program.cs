using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFS
{
    class Program
    {

        static void Main(string[] args)
        {
            Graph<String> kuşUçuşuYollar = new Graph<string>();
            GraphNode<String> Çanakkale = new GraphNode<String>("Çanakkale");
            GraphNode<String> İzmir = new GraphNode<String>("İzmir");
            GraphNode<String> Edirne = new GraphNode<String>("Edirne");
            GraphNode<String> Tekirdağ = new GraphNode<String>("Tekirdağ");
            GraphNode<String> Balıkesir = new GraphNode<String>("Balıkesir");
            GraphNode<String> Bursa = new GraphNode<String>("Bursa");
            GraphNode<String> Eskişehir = new GraphNode<String>("Eskişehir");
            GraphNode<String> Afyon = new GraphNode<String>("Afyon");
            GraphNode<String> Uşak = new GraphNode<String>("Uşak");
            GraphNode<String> Kocaeli = new GraphNode<String>("Kocaeli");
            GraphNode<String> Bolu = new GraphNode<String>("Bolu");
            GraphNode<String> İstanbul = new GraphNode<String>("İstanbul");
            GraphNode<String> Kütahya = new GraphNode<String>("Kütahya");
            GraphNode<String> Manisa = new GraphNode<String>("Manisa");
            GraphNode<String> Ankara = new GraphNode<String>("Ankara");

            int ÇanakkaleWeight = 547;
            int İzmirWeight     = 521;
            int EdirneWeight    = 565;
            int TekirdağWeight  = 468;
            int BalıkesirWeight = 427;
            int BursaWeight     = 323;
            int EskişehirWeight = 199;
            int AfyonWeight     = 239;
            int UşakWeight      = 328;
            int KocaeliWeight   = 265;
            int BoluWeight      = 139;
            int İstanbulWeight  = 350;
            int KütahyaWeight   = 253;
            int ManisaWeight    = 490;
            int AnkaraWeight    = 0;
            

            kuşUçuşuYollar.AddUndirectedEdge(Çanakkale, İzmir, İzmirWeight);
            kuşUçuşuYollar.AddUndirectedEdge(Çanakkale, Bursa, BursaWeight);
            kuşUçuşuYollar.AddUndirectedEdge(Çanakkale, Balıkesir, BalıkesirWeight);
            kuşUçuşuYollar.AddUndirectedEdge(Çanakkale, Tekirdağ, TekirdağWeight);
            kuşUçuşuYollar.AddUndirectedEdge(Çanakkale, Edirne, EdirneWeight);

            kuşUçuşuYollar.AddUndirectedEdge(İzmir, Uşak, UşakWeight);
            kuşUçuşuYollar.AddUndirectedEdge(İzmir, Manisa, ManisaWeight);

            kuşUçuşuYollar.AddUndirectedEdge(Balıkesir, Bursa, BursaWeight);
            kuşUçuşuYollar.AddUndirectedEdge(Balıkesir, Manisa, ManisaWeight);

            kuşUçuşuYollar.AddUndirectedEdge(Bursa, Eskişehir, EskişehirWeight);
            kuşUçuşuYollar.AddUndirectedEdge(Bursa, Kocaeli, KocaeliWeight);
            kuşUçuşuYollar.AddUndirectedEdge(Bursa, İstanbul, İstanbulWeight);

            kuşUçuşuYollar.AddUndirectedEdge(Tekirdağ, İstanbul, İstanbulWeight);

            kuşUçuşuYollar.AddUndirectedEdge(Edirne, Tekirdağ, TekirdağWeight);
            kuşUçuşuYollar.AddUndirectedEdge(Edirne, İstanbul, İstanbulWeight);

            kuşUçuşuYollar.AddUndirectedEdge(İstanbul, Kocaeli, KocaeliWeight);

            kuşUçuşuYollar.AddUndirectedEdge(Kocaeli, Eskişehir, EskişehirWeight);
            kuşUçuşuYollar.AddUndirectedEdge(Kocaeli, Bolu, BoluWeight);

            kuşUçuşuYollar.AddUndirectedEdge(Bolu, Ankara, AnkaraWeight);

            kuşUçuşuYollar.AddUndirectedEdge(Eskişehir, Kütahya, KütahyaWeight);
            kuşUçuşuYollar.AddUndirectedEdge(Eskişehir, Ankara, AnkaraWeight);

            kuşUçuşuYollar.AddUndirectedEdge(Kütahya, Afyon, AfyonWeight);

            kuşUçuşuYollar.AddUndirectedEdge(Uşak, Afyon, AfyonWeight);

            kuşUçuşuYollar.AddUndirectedEdge(Afyon, Ankara, AnkaraWeight);



            Dictionary<String, int> mesafeliYollar = new Dictionary<string, int>();
            mesafeliYollar.Add("Çanakkale, İzmir", 325);
            mesafeliYollar.Add("Çanakkale, Bursa", 271);
            mesafeliYollar.Add("Çanakkale, Balıkesir", 207);
            mesafeliYollar.Add("Çanakkale, Tekirdağ", 188);
            mesafeliYollar.Add("Çanakkale, Edirne", 217);
            mesafeliYollar.Add("Edirne, Tekirdağ", 140);
            mesafeliYollar.Add("Edirne, İstanbul", 229);
            mesafeliYollar.Add("Tekirdağ, İstanbul", 132);
            mesafeliYollar.Add("İzmir, Manisa", 36);
            mesafeliYollar.Add("Balıkesir, Manisa", 137);
            mesafeliYollar.Add("Balıkesir, Bursa", 151);
            mesafeliYollar.Add("Bursa, Eskişehir", 149);
            mesafeliYollar.Add("Bursa, İstanbul", 243);
            mesafeliYollar.Add("Bursa, Kocaeli", 132);
            mesafeliYollar.Add("Eskişehir, Kütahya", 78);
            mesafeliYollar.Add("Eskişehir, Ankara", 233);
            mesafeliYollar.Add("Kütahya, Afyon", 100);
            mesafeliYollar.Add("Afyon, Ankara", 256);
            mesafeliYollar.Add("İzmir, Uşak", 211);
            mesafeliYollar.Add("Uşak, Afyon", 116);
            mesafeliYollar.Add("Kocaeli, Bolu", 151);
            mesafeliYollar.Add("Kocaeli, Eskişehir", 219);
            mesafeliYollar.Add("Bolu, Ankara", 191);
            mesafeliYollar.Add("İstanbul, Kocaeli", 111);

            List<GraphNode<String>> güzergah = new List<GraphNode<string>>();
            YolHesapla(mesafeliYollar, Çanakkale, Ankara, 0, 0, güzergah);


        }

        public static void YolHesapla(Dictionary<String,int> mesafeliYollar, GraphNode<String> from, GraphNode<String> to, int trueCost, int birdFlightCost, List<GraphNode<String>> enKisaGuzergah)
        {
            enKisaGuzergah.Add(from);
            int minBirdFlightDistance = Int32.MaxValue;
            int trueDistance = 0;
            GraphNode<String> temp = new GraphNode<string>();
            if (from.Data == to.Data)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nİzlenilecek güzergah");
                foreach (var yol in enKisaGuzergah)
                {
                    if (yol == enKisaGuzergah.Last())
                        Console.WriteLine(yol.Data);
                    else
                        Console.Write(yol.Data + " -> ");
                    
                }
                Console.WriteLine("Toplam Kuşuçuşu Uzaklık: " + birdFlightCost + "km");
                Console.WriteLine("Toplam Gerçek Uzaklık: " + trueCost + "km");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("\nÇıkmak için bir tuşa basın..");
                Console.ReadKey();
                return;
            }

            else
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("<------------" + from.Data + " şehrinin komşuları listeleniyor------->");
                
                 
                for (int i = 0; i < from.Neighbors.Count; i++)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(from.Data + " => " + from.Neighbors[i].Value + ": " + from.Costs[i] + "km");
                    if (from.Costs[i] < minBirdFlightDistance)
                    {
                        temp = (GraphNode<String>)from.Neighbors[i];
                        minBirdFlightDistance = from.Costs[i];
                    }
                }
            }
            trueDistance = mesafeliYollar[from.Data + ", " + temp.Data];
            trueCost += trueDistance;
            birdFlightCost += minBirdFlightDistance;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n###### Bulunan en kısa yol: " + from.Data + " => " + temp.Data + ": " + minBirdFlightDistance + "km");
            YolHesapla(mesafeliYollar, temp, to, trueCost, birdFlightCost, enKisaGuzergah);
        }
    }
}
