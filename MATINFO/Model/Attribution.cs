using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO.Model
{
    public class Attribution : CRUD
    {
        private List<string> commentaires;
        private Materiel materiel;
        private List <Personnel> personnels;
        private DateTime dateAttribution;

        public Attribution()
        {
        }

        public Attribution(List<string> commentaires, Materiel materiel, List<Personnel> personnels)
        {
            this.Commentaires = commentaires;
            this.DateAttribution = DateTime.Today;
            this.Materiel = materiel;
            this.Personnels = personnels;
        }

        public Attribution(List<string> commentaires, DateTime dateAttribution, Materiel materiel, List<Personnel> personnels)
        {
            this.Commentaires = commentaires;
            this.DateAttribution = dateAttribution;
            this.Materiel = materiel;
            this.Personnels = personnels;
        }

        public List<string> Commentaires
        {
            get
            {
                return commentaires;
            }

            set
            {
                commentaires = value;
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

        public override void Update()
        {
            base.Update();
        }

        public ObservableCollection<Attribution> FindAll()
        {
            ObservableCollection<Attribution> lesEtudiants = new ObservableCollection<Attribution>();
            DataAccess accesBD = new DataAccess();
            String requete = "select * from est_attribue;";
            DataTable datas = accesBD.GetData(requete);
            if (datas != null)
            {
                foreach (DataRow row in datas.Rows)
                {
                    Attribution e = new Attribution(new List<string> { (String)row["commentaireattribution"] }, new Materiel ("3135131", "projecteur","3153651351", new CategorieMateriel("ordi")),new List <Personnel>());
                    lesEtudiants.Add(e);
                }
            }
            return lesEtudiants;
        }
    }
}
