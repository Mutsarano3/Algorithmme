using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmie
{
      class Liste_chainée<T>
    {

        public Liste_chainée<T> Next { get; set; }
        public T Value { get; set; }
        public Liste_chainée<T> Root { get; private set; }
        public Liste_chainée<T> Previous { get; set; }
        public Liste_chainée<T> Current { get; set; }

        public void AjouterListe_simple_chainée(Liste_chainée<T> tempo,T elements)
        {
            if (Root == null)
            {
                Root = new Liste_chainée<T> { Value = elements };
            }
            else
            {
                Liste_chainée<T> current = Root;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Liste_chainée<T> { Value = elements };

            }

        }
       
        public void Ajouterpremeir(T element)
        {
            if (Root == null)
            {
                Root = new Liste_chainée<T> { Value = element };
            }
            else
            {
                Root.Next = Root;
                Root = new Liste_chainée<T> { Value = element };

            }

        }
        public object RemoveLast(Liste_chainée<T> tempo)
        {
            if (tempo.Root == null)
            {
                
            }
            tempo.Previous = null;
            Liste_chainée<T> current = tempo.Root;
            while (current.Next != null)
            {
                Previous = current;
                current = current.Next;
               
            }
            if (tempo.Previous == null)
            {
                tempo.Root = null;

            }
            else
            {
                current = current.Previous;
                

            }
            current.Previous = null;




            return null;
        }
        public int Compter()
        {
            int compteur = 0;
            Liste_chainée<T> current = Root;
            while (current != null)
            {
                current = current.Next;
                compteur++;
            }
            return compteur;
        }
        public Liste_chainée<T> RemoveFirst()
        {
            if (Root == null) return null;
            Root = Root.Next;
            return null;
        }
        public int Recherche_position(int elements)
        {
            int position = 0;
            Liste_chainée<T> current = Root;
            while(current != null)
            {
                if(Convert.ToInt32(current.Value) == elements)
                {
                    return position;

                }
                position++;
                current = current.Next;

            }
            return -1;
        }
        public virtual Liste_chainée<T> Recherche_valeurs(int elements)
        {
             Current = Root;
            while(Current != null)
            {
                if (Convert.ToInt32(Current.Value) == elements)
                {
                    
                    return Current;
                }
                Current = Current.Next;

            }
            return null;

        }
        public Liste_chainée<T>  Remove(int indice)
        {
            int cpt = 0;
            Liste_chainée<T> current = Root;
            while (cpt < indice)
            {
                cpt++;
                Previous = current;
                current = current.Next;

            }

            //current.Value = current.Next.Value;
            return null;
        }
        /********************************************/
      
        

    }
}





