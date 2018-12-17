using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmie
{
    class Pile<T>:Liste_chainée<T>
    {
        public void push(T valeurs)
        {
            Pile<T> element = new Pile<T>();
            element.Value = valeurs;
            AjouterListe_simple_chainée(element, valeurs);

        }
        public int pop(Liste_chainée<T> pile)
        {
            Liste_chainée<T> current = pile.Root ;
            while(current.Next != null)
            {
                current = current.Next;
                RemoveLast(pile);

            }
            return Convert.ToInt32(pile.Value);
           

        }
    }
}
