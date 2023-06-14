using MATINFO.Model;
using MATINFO.MODEL;
using System;
using System.Collections.ObjectModel;
using System.Data;

namespace MATINFO
{
    public class Materiel : Crud<Materiel>
    {
        private Categorie uneCategorie;
        private string codeBarre;
        private string nomMateriel;
        private string reference;
        private int idCategorie;
        private int iD_Materiel;
        ObservableCollection<Attribution> lesAttributions;

        public Materiel()
        {
        }

        public Materiel(string codeBarre, string nomMateriel, string reference, int idCategorie, int idmateriel)
        {
            this.CodeBarre = codeBarre;
            this.NomMateriel = nomMateriel;
            this.Reference = reference;
            this.IdCategorie = idCategorie;
            this.ID_Materiel = idmateriel;
        }

        public string CodeBarre
        {
            get
            {
                return codeBarre;
            }

            set
            {
                codeBarre = value.ToUpper();
            }
        }

        public string NomMateriel
        {
            get
            {
                return nomMateriel;
            }

            set
            {
                nomMateriel = value.ToUpper();
            }
        }

        public string Reference
        {
            get
            {
                return this.reference;
            }

            set
            {
               this.reference = value.ToUpper();
            }
        }

        public int ID_Materiel
        {
            get
            {
                return this.iD_Materiel;
            }

            set
            {
                this.iD_Materiel = value;
            }
        }

        public int IdCategorie
        {
            get
            {
                return idCategorie;
            }

            set
            {
                idCategorie = value;
            }
        }


        public Categorie UneCategorie
        {
            get
            {
                return uneCategorie;
            }

            set
            {
                uneCategorie = value;
            }
        }

        public ObservableCollection<Attribution> LesAttributions
        {
            get
            {
                return lesAttributions;
            }

            set
            {
                lesAttributions = value;
            }
        }

        void Crud<Materiel>.Create()
        {
            throw new NotImplementedException();
        }

        void Crud<Materiel>.Delete()
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Materiel> FindAll()
        {
            ObservableCollection<Materiel> LesMateriels = new ObservableCollection<Materiel>();
            DataAccess accesBD = new DataAccess();
            String requete = "select * from materiel";
            DataTable datas = accesBD.GetData(requete);
            if (datas != null)
            {
                foreach (DataRow row in datas.Rows)
                {
                    Materiel e = new Materiel((string)row["codebarreinventaire"],(string)row["nommateriel"], (string)row["referenceconstructeurmateriel"], (int)row["idcategorie"],(int)row["idmateriel"]);
                    LesMateriels.Add(e);
                }
            }
            return LesMateriels;
        }

        ObservableCollection<Materiel> Crud<Materiel>.FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }

        void Crud<Materiel>.Read()
        {
            throw new NotImplementedException();
        }

        void Crud<Materiel>.Update()
        {
            throw new NotImplementedException();
        }
    }
}
