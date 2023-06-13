using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO.Model
{
    internal class CategorieMateriel : CRUD
    {
        private string nomCategorie;

        public HashSet<string> nomUniques;

        public CategorieMateriel(string nomCategorie)
        {
            testNomUnique();
            this.NomCategorie = nomCategorie;
        }

        public CategorieMateriel()
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
                this.nomCategorie = value;
            }
        }


        public void testNomUnique ()
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

        public override void Create()
        {
            base.Create();
        }

        public override void Read()
        {
            base.Read();
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Delete()
        {
            base.Delete();
        }
    }
}
