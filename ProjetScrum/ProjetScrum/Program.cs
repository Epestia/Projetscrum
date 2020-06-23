//exercice 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProjetScrum1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Clear();
            Console.WriteLine("Choisir un option:");
            Console.WriteLine("1) Nouvelle personne");
            Console.WriteLine("2) supprimer personne");
            Console.Write("\r\nChoisir un option : ");
            Console.ReadLine();
   
            Console.WriteLine("\r\nEncodage films : ");
            Console.Write("\r\nTapper votre film: ");
            string Film = Console.ReadLine();
            Console.ReadLine();
          
            Console.WriteLine("\r\nAnnée de sortie : ");
            Console.Write("\r\nTapper votre Année de sorti : ");
            Console.ReadLine();
            int année;
            Console.ReadLine(année);

            Console.WriteLine("\r\nSon réalisateur : ");
            Console.Write("\r\nTapper Son Réalisateur: ");
            Console.ReadLine();
            string réalisateur = Console.ReadLine();

            Console.WriteLine("\r\nNote sur 10 : ");
            Console.Write("\r\nTapper votre Note sur 10 : ");
            Console.ReadLine();
            int note = note.ToString(Console.ReadLine());

            Console.WriteLine("\r\nCritique du film :");
            Console.Write("\r\nTapper votre Critique ");
            Console.ReadLine();
            string crtique = Console.ReadLine();

            Console.ReadKey();
    
        }

    }
}