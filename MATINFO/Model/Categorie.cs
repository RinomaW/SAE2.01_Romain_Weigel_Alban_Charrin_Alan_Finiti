using MATINFO.Model;
using MATINFO.MODEL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO
{
    public class Categorie : Crud<Categorie>
    {
        private string nomCategorie;
        private int iD_Categorie = 1;
        public HashSet<string> nomUniques;

        public Categorie(string nomCategorie)
        {
            testNomUnique();
            this.NomCategorie = nomCategorie;
            this.ID_Categorie++;
        }

        public Categorie()
        {
        }

        public string NomCategorie
        {
            get
            {
                return this.nomCategorie;
            }
            set
            {
                if (value is null)
                    throw new ArgumentNullException("Ce champ ne peut pas être null");
                this.nomCategorie = value;
            }
        }

        public int ID_Categorie
        {
            get
            {
                return this.iD_Categorie;
            }

            set
            {
                this.iD_Categorie = value;
            }
        }


        public void testNomUnique()
        {
            if (nomUniques.Contains(this.NomCategorie))
            {
                // La variable existe déjà
                throw new ArgumentException("le nom n'est pas unique");
            }
            else
            {
                // La variable est unique, l'ajouter au HashSet
                nomUniques.Add(this.NomCategorie);
            }
        }


        void Crud<Categorie>.Create()
        {
            throw new NotImplementedException();
        }

        void Crud<Categorie>.Read()
        {
            throw new NotImplementedException();
        }

        void Crud<Categorie>.Update()
        {
            throw new NotImplementedException();
        }

        void Crud<Categorie>.Delete()
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Categorie> FindAll()
        {
            ObservableCollection<Categorie> LesCategorie = new ObservableCollection<Categorie>();
            DataAccess accesBD = new DataAccess();
            String requete = "select nomcategorie from categorie_materiel";
            DataTable datas = accesBD.GetData(requete);
            if (datas != null)
            {
                foreach (DataRow row in datas.Rows)
                {
                    Categorie e = new Categorie((string)row["nomcategorie"]);
                    LesCategorie.Add(e);
                }
            }
            return LesCategorie;
        }

        ObservableCollection<Categorie> Crud<Categorie>.FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }
    }
}
