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
        private int idMateriel;
        private int idPersonnels;
        private DateTime dateAttribution;
        public Attribution(string commentaireAttribution, int idMateriel, int idPersonnels)
        {
            this.CommentaireAttribution = commentaireAttribution;
            this.DateAttribution = DateTime.Today;
            this.IdMateriel = idMateriel;
            this.IdPersonnels = idPersonnels;
        }

        public Attribution(string commentaireAttribution, DateTime dateAttribution, int idMateriel, int idPersonnels)
        {
            this.CommentaireAttribution = commentaireAttribution;
            this.DateAttribution = dateAttribution;
            this.IdMateriel = idMateriel;
            this.IdPersonnels = idPersonnels;
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

        public int IdMateriel
        {
            get
            {
                return idMateriel;
            }

            set
            {
                idMateriel = value;
            }
        }

        public int IdPersonnels
        {
            get
            {
                return idPersonnels;
            }

            set
            {
                idPersonnels = value;
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
                    DateTime date = DateTime.Parse(row["dateattribution"].ToString());
                    Attribution e = new Attribution(row["commentaireattribution"].ToString(), new DateTime(date.Year, date.Month, date.Day), (int)row["idmateriel"], (int)row["idcategorie"]); 
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
