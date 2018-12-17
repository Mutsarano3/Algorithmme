using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmie
{
    class Ensemble<T>:Liste_chainée<T>
    {
        public bool Ajouter_element(T data)
        {
            object element = Recherche_valeurs(Convert.ToInt32(data));
            if (element == null)
            {
               Liste_chainée<T> elements = new Ensemble<T>();
                elements.Value = data;
                AjouterListe_simple_chainée(elements,data);
                return true;
            }
            return false;
        }
        public void Supprimer(T data)
        {
        
            Liste_chainée<T> elements = Recherche_valeurs(Convert.ToInt32(data));
            if(elements != null)
            {
                Previous = elements.Previous;
                Next = elements.Next;
                //Previous.Next = Next;
                //Next.Previous = Previous;
            }
        }
    }
}
