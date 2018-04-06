using ProjectManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.DAL
{
    public abstract class Manager<T> where T: BaseEntity
    {
        static protected List<T> liste_objets = new List<T>();
        public static int NombreObjets;

        public bool Save(T obj)
        {
            if (obj.Id == 0)
               return this.Ajouter(obj);
            else
                return this.Update(obj);

        }




        public bool Ajouter(T o)
        {
            // Mouvaise solution ?
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

        public bool Update(T obj)
        {
            T existantEntity = liste_objets.Where(o => o.Id == obj.Id).FirstOrDefault();
            int indexOfExistantEntity = liste_objets.IndexOf(existantEntity);
            liste_objets[indexOfExistantEntity] = obj;
            return true;
        }


        public abstract T RechercherParId(int id);


        public List<T> GetList()
        {
            return liste_objets;
        }
    }
}
