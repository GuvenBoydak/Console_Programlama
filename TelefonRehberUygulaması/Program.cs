using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberUygulaması.Entity;

namespace TelefonRehberUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            TelefonRehberi.TelNumaralari.Add(new TelefonNumaralari("Tugrul", "Kızıldemir", "05353742094"));
            TelefonRehberi.TelNumaralari.Add(new TelefonNumaralari("Kezban", "Demoglu", "05353742093"));
            TelefonRehberi.TelNumaralari.Add(new TelefonNumaralari("Ali", "Demir", "05353742092"));
            TelefonRehberi.TelNumaralari.Add(new TelefonNumaralari("Aylin", "Derin", "05353742091"));
            TelefonRehberi.TelNumaralari.Add(new TelefonNumaralari("Güven", "Deniz", "05353742090"));
            


            TelefonRehberi.YapmakIstediginizIslem();
            Console.ReadLine();

        }


        
    }
}
