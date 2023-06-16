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
        ObservableCollection<Materiel> lesMateriel;

        public Categorie(string nomCategorie, int idCategorie)
        {
            this.NomCategorie = nomCategorie;
            this.ID_Categorie = idCategorie;
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

        public ObservableCollection<Materiel> LesMateriel
        {
            get
            {
                return lesMateriel;
            }

            set
            {
                lesMateriel = value;
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


        public void Create(string texte)
        {
            String requete = "INSERT INTO categorie VALUES ('" + texte + "')";
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
            String requete = "UPDATE Categorie SET nomcategorie = " + nomChangement + " WHERE nomcategorie = " +this.nomCategorie;
            accesBD.SetData(requete);
        }

        public void Delete()
        {
            DataAccess accesBD = new DataAccess();
            String requete = "DELETE FROM Categorie WHERE nomcategorie = " + this.nomCategorie;
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
    }
}
