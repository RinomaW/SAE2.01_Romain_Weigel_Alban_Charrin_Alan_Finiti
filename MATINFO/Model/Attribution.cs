using MATINFO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO
{
    public class Attribution : CRUD
    {
        private List<string> commentaireAttribution;
        private Materiel materiel;
        private List<Personnel> personnels;
        private DateTime dateAttribution;
        private int iD_Attribution = 1;
        public Attribution(List<string> commentaireAttribution, Materiel materiel, List<Personnel> personnels)
        {
            this.CommentaireAttribution = commentaireAttribution;
            this.DateAttribution = DateTime.Today;
            this.Materiel = materiel;
            this.Personnels = personnels;
            this.ID_Attribution++;
        }

        public Attribution(List<string> commentaireAttribution, DateTime dateAttribution, Materiel materiel, List<Personnel> personnels)
        {
            this.CommentaireAttribution = commentaireAttribution;
            this.DateAttribution = dateAttribution;
            this.Materiel = materiel;
            this.Personnels = personnels;
        }
        public Attribution() { }

        public List<string> CommentaireAttribution
        {
            get
            {
                return commentaireAttribution;
            }

            set
            {
                commentaireAttribution = value;
            }
        }

        public DateTime DateAttribution
        {
            get
            {
                return dateAttribution;
            }

            set
            {
                dateAttribution = value;
            }
        }

        public int ID_Attribution
        {
            get
            {
                return iD_Attribution;
            }

            set
            {
                iD_Attribution = value;
            }
        }

        internal Materiel Materiel
        {
            get
            {
                return materiel;
            }

            set
            {
                materiel = value;
            }
        }

        internal List<Personnel> Personnels
        {
            get
            {
                return this.personnels;
            }

            set
            {
                this.personnels = value;
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
