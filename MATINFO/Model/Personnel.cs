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
    public class Personnel : Crud<Personnel>
    {
        private string emailPersonnel;
        private string nomPersonnel;
        private string prenomPersonnel;
        private int iD_Personnel = 1;

        public Personnel()
        {
        }

        public Personnel(string emailPersonnel, string nomPersonnel, string prenomPersonnel)
        {
            this.Email = emailPersonnel;
            this.NomPersonnel = nomPersonnel;
            this.PrenomPersonnel = prenomPersonnel;
            this.ID_Personnel++;
        }

        public string Email
        {
            get
            {
                return emailPersonnel;
            }

            set
            {
                int atIndex = emailPersonnel.IndexOf("@");
                int dotIndex = emailPersonnel.LastIndexOf(".");

                if (atIndex > 0 && atIndex > dotIndex)
                {
                    emailPersonnel = value;

                }
                else throw new ArgumentException("l'email n'est pas conforme");

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
                    Personnel e = new Personnel(row["emailpersonnel"].ToString(), row["nompersonnel"].ToString(), row["prenompersonnel"].ToString());
                    LesPersonnel.Add(e);
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

        void Crud<Personnel>.Update()
        {
            throw new NotImplementedException();
        }
    }

    public class Personnels
    {
    }
}
