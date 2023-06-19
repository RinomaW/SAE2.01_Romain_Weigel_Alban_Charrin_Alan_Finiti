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
                if (value.Length > 0 && value.Contains("@") && value.IndexOf("@") < value.LastIndexOf(".") && value.LastIndexOf(".") < value.Length - 1)
                {
                    emailPersonnel = value;
                }
                else
                {
                    throw new ArgumentException("Le format de l'email est incorrect.");
                }
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
                if (!string.IsNullOrWhiteSpace(value) && !ContainsSpecialCharacters(value))
                {
                    nomPersonnel = value;
                }
                else
                {
                    throw new ArgumentException("Le format du nom est incorrect.");
                }
            }
        }

        public string PrenomPersonnel
        {
            get
            {
                return prenomPersonnel;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value) && !ContainsSpecialCharacters(value))
                {
                    prenomPersonnel = value;
                }
                else
                {
                    throw new ArgumentException("Le format du nom est incorrect.");
                }
            }
        }

        private bool ContainsSpecialCharacters(string value)
        {
            string specialCharacters = "~#-_;:!@£$%^&*()+=<>?/\\|{}[]`¨µ§€¤";
            return value.IndexOfAny(specialCharacters.ToCharArray()) != -1;
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

        public void Create()
        {
            String requete = "INSERT INTO personnel (emailpersonnel,nompersonnel, prenompersonnel) VALUES ('" + this.emailPersonnel + "','" + this.nomPersonnel + "','" + this.prenomPersonnel + "');";
            DataAccess accesBD = new DataAccess();
            accesBD.SetData(requete);
        }

        void Crud<Personnel>.Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            DataAccess accesBD = new DataAccess();
            String requete = "DELETE FROM Personnel WHERE nompersonnel = \"" + this.NomPersonnel + "\" AND prenompersonnel = \"" + this.PrenomPersonnel + "\" AND emailpersonnel = \"" + this.Email + "\"";
            accesBD.SetData(requete);
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


        public void Update(string nom, string prenom, string email)
        {
            String requete = "UPDATE Personnel SET emailpersonnel = " + email + "nompersonnel = " + nom + " , prenompersonnel = " + prenom + " WHERE idpersonnel = " + this.ID_Personnel;
            DataAccess accesBD = new DataAccess();
            accesBD.SetData(requete);
        }

        public void Update(string txt)
        {
            throw new NotImplementedException();
        }
        public static Personnel Find(string nomPersonnel)
        {
            ObservableCollection<Personnel> LesPersonnels = new ObservableCollection<Personnel>();
            Personnel pers = null;
            foreach (Personnel p in LesPersonnels)
            {
                if (p.NomPersonnel == nomPersonnel)
                    pers = p;
            }
            return pers;
        }
    }

    public class Personnels
    {
    }
}
