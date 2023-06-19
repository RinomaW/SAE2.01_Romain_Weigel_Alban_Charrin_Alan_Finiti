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
    public class Attribution : Crud<Attribution>
    {
        private string commentaireAttribution;
        private int idMateriel;
        private int idPersonnels;
        private DateTime dateAttribution;
        private Personnel unPersonnel;
        private Materiel unMateriel;

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

        public Personnel UnPersonnel
        {
            get
            {
                return unPersonnel;
            }

            set
            {
                unPersonnel = value;
            }
        }

        public Materiel UnMateriel
        {
            get
            {
                return unMateriel;
            }

            set
            {
                unMateriel = value;
            }
        }

        public ObservableCollection<Attribution> FindAll()
        {
            ObservableCollection<Attribution> LesAttribution = new ObservableCollection<Attribution>();
            DataAccess accesBD = new DataAccess();
            String requete = "select commentaireattribution,dateattribution,idmateriel,idpersonnel from est_attribue;";
            DataTable datas = accesBD.GetData(requete);
            
            if (datas != null)
            {
                foreach (DataRow row in datas.Rows)
                {
                    Attribution e = new Attribution(row["commentaireattribution"].ToString(), DateTime.Parse(row["dateattribution"].ToString()), (int)row["idmateriel"], (int)row["idpersonnel"]); 
                    LesAttribution.Add(e);
                }
            }
            return LesAttribution;
        }

        public void Create()
        {
            DataAccess accesBD = new DataAccess();
            String requete = "INSERT INTO est_attribue (idpersonnel, idmateriel, dateattribution, commentaireattribution) values('" + this.IdPersonnels + "','" + this.IdMateriel + "','" + this.DateAttribution +"','" + this.CommentaireAttribution +"');";
            accesBD.SetData(requete);
        }

        void Crud<Attribution>.Read()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            DataAccess accesBD = new DataAccess();
            String requete = "UPDATE est_attribue SET commentaireattribution = '" + this.CommentaireAttribution + "' AND idmateriel = " + this.IdMateriel + " AND idpersonnel = " + this.IdPersonnels + " WHERE dateattribution = " + this.DateAttribution +"AND dateattribution = '" + this.DateAttribution;
            accesBD.SetData(requete);
        }

        public void Delete()
        {
            DataAccess accesBD = new DataAccess();
            String requete = "DELETE FROM est_attribue WHERE dateattribution = \'" + this.dateAttribution + "\' AND idmateriel = \'" + this.IdMateriel + "\' AND idpersonnel = \'" + this.IdPersonnels + "\'";
            accesBD.SetData(requete);
        }

        ObservableCollection<Attribution> Crud<Attribution>.FindAll()
        {
            throw new NotImplementedException();
        }

        ObservableCollection<Attribution> Crud<Attribution>.FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }

        void Crud<Attribution>.Update()
        {
            throw new NotImplementedException();
        }

    }
}
