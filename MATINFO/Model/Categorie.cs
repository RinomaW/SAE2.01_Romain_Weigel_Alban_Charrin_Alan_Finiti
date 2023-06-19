using MATINFO.Model;
using MATINFO.MODEL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO.Model
{
    public class Categorie : Crud<Categorie>
    {

        private string nomCategorie;
        private int iD_Categorie;
        public HashSet<string> nomUniques;
        ObservableCollection<Materiel> lesMateriels;

        public Categorie(string nomCategorie, int idCategorie)
        {
            this.NomCategorie = nomCategorie;
            this.ID_Categorie = idCategorie;
        }
        public Categorie(string nomCategorie)
        {
            this.NomCategorie = nomCategorie;
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

        public ObservableCollection<Materiel> LesMateriels
        {
            get
            {
                return lesMateriels;
            }

            set
            {
                lesMateriels = value;
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


        public void Create()
        {
            String requete = "INSERT INTO categorie_materiel (nomcategorie) VALUES ('" + this.nomCategorie + "');";
            DataAccess accesBD = new DataAccess();
            accesBD.SetData(requete);
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Update(string nomChangement)
        {
            DataAccess accesBD= new DataAccess();
            String requete = "UPDATE categorie_materiel SET nomcategorie = " + nomChangement + " WHERE nomcategorie = " +this.nomCategorie;
            accesBD.SetData(requete);
        }

        public void Delete()
        {
            DataAccess accesBD = new DataAccess();
            String requete = "DELETE FROM categorie_materiel WHERE nomcategorie = \"" + this.nomCategorie + "\"";
            accesBD.SetData(requete);
        }

        public ObservableCollection<Categorie> FindAll()
        {
            ObservableCollection<Categorie> LesCategories = new ObservableCollection<Categorie>();
            DataAccess accesBD = new DataAccess();
            String requete = "select nomcategorie, idcategorie from categorie_materiel";
            DataTable datas = accesBD.GetData(requete);
            if (datas != null)
            {
                foreach (DataRow row in datas.Rows)
                {
                    Categorie e = new Categorie((string)row["nomcategorie"], (int)row["idcategorie"]);
                    LesCategories.Add(e);
                }
            }
            return LesCategories;
        }

        ObservableCollection<Categorie> Crud<Categorie>.FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }

        void Crud<Categorie>.Create()
        {
            throw new NotImplementedException();
        }
        public static Categorie Find(string nomCategorie)
        {
            ObservableCollection<Categorie> LesCategories = new ObservableCollection<Categorie>();
            Categorie cat = null;
            foreach (Categorie c in LesCategories)
            {
                if (c.NomCategorie == nomCategorie)
                    cat = c;
            }
            return cat;
        }
    }
}
