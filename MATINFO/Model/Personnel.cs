using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO
{
    public class Personnel : CRUD
    {
        private string emailPersonnel;
        private string nomPersonnel;
        private string prenomPersonnel;
        private int iD_Personnel = 1;
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

        public override void Create()
        {
            base.Create();
        }

        public override void Delete()
        {
            base.Delete();
        }

        public override void Find()
        {
            base.Find();
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

    public class Personnels
    {
    }
}
