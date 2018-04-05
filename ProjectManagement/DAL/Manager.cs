using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.DAL
{
    public abstract class Manager<T>
    {
        static protected List<T> liste_objets = new List<T>();
        public static int NombreObjets;

        public bool Ajouter(T o)
        {
            // Mouvaise solution
            try
            {
                liste_objets.Add(o);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Supprimer(int id)
        {
            T o = this.RechercherParId(id);
            liste_objets.Remove(o);
        }

        public abstract void Modifier(T o);


        public abstract T RechercherParId(int id);


        public List<T> GetList()
        {
            return liste_objets;
        }
    }
}
