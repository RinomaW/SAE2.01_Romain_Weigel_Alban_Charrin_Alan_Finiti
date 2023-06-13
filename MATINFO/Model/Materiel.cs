using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO.Model
{
    internal class Materiel : CRUD
    {
        private string codeBarre;
        private string nomMateriel;
        private string reference;
        private CategorieMateriel categorieMateriel;

        public Materiel(string codeBarre, string nomMateriel, string reference, CategorieMateriel categorieMateriel)
        {
            this.CodeBarre = codeBarre;
            this.NomMateriel = nomMateriel;
            this.Reference = reference;
            this.CategorieMateriel = categorieMateriel;
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
                if (!(int.TryParse(value.Substring(0,1), out number) || value.Substring(1,1) != "-" || value.Length != 11))
                    this.reference = value.ToUpper();
                else throw new ArgumentException($"{value} is not valid.");
            }
        }

        internal CategorieMateriel CategorieMateriel
        {
            get
            {
                return this.categorieMateriel;
            }

            set
            {
                this.categorieMateriel = value;
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

        public override void Read()
        {
            base.Read();
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
