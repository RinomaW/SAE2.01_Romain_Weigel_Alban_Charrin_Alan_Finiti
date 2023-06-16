using MATINFO.Model;
using MATINFO.MODEL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO.Model
{
    public class Personnel : Crud<Personnel>
    {
        private string emailPersonnel;
        private string nomPersonnel;
        private string prenomPersonnel;
        private int iD_Personnel = 1;
        ObservableCollection<Attribution> lesAttributions;

        public Personnel()
        {
        }

        public Personnel(string emailPersonnel, string nomPersonnel, string prenomPersonnel, int iD_Personnel)
        {
            this.Email = emailPersonnel;
            this.NomPersonnel = nomPersonnel;
            this.PrenomPersonnel = prenomPersonnel;
            this.ID_Personnel = iD_Personnel;
        }

        public string Email
        {
            get
            {
                return emailPersonnel;
            }

            set
            {
                    emailPersonnel = value;
            }
        }

        public string NomPersonnel
        {
            get
            {
                return nomPersonnel;
            }

            set
            {
                int number;
                if (int.TryParse(value, out number))
                    throw new ArgumentException("que en string");
                else nomPersonnel = value.ToUpper();
            }
        }

        public string PrenomPersonnel
        {
            get
            {
                return this.prenomPersonnel;
            }

            set
            {
                this.prenomPersonnel = value.Substring(0, 1).ToUpper() + value.Substring(1);
            }
        }

        public int ID_Personnel
        {
            get
            {
                return this.iD_Personnel;
            }

            set
            {
                this.iD_Personnel = value;
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

        void Crud<Personnel>.Create()
        {
            throw new NotImplementedException();
        }

        void Crud<Personnel>.Delete()
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Personnel> FindAll()
        {
            ObservableCollection<Personnel> LesPersonnel = new ObservableCollection<Personnel>();
            DataAccess accesBD = new DataAccess();
            String requete = "select emailpersonnel, nompersonnel, prenompersonnel from personnel";
            DataTable datas = accesBD.GetData(requete);
            if (datas != null)
            {
                foreach (DataRow row in datas.Rows)
                {
                    //Personnel e = new Personnel(row["emailpersonnel"].ToString(), row["nompersonnel"].ToString(), row["prenompersonnel"].ToString());
                    //LesPersonnel.Add(e);
                }
            }
            return LesPersonnel;
        }

        ObservableCollection<Personnel> Crud<Personnel>.FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }

        void Crud<Personnel>.Read()
        {
            throw new NotImplementedException();
        }


        void Crud<Personnel>.Update(string txt)
        {
            throw new NotImplementedException();
        }
    }

    public class Personnels
    {
    }
}
