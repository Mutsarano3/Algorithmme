using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmie
{
    class Program
    {
        static void Main(string[] args)
        {
            /*---------Liste chainée-----------------*/
            /*Chiarelli Thomas*/
            Liste_chainée<int> liste = new Liste_chainée<int>();
            Ensemble<int> ensemble = new Ensemble<int>();
            Pile<int> stack = new Pile<int>();
            Console.WriteLine("------Ajout premier------");
            /*Ajout premier*/  
            liste.Ajouterpremeir(3);
            Console.WriteLine(liste.Root.Value);
            /*Ajouter*/
            
            /*Ajout premier*/ //On vois que le rout a bien changer
            Console.WriteLine("----------------------");
            /*Ajouter au dernier*/
            Console.WriteLine("------Ajout dernier------");
            liste.AjouterListe_simple_chainée(liste,4);
            liste.AjouterListe_simple_chainée(liste,3);
            liste.AjouterListe_simple_chainée(liste,5);
            liste.AjouterListe_simple_chainée(liste,20);
            Console.WriteLine(liste.Root.Value);
            Console.WriteLine(liste.Root.Next.Value);
            Console.WriteLine(liste.Root.Next.Next.Value);
            Console.WriteLine(liste.Root.Next.Next.Next.Value);
            Console.WriteLine(liste.Root.Next.Next.Next.Next.Value);
            Console.WriteLine("----------------------");
            /*Ajouter au dernier*/
            
            Console.WriteLine(liste.Root.Value);
            Console.WriteLine(liste.Root.Next.Value);
            Console.WriteLine(liste.Root.Next.Next.Value);
            Console.WriteLine(liste.Root.Next.Next.Next.Value);
            Console.WriteLine(liste.Root.Next.Next.Next.Next.Value);
            
            /*Compter*/
            Console.WriteLine("------Compter------");
            Console.WriteLine(Convert.ToString(liste.Compter()));
            /*Compter*/
            /*Retirer le premier*/
            Console.WriteLine("------Retirer le premier------");
            Console.WriteLine(liste.Root.Value);
            liste.RemoveFirst();
            Console.WriteLine(liste.Root.Value);
            Console.WriteLine("----------------------"); //On vois que la nouvelle racine c'est 4
            /*Retirer le premier*/
            /*Retirer le dernier*/
            Console.WriteLine("------Retirer le dernier------");
            Console.WriteLine(Convert.ToString(liste.Root.Next.Next.Next.Value));
            //liste.RemoveLast(liste);
            Console.WriteLine(liste.Root.Next.Next.Next.Value);
            Console.WriteLine("----------------------");
            /*Compter*/
            Console.WriteLine("------Compter------");
            Console.WriteLine(Convert.ToString(liste.Compter()));
            Console.WriteLine("----------------------");
            /*Compter*/
            /*Chercher la position*/
            Console.WriteLine("------Chercher la position------");
            Console.WriteLine(liste.Recherche_position(5));
            Console.WriteLine("----------------------");
            /*Chercher la position*/
            /*Chercher une valeurs*/
            Console.WriteLine("------Chercher une valeur------");
            Console.WriteLine(Convert.ToString(liste.Recherche_valeurs(5)));
            Console.WriteLine("----------------------");
            /*Chercher une valeurs*/
            Console.WriteLine("------Retirer------");
            Console.WriteLine(Convert.ToString(liste.Root.Next.Value));
            liste.Remove(1);
            Console.WriteLine(liste.Root.Next.Value);
            Console.WriteLine("----------------------");
            Console.WriteLine(Convert.ToString(liste.Remove(1)));
            Console.WriteLine(liste.Root.Value);
            Console.WriteLine(liste.Root.Next.Value);
            Console.WriteLine(liste.Root.Next.Next.Value);
            Console.WriteLine(liste.Root.Next.Next.Next.Value);
            //Console.WriteLine(liste.Root.Next.Next.Next.Next.Value);
            Console.WriteLine("----------------------");
            Console.WriteLine("Ensemble");
            Console.WriteLine(ensemble.Ajouter_element(8));
            Console.WriteLine(ensemble.Ajouter_element(2));
            Console.WriteLine(ensemble.Ajouter_element(1));
            Console.WriteLine(ensemble.Ajouter_element(7));
            Console.WriteLine(ensemble.Ajouter_element(5));
            Console.WriteLine(ensemble.Ajouter_element(0));
            Console.WriteLine(ensemble.Root.Value);
            Console.WriteLine(ensemble.Root.Next.Value);
            Console.WriteLine(ensemble.Root.Next.Next.Value);
            Console.WriteLine("----------------------");
            Console.WriteLine("Supprimer");
            ensemble.Supprimer(1);
            Console.WriteLine(ensemble.Root.Value);
            Console.WriteLine(ensemble.Root.Next.Value);
            Console.WriteLine(ensemble.Root.Next.Next.Value);
            Console.WriteLine("----------------------");
            Console.WriteLine("Pile");
            Console.WriteLine("Push");
            stack.push(2);
            Console.WriteLine(stack.Root.Value);
            Console.WriteLine("----------------------");
            Console.ReadKey();
        }
    }
}
