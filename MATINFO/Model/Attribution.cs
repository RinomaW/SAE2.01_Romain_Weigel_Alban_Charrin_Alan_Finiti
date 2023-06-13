using MATINFO.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO
{
    public class Attribution : CRUD
    {
        private string commentaireAttribution;
        private Materiel materiel;
        private Personnel personnels;
        private DateTime dateAttribution;
        private int iD_Attribution = 1;
        public Attribution(string commentaireAttribution, Materiel materiel, Personnel personnels)
        {
            this.CommentaireAttribution = commentaireAttribution;
            this.DateAttribution = DateTime.Today;
            this.Materiel = materiel;
            this.Personnels = personnels;
            this.ID_Attribution++;
        }

        public Attribution(string commentaireAttribution, DateTime dateAttribution, Materiel materiel,Personnel personnels)
        {
            this.CommentaireAttribution = commentaireAttribution;
            this.DateAttribution = dateAttribution;
            this.Materiel = materiel;
            this.Personnels = personnels;
        }
        public Attribution() { }

        public string CommentaireAttribution
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

        internal Personnel Personnels
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
        public ObservableCollection<Attribution> FindAll()
        {
            ObservableCollection<Attribution> LesAttribution = new ObservableCollection<Attribution>();
            DataAccess accesBD = new DataAccess();
            String requete = "select * from est_attribue;";
            DataTable datas = accesBD.GetData(requete);
            if (datas != null)
            {
                foreach (DataRow row in datas.Rows)
                {
                    Attribution e = new Attribution(new List<string> { (String)row["commentaireattribution"] }, new Materiel("3135131", "projecteur", "3153651351", new Categorie("ordi")), new List<Personnel>());
                    LesAttribution.Add(e);
                }
            }
            return LesAttribution;
        }
    }
}
