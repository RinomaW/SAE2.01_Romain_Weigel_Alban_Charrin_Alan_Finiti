using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO
{
    public class Materiel : CRUD
    {
        private string codeBarre;
        private string nomMateriel;
        private string reference;
        private Categorie categorie;
        private int iD_Materiel = 1;
        private Attribution attribution;
        public Materiel(string codeBarre, string nomMateriel, string reference, Categorie categorie)
        {
            this.CodeBarre = codeBarre;
            this.NomMateriel = nomMateriel;
            this.Reference = reference;
            this.ID_Categorie = categorie.ID_Categorie;
            this.ID_Materiel++;
        }

        public string CodeBarre
        {
            get
            {
                return codeBarre;
            }

            set
            {
                if (value.Length == 15)
                    codeBarre = value.ToUpper();
                else throw new ArgumentException("valeur non négative ou supérieur à 15");
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
                int number;
                if (!(int.TryParse(value.Substring(0, 1), out number) || value.Substring(1, 1) != "-" || value.Length != 11))
                    this.reference = value.ToUpper();
                else throw new ArgumentException($"{value} is not valid.");
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

        internal int ID_Categorie
        {
            get
            {
                return this.categorie.ID_Categorie;
            }

            set
            {
                this.categorie.ID_Categorie = value;
            }
        }

        internal int ID_Attribution
        {
            get
            {
                return this.attribution.ID_Attribution;
            }

            set
            {
                this.attribution.ID_Attribution = value;
            }
        }

        public override void Create()
        {
            base.Create();
        }

        public override void Delete()
        {
            base.Delete();
        }

        public override void Find()
        {
            base.Find();
        }

        public override void Read()
        {
            base.Read();
        }

        public override void Select()
        {
            base.Select();
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
