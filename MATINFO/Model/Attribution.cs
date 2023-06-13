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
    public class Attribution : Crud<Attribution>
    {
        private string commentaireAttribution;
        private Materiel materiel;
        private Personnel personnels;
        private DateTime dateAttribution;
        public Attribution(string commentaireAttribution, Materiel materiel, Personnel personnels)
        {
            this.CommentaireAttribution = commentaireAttribution;
            this.DateAttribution = DateTime.Today;
            this.Materiel = materiel;
            this.Personnels = personnels;
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
                    Attribution e = new Attribution(row["commentaireattribution"].ToString(), DateTime.Parse(row["dateattribution"].ToString()), new Materiel("3135131", "projecteur", "3153651351", new Categorie("ordi", 1),1), new Personnel());
                    LesAttribution.Add(e);
                }
            }
            return LesAttribution;
        }

        void Crud<Attribution>.Create()
        {
            throw new NotImplementedException();
        }

        void Crud<Attribution>.Read()
        {
            throw new NotImplementedException();
        }

        void Crud<Attribution>.Update()
        {
            throw new NotImplementedException();
        }

        void Crud<Attribution>.Delete()
        {
            throw new NotImplementedException();
        }

        ObservableCollection<Attribution> Crud<Attribution>.FindAll()
        {
            throw new NotImplementedException();
        }

        ObservableCollection<Attribution> Crud<Attribution>.FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }
    }
}
